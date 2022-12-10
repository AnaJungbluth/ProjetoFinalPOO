using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class MenuCadastro : Form
    {
        public MenuCadastro()
        {
            InitializeComponent();
        }

        private void Bfisico_Click(object sender, EventArgs e)
        {
            Cadastro outroform = new Cadastro(0);

            this.Visible = false;

            outroform.ShowDialog();
        }

        private void Bjuridica_Click(object sender, EventArgs e)
        {
            Cadastro outroform = new Cadastro(1);

            this.Visible = false;

            outroform.ShowDialog();

            
        }

        private void Bfisico_MouseHover(object sender, EventArgs e)
        {
            Bfisico.BackColor = Color.Gold;
        }

        private void Bfisico_MouseLeave(object sender, EventArgs e)
        {
            Bfisico.BackColor = Color.Goldenrod;
        }

        private void Bjuridica_MouseHover(object sender, EventArgs e)
        {
            Bjuridica.BackColor = Color.Gold;
        }

        private void Bjuridica_MouseLeave(object sender, EventArgs e)
        {
            Bjuridica.BackColor = Color.Goldenrod;
        }
    }
}
