using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{

    public partial class Login : Form
    {
        private int tipoLogin;

        public static string usuarioConectado;
        public static string NivelAcesso;
        public static Guid   ClienteSelecionado;

        SqlConnection _conn = new SqlConnection(
           ConfigurationManager.ConnectionStrings["ProjetoFinal"].ConnectionString);
   
        public Login(int tipo)
        {
            InitializeComponent();
            tipoLogin = tipo;
        }

        private void BLentrar_Click(object sender, EventArgs e)
        {
            if (tipoLogin == 0)
            {
                try
                {
                    if ((TBLemail.Text != "") && (TBLsenha.Text != ""))
                    {
                        SqlCommand comm = new SqlCommand("Select FisicaID, Email, Senha" +
                            " From Tb_PessoaFisica" +
                            " Where Email = @email and Senha = @senha", _conn);

                        comm.Parameters.Add("@email", SqlDbType.VarChar).Value = TBLemail.Text;
                        comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = TBLsenha.Text;

                        _conn.Open();

                        SqlDataReader reader = null;
                        reader = comm.ExecuteReader();
                      
                        if (reader.Read())
                        {          
                            usuarioConectado = TBLemail.Text;                          
                            NivelAcesso = TBLsenha.Text;
                            ClienteSelecionado = reader.GetGuid(0);
 
                            MenuServico servico = new MenuServico();                           
                            this.Visible = false;                           
                            servico.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Usuário e/ou senha incorretas", "Aviso de Segurança",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos os Campos são obrigatórios", "Aviso de Segurança",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    _conn.Close();
                }
            }
            else if (tipoLogin == 1)
            {
                try
                {
                    if ((TBLemail.Text != "") && (TBLsenha.Text != ""))
                    {
                        SqlCommand comm = new SqlCommand("Select JuridicaID, Email, Senha" +
                            " From Tb_PessoaJuridica" +
                            " Where Email = @email and Senha = @senha", _conn);

                        comm.Parameters.Add("@email", SqlDbType.VarChar).Value = TBLemail.Text;
                        comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = TBLsenha.Text;

                        _conn.Open();

                        SqlDataReader reader = null;
                        reader = comm.ExecuteReader();

                        if (reader.Read())
                        {
                            usuarioConectado = TBLemail.Text;
                            NivelAcesso = TBLsenha.Text;
                            ClienteSelecionado = reader.GetGuid(0);

                            MenuServico servico = new MenuServico();
                            this.Visible = false;
                            servico.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Usuário e/ou senha incorretas", "Aviso de Segurança",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos os Campos são obrigatórios", "Aviso de Segurança",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    _conn.Close();
                }
            }
            else if (tipoLogin == 2)
            {

                try
                {
                    if ((TBLemail.Text != "") && (TBLsenha.Text != ""))
                    {
                        SqlCommand comm = new SqlCommand("Select * From Tb_Gerente" +
                            " Where Email = @email and Senha = @senha", _conn);

                        comm.Parameters.Add("@email", SqlDbType.VarChar).Value = TBLemail.Text;
                        comm.Parameters.Add("@senha", SqlDbType.VarChar).Value = TBLsenha.Text;

                        _conn.Open();

                        SqlDataReader reader = null;
                        reader = comm.ExecuteReader();

                        if (reader.Read())
                        {
                            usuarioConectado = TBLemail.Text;
                            NivelAcesso = TBLsenha.Text;


                            MenuGerente gerente = new MenuGerente();
                            this.Visible = false;
                            gerente.ShowDialog();
                            
                        }
                        else
                        {
                            MessageBox.Show("Usuário e/ou senha incorretas", "Aviso de Segurança",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Todos os Campos são obrigatórios", "Aviso de Segurança",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    _conn.Close();
                }

            }
        }       

        private void Bentrar_MouseHover(object sender, EventArgs e)
        {
            Bentrar.BackColor = Color.Gold;
        }

        private void Bentrar_MouseLeave(object sender, EventArgs e)
        {
            Bentrar.BackColor = Color.Goldenrod;
        }

    }
}
