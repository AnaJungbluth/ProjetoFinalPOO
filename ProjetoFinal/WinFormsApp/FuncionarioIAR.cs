using Domain.Models.Funcionarios;
using Domain.Models.Servicos;
using Persistece.Persistence.DAL;
using ProjetoFinal.Persistence.DAL;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FuncionarioIAR : Form
    {
        private ServicoDAL _servicoDAL = new ServicoDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoFinal"].ConnectionString));

        private FuncionarioDAL _funcionarioDAL = new FuncionarioDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoFinal"].ConnectionString));

        private bool _carregando = true;

        private Funcionario _funcionarioAtual;


        public FuncionarioIAR()
        {
            InitializeComponent();
        }

        private void Bgravar_Click(object sender, EventArgs e)
        {
            try
            {
                _funcionarioDAL.Gravar(new Funcionario(
                    TBnome.Text, TBsobrenome.Text, TBemail.Text, TBturno.Text, TBhistorico.Text,
                    funcionarioID: _funcionarioAtual?.FuncionarioID ?? null,
                    servicoID: CBservico.SelectedItem == null ?
                    null : (CBservico.SelectedItem as Servico).ServicoID));

                InicializarFuncionarioIAR();
                MessageBox.Show("Registro salvo", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
        private void InicializarFuncionarioIAR()
        {
            _carregando = true;
            DTfuncionario.DataSource = _funcionarioDAL.ObterTodos();
            CBservico.DataSource = _servicoDAL.ObterTodos();
            CBservico.DisplayMember = "Descricao";
            CBservico.ValueMember = "ServicoID";

            TBnome.Clear();
            TBsobrenome.Clear();
            TBemail.Clear();
            TBturno.Clear();
            TBhistorico.Clear();
            CBservico.SelectedIndex = -1;

            Bcancelar.Enabled = false;
            Bremover.Enabled = false;

            _funcionarioAtual = null;
            DTfuncionario.ClearSelection();
            _carregando = false;
        }

        private void FuncionarioIAR_Shown(object sender, EventArgs e)
        {
            InicializarFuncionarioIAR();
            DTfuncionario.Columns[0].Visible = false;
            DTfuncionario.Columns[3].Visible = false;
            DTfuncionario.Columns[5].Visible = false;
            DTfuncionario.Columns[6].Visible = false;
            DTfuncionario.Columns[7].Visible = false;

            DTfuncionario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;            
        }

        
        private void DTfuncionario_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_carregando)
            {
                RegistrarFuncionarioAtual(DTfuncionario.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    DTfuncionario.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    DTfuncionario.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    DTfuncionario.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    DTfuncionario.Rows[e.RowIndex].Cells[5].Value.ToString(),

                    funcionarioID: Guid.Parse(DTfuncionario.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    servicoID: Guid.Parse(DTfuncionario.Rows[e.RowIndex].Cells[6].Value.ToString()));
            }
        }
        private void ConfiguracaoDoFormularioItemSelecionado()
        {
            TBnome.Text = _funcionarioAtual.Nome;
            TBsobrenome.Text = _funcionarioAtual.Sobrenome;
            TBemail.Text = _funcionarioAtual.Email;
            TBturno.Text = _funcionarioAtual.Turno;
            TBhistorico.Text = _funcionarioAtual.Historico;
            CBservico.SelectedValue = _funcionarioAtual.ServicoID;

            Bcancelar.Enabled = true;
            Bremover.Enabled = true;
        }

        private void RegistrarFuncionarioAtual(string nome, string sobrenome, string email, string turno,
            string historico, Guid? funcionarioID = null, Guid? servicoID = null)
        {
            _funcionarioAtual = new Funcionario(nome, sobrenome, email, turno, historico,
            funcionarioID: funcionarioID, servicoID: servicoID);
            ConfiguracaoDoFormularioItemSelecionado();
        }

        private void Bremover_Click(object sender, EventArgs e)
        {
            if (_funcionarioAtual == null)
            {
                MessageBox.Show("É preciso selecionar para remover", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Confirma remover" +
                $" {_funcionarioAtual.Nome.ToUpper()}",
                "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.No)
            {
                return;
            }

            _funcionarioDAL.Remover(_funcionarioAtual);

            InicializarFuncionarioIAR();
            MessageBox.Show("Registro removido", "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            InicializarFuncionarioIAR();
        }

        private void Bgravar_MouseHover(object sender, EventArgs e)
        {
            Bgravar.BackColor = Color.Gold;
        }

        private void Bgravar_MouseLeave(object sender, EventArgs e)
        {
            Bgravar.BackColor = Color.Goldenrod;
        }

        private void Bremover_MouseHover(object sender, EventArgs e)
        {
            Bremover.BackColor = Color.Gold;
        }

        private void Bremover_MouseLeave(object sender, EventArgs e)
        {
            Bremover.BackColor = Color.Goldenrod;
        }

        private void Bcancelar_MouseHover(object sender, EventArgs e)
        {
            Bcancelar.BackColor = Color.Gold;
        }

        private void Bcancelar_MouseLeave(object sender, EventArgs e)
        {
            Bcancelar.BackColor = Color.Goldenrod;
        }

    }
}

