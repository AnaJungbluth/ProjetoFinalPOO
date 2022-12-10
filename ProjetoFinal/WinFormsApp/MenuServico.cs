using Domain.Models.Servicos;
using ProjetoFinal.Persistence.DAL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MenuServico : Form
    {
        private ServicoDAL _dal = new ServicoDAL(new SqlConnection(
        ConfigurationManager.ConnectionStrings["ProjetoFinal"].ConnectionString));

        private bool _carregando = true;

        private Guid servicoIDSelecionado;

        private decimal valor;

        public MenuServico()
        {
            InitializeComponent();
            DTmenuServico.DataSource = _dal.ObterTodos();
            DTmenuServico.Columns[0].Visible = false;
            DTmenuServico.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void DTmenuServico_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!_carregando)
            {
                servicoIDSelecionado = Guid.Parse(DTmenuServico.Rows[e.RowIndex].Cells[0].Value.ToString());
                valor = decimal.Parse(DTmenuServico.Rows[e.RowIndex].Cells[2].Value.ToString());
                TBservico.Text = DTmenuServico.Rows[e.RowIndex].Cells[1].Value.ToString();
                Bfuncionarios.Enabled = true;
                Bcancelar.Enabled = true;
            }
        }
        private void MenuServico_Shown(object sender, EventArgs e)
        {
            DTmenuServico.ClearSelection();
            _carregando = false;
        }

        private void Bfuncionarios_Click(object sender, EventArgs e)
        {
            ServicoFuncionario outroForm = new ServicoFuncionario(servicoIDSelecionado, valor);

            outroForm.ShowDialog();                
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            TBservico.Clear();
            DTmenuServico.ClearSelection();
            Bcancelar.Enabled = false;
            Bfuncionarios.Enabled = false;
        }
    }
}
