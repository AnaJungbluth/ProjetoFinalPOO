using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Capa : Form
    {
        public Capa()
        {
            InitializeComponent();
        }

        private void Bfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Blogin_Click(object sender, EventArgs e)
        {
            MenuLogin outroform = new MenuLogin();

            outroform.ShowDialog();
        }

        private void Bcadastro_Click(object sender, EventArgs e)
        {
            MenuCadastro outroform = new MenuCadastro();

            outroform.ShowDialog();
        }

        private void Bsobre_Click(object sender, EventArgs e)
        {
            SobreEmpresa outroform = new SobreEmpresa();

            outroform.ShowDialog();
        }

        private void Bsobre_MouseHover(object sender, EventArgs e)
        {
            Bsobre.BackColor = Color.LightBlue;
        }

        private void Bsobre_MouseLeave(object sender, EventArgs e)
        {
            Bsobre.BackColor = Color.Transparent;
        }

        private void Blogin_MouseHover(object sender, EventArgs e)
        {
            Blogin.BackColor = Color.LightBlue;

        }

        private void Blogin_MouseLeave(object sender, EventArgs e)
        {
            Blogin.BackColor = Color.Transparent;
        }

        private void Bcadastro_MouseHover(object sender, EventArgs e)
        {
            Bcadastro.BackColor = Color.LightBlue;
        }

        private void Bcadastro_MouseLeave(object sender, EventArgs e)
        {
            Bcadastro.BackColor = Color.Transparent;
        }

        private void Bcontato_MouseHover(object sender, EventArgs e)
        {
            Bcontato.BackColor = Color.LightBlue;
        }

        private void Bcontato_MouseLeave(object sender, EventArgs e)
        {
            Bcontato.BackColor = Color.Transparent;
        }

        private void Bcontato_Click(object sender, EventArgs e)
        {
            Contato outroform = new Contato();

            outroform.ShowDialog();
        }
    }
}
