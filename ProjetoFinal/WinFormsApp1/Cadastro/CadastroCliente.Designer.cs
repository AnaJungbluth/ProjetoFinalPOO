
namespace WinFormsApp1.Cadastro
{
    partial class CadastroCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomeLb = new System.Windows.Forms.Label();
            this.NomeTB = new System.Windows.Forms.TextBox();
            this.SobrenomeLb = new System.Windows.Forms.Label();
            this.SobrenomeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TelefoneLb = new System.Windows.Forms.Label();
            this.CPFLb = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.TelefoneTB = new System.Windows.Forms.TextBox();
            this.CPFTB = new System.Windows.Forms.TextBox();
            this.ProsseguriB = new System.Windows.Forms.Button();
            this.MenuB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SenhaTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NomeLb
            // 
            this.NomeLb.AutoSize = true;
            this.NomeLb.Location = new System.Drawing.Point(25, 9);
            this.NomeLb.Name = "NomeLb";
            this.NomeLb.Size = new System.Drawing.Size(47, 19);
            this.NomeLb.TabIndex = 0;
            this.NomeLb.Text = "Nome";
            this.NomeLb.Click += new System.EventHandler(this.label1_Click);
            // 
            // NomeTB
            // 
            this.NomeTB.Location = new System.Drawing.Point(25, 32);
            this.NomeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NomeTB.Name = "NomeTB";
            this.NomeTB.Size = new System.Drawing.Size(183, 24);
            this.NomeTB.TabIndex = 1;
            this.NomeTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // SobrenomeLb
            // 
            this.SobrenomeLb.AutoSize = true;
            this.SobrenomeLb.Location = new System.Drawing.Point(242, 9);
            this.SobrenomeLb.Name = "SobrenomeLb";
            this.SobrenomeLb.Size = new System.Drawing.Size(81, 19);
            this.SobrenomeLb.TabIndex = 2;
            this.SobrenomeLb.Text = "Sobrenome";
            // 
            // SobrenomeTB
            // 
            this.SobrenomeTB.Location = new System.Drawing.Point(242, 32);
            this.SobrenomeTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SobrenomeTB.Name = "SobrenomeTB";
            this.SobrenomeTB.Size = new System.Drawing.Size(194, 24);
            this.SobrenomeTB.TabIndex = 3;
            this.SobrenomeTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-mail *";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TelefoneLb
            // 
            this.TelefoneLb.AutoSize = true;
            this.TelefoneLb.Location = new System.Drawing.Point(242, 69);
            this.TelefoneLb.Name = "TelefoneLb";
            this.TelefoneLb.Size = new System.Drawing.Size(64, 19);
            this.TelefoneLb.TabIndex = 5;
            this.TelefoneLb.Text = "Telefone";
            this.TelefoneLb.Click += new System.EventHandler(this.label2_Click);
            // 
            // CPFLb
            // 
            this.CPFLb.AutoSize = true;
            this.CPFLb.Location = new System.Drawing.Point(25, 196);
            this.CPFLb.Name = "CPFLb";
            this.CPFLb.Size = new System.Drawing.Size(34, 19);
            this.CPFLb.TabIndex = 6;
            this.CPFLb.Text = "CPF";
            this.CPFLb.Click += new System.EventHandler(this.label3_Click);
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(25, 158);
            this.EmailTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(411, 24);
            this.EmailTB.TabIndex = 7;
            this.EmailTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // TelefoneTB
            // 
            this.TelefoneTB.Location = new System.Drawing.Point(242, 91);
            this.TelefoneTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TelefoneTB.Name = "TelefoneTB";
            this.TelefoneTB.Size = new System.Drawing.Size(194, 24);
            this.TelefoneTB.TabIndex = 8;
            this.TelefoneTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // CPFTB
            // 
            this.CPFTB.Location = new System.Drawing.Point(25, 219);
            this.CPFTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CPFTB.Name = "CPFTB";
            this.CPFTB.Size = new System.Drawing.Size(194, 24);
            this.CPFTB.TabIndex = 9;
            this.CPFTB.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // ProsseguriB
            // 
            this.ProsseguriB.BackColor = System.Drawing.Color.Green;
            this.ProsseguriB.Location = new System.Drawing.Point(25, 254);
            this.ProsseguriB.Name = "ProsseguriB";
            this.ProsseguriB.Size = new System.Drawing.Size(130, 33);
            this.ProsseguriB.TabIndex = 10;
            this.ProsseguriB.Text = "Prosseguir";
            this.ProsseguriB.UseVisualStyleBackColor = false;
            this.ProsseguriB.Click += new System.EventHandler(this.ProsseguriB_Click);
            // 
            // MenuB
            // 
            this.MenuB.BackColor = System.Drawing.Color.Green;
            this.MenuB.Location = new System.Drawing.Point(182, 254);
            this.MenuB.Name = "MenuB";
            this.MenuB.Size = new System.Drawing.Size(123, 33);
            this.MenuB.TabIndex = 11;
            this.MenuB.Text = "Voltar ao Menu";
            this.MenuB.UseVisualStyleBackColor = false;
            this.MenuB.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Senha";
            // 
            // SenhaTB
            // 
            this.SenhaTB.Location = new System.Drawing.Point(25, 91);
            this.SenhaTB.Name = "SenhaTB";
            this.SenhaTB.Size = new System.Drawing.Size(183, 24);
            this.SenhaTB.TabIndex = 13;
            this.SenhaTB.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(459, 299);
            this.Controls.Add(this.SenhaTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MenuB);
            this.Controls.Add(this.ProsseguriB);
            this.Controls.Add(this.CPFTB);
            this.Controls.Add(this.TelefoneTB);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.CPFLb);
            this.Controls.Add(this.TelefoneLb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SobrenomeTB);
            this.Controls.Add(this.SobrenomeLb);
            this.Controls.Add(this.NomeTB);
            this.Controls.Add(this.NomeLb);
            this.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCliente";
            this.Load += new System.EventHandler(this.CadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NomeLb;
        private System.Windows.Forms.TextBox NomeTB;
        private System.Windows.Forms.Label SobrenomeLb;
        private System.Windows.Forms.TextBox SobrenomeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TelefoneLb;
        private System.Windows.Forms.Label CPFLb;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.TextBox TelefoneTB;
        private System.Windows.Forms.TextBox CPFTB;
        private System.Windows.Forms.Button ProsseguriB;
        private System.Windows.Forms.Button MenuB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SenhaTB;
    }
}