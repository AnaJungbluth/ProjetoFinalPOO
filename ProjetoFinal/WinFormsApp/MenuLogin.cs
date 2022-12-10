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
    public partial class MenuLogin : Form
    {
        public MenuLogin()
        {
            InitializeComponent();
        }

        private void Bfisico_Click(object sender, EventArgs e)
        {
            Login outroform = new Login(0);

            this.Visible = false;

            outroform.ShowDialog();
        }

        private void Bjuridico_Click(object sender, EventArgs e)
        {
            Login outroform = new Login(1);

            this.Visible = false;

            outroform.ShowDialog();
        }

        private void Bgerente_Click(object sender, EventArgs e)
        {
            Login outroform = new Login(2);

            this.Visible = false;

            outroform.ShowDialog();
        }
    }
}
