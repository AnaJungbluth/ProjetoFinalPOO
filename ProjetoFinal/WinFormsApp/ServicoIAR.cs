using Domain.Models.Servicos;
using ProjetoFinal.Persistence.DAL;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class ServicoIAR : Form
    {
        private ServicoDAL _dal = new ServicoDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoFinal"].ConnectionString));

        private bool _carregando = true;

        private Servico _servicoAtual;
        public ServicoIAR()
        {
            InitializeComponent();
            
        }

        private void Bgravar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal preco = decimal.Parse(TBpreco.Text);
               
                _dal.Gravar(new Servico(
                    TBnome.Text, preco, servicoID: _servicoAtual?.ServicoID ?? null));

                InicializarServicoIAR();
                MessageBox.Show("Registro salvo","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch(FormatException)
            {
                MessageBox.Show("Digite apenas valores numéricos","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void DTservico_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_carregando)
            {
                RegistrarServicoAtual(DTservico.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    decimal.Parse(DTservico.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    servicoID: Guid.Parse(DTservico.Rows[e.RowIndex].Cells[0].Value.ToString()));

            }
        }

        private void InicializarServicoIAR()
        {
            _carregando = true;
            DTservico.DataSource = _dal.ObterTodos();

            TBnome.Clear();
            TBpreco.Clear();
            Bcancelar.Enabled = false;

            _servicoAtual = null;
            DTservico.ClearSelection();
            _carregando = false;
            TBnome.Focus();
        }

        private void ConfiguracaoDoFormularioItemSelecionado()
        {
            TBnome.Text = _servicoAtual.Descricao;
            TBpreco.Text = _servicoAtual.Preco.ToString();
            Bcancelar.Enabled = true;
        }

        private void RegistrarServicoAtual(string descricao, decimal preco, 
            Guid? servicoID = null)
        {
            _servicoAtual = new Servico(descricao, preco, servicoID: servicoID);
            ConfiguracaoDoFormularioItemSelecionado();
        }

        private void ServicoIAR_Shown(object sender, EventArgs e)
        {
            InicializarServicoIAR();
            DTservico.Columns[0].Visible = false;
            DTservico.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            DTservico.ClearSelection();
        }

        private void Bremover_Click(object sender, EventArgs e)
        {
            if(_servicoAtual == null)
            {
                MessageBox.Show("É preciso selecionar para remover", "Informação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }

            if(MessageBox.Show($"Confirma remover {_servicoAtual.Descricao.ToUpper()}",
                "Questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.No)
            {
                return;
            }

            _dal.Remover(_servicoAtual);

            InicializarServicoIAR();
            MessageBox.Show("Registro removido", "Sucesso", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            InicializarServicoIAR();
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

        private void DTservico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TBpreco_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
