using Domain.Models;
using System;
using System.Windows.Forms;

namespace WinFormsApp1.Cadastro
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void ProsseguriB_Click(object sender, EventArgs e)
        {
            PessoaFisica fisica = new PessoaFisica(NomeTB.Text,
                SobrenomeTB.Text, SenhaTB.Text, TelefoneTB.Text,
                EmailTB.Text, CPFTB.Text);
        }
    }
}
