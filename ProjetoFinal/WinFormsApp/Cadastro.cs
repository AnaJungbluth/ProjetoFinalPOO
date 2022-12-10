using Domain.Models;
using Domain.Models.Pessoas.Endereco;
using Persistece.Persistence.DAL;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Cadastro : Form
    {
        private int tipoPessoa;

        private PessoaDAL _dal = new PessoaDAL(new SqlConnection(
            ConfigurationManager.ConnectionStrings["ProjetoFinal"].ConnectionString));

        private Pessoa _pessoaAtual = null;
        public Cadastro(int tipo)
        {
            InitializeComponent();
            tipoPessoa = tipo;
            if(tipo == 1)
            {
                TBsobrenome
                    .Visible = false;
                LBsobrenome
                    .Visible = false;
            }
        }

        private void Bsalvar_MouseHover(object sender, EventArgs e)
        {
            Bsalvar.BackColor = Color.Gold;
        }

        private void Bsalvar_MouseLeave(object sender, EventArgs e)
        {
            Bsalvar.BackColor = Color.Goldenrod;
        }

        private void Bsalvar_Click(object sender, EventArgs e)
        {
            Pessoa pessoa;
            if(tipoPessoa == 1)
            {
                try
                {
                    pessoa = new PessoaJuridica(TBnome.Text, TBsenha.Text, TBemail.Text,
                         TBtelefone.Text, new Endereco(TBrua.Text, TBnumero.Text, TBbairro.Text),
                         pessoaID: _pessoaAtual?.PessoaID ?? null);

                    _dal.Gravar(pessoa);

                    MessageBox.Show("Conta criada!!!" +
                        "Faça seu login agora", "Sucesso", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    Login outroform = new Login(1);
                    this.Visible = false;
                    outroform.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    pessoa = new PessoaFisica(TBnome.Text, TBsobrenome.Text, TBsenha.Text, TBemail.Text,
                     TBtelefone.Text, new Endereco(TBrua.Text, TBnumero.Text, TBbairro.Text),
                       pessoaID: _pessoaAtual?.PessoaID ?? null);

                    _dal.Gravar(pessoa);

                    MessageBox.Show("Conta criada!!!" +
                        "Faça seu login agora", "Sucesso", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);

                    Login outroform = new Login(0);
                    this.Visible = false;
                    outroform.ShowDialog();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

    }
}
