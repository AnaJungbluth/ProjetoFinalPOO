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
    public partial class MenuGerente : Form
    {
        public MenuGerente()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FuncionarioIAR outroform = new FuncionarioIAR();

            outroform.ShowDialog();
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicoIAR outroform = new ServicoIAR();

            outroform.ShowDialog();
        }
    }
}
