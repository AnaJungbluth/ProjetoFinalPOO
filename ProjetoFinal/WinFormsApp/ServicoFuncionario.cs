using Domain.Models.Funcionarios;
using Persistece.Persistence.DAL;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using Domain.Models.Servicos;

namespace WinFormsApp
{
    public partial class ServicoFuncionario : Form
    {
        private OrdemServicoDAL _ordemServicoDAL = new OrdemServicoDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoFinal"].ConnectionString));

        private ItemOrdemServicoDAL _itemOrdemServicoDAL = new ItemOrdemServicoDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoFinal"].ConnectionString));

        private FuncionarioDAL _funcionarioDAL = new FuncionarioDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoFinal"].ConnectionString));

        private bool _carregando = true;

        private Funcionario _funcionarioAtual;

        private Domain.Models.Servicos.OrdemServico _ordemServicoAtual;

        private ItemOrdemServico _itemOrdemServicoAtual;

        private Guid servicoIDSelecionado;
        private Guid funcionarioIDSelecionado;
        private Guid ordemSelecionada;

        private decimal valor;

        public ServicoFuncionario(Guid servicoIDSelecionado, decimal valor)
        {
            InitializeComponent();
            this.valor = valor;
            this.servicoIDSelecionado = servicoIDSelecionado;
            DTfuncionarios.DataSource = _funcionarioDAL.ObterFuncionariosPorServico(this.servicoIDSelecionado);
            
        }

        private void Bcontratar_Click(object sender, EventArgs e)
        {
            try
            {

                Guid ordemServicoID = _ordemServicoDAL.Gravar(new Domain.Models.Servicos.OrdemServico(
                    valor,  ordemServicoID: _ordemServicoAtual?.OrdemServicoID ?? null,
                    funcionarioID: funcionarioIDSelecionado,
                    clienteID: Login.ClienteSelecionado));
                

                _itemOrdemServicoDAL.Gravar(new ItemOrdemServico(
                    itemOrdemServicoID: _itemOrdemServicoAtual?.ItemOrdemServicoID ?? null,
                    servicoID: servicoIDSelecionado,
                    ordemServicoID: ordemServicoID)
                    );

                InicializarServicoFuncionario();


                MessageBox.Show("O contrato foi mandado para seu email, pague em até 3 dia úteis",
                    "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Aconteceu algum erro tente novamente", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InicializarServicoFuncionario()
        {
            _carregando = true;            
                     
            TBnome.Clear();
            TBsobrenome.Clear();    
            TBturno.Clear();
            TBhistorico.Clear();
            
            Bcancelar.Enabled = false;
            Bcontratar.Enabled = false;

            _funcionarioAtual = null;
            DTfuncionarios.ClearSelection();

            _carregando = false;
           
            TBnome.Focus();
        }

        private void ServicoFuncionario_Shown(object sender, EventArgs e)
        {
            InicializarServicoFuncionario();
            DTfuncionarios.Columns[0].Visible = false;
            DTfuncionarios.Columns[2].Visible = false;
            DTfuncionarios.Columns[3].Visible = false;
            DTfuncionarios.Columns[5].Visible = false;
            DTfuncionarios.Columns[6].Visible = false;
            DTfuncionarios.Columns[7].Visible = false;

            DTfuncionarios.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DTfuncionarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_carregando)
            {
                funcionarioIDSelecionado = Guid.Parse(DTfuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString());
                RegistrarFuncionarioAtual(DTfuncionarios.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    DTfuncionarios.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    DTfuncionarios.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    DTfuncionarios.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    DTfuncionarios.Rows[e.RowIndex].Cells[5].Value.ToString(),

                    funcionarioID: Guid.Parse(DTfuncionarios.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    servicoID: Guid.Parse(DTfuncionarios.Rows[e.RowIndex].Cells[6].Value.ToString()));
            }
        }

        private void ConfiguracaoDoFormularioItemSelecionado()
        {
            TBnome.Text = _funcionarioAtual.Nome;
            TBsobrenome.Text = _funcionarioAtual.Sobrenome;
            TBturno.Text = _funcionarioAtual.Turno;
            TBhistorico.Text = _funcionarioAtual.Historico;
            
            Bcancelar.Enabled = true;
            Bcontratar.Enabled = true;
        }

        private void RegistrarFuncionarioAtual(string nome, string sobrenome, string email, string turno,
           string historico, Guid? funcionarioID = null, Guid? servicoID = null)
        {
            _funcionarioAtual = new Funcionario(nome, sobrenome, email, turno, historico,
            funcionarioID: funcionarioID, servicoID: servicoID);
            ConfiguracaoDoFormularioItemSelecionado();
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            InicializarServicoFuncionario();
        }

    }
}
      
    

