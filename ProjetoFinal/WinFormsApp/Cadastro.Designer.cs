
namespace WinFormsApp
{
    partial class Cadastro
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
            this.LBnome = new System.Windows.Forms.Label();
            this.LBsobrenome = new System.Windows.Forms.Label();
            this.LBemail = new System.Windows.Forms.Label();
            this.LBtelefone = new System.Windows.Forms.Label();
            this.TBnome = new System.Windows.Forms.TextBox();
            this.TBsobrenome = new System.Windows.Forms.TextBox();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.TBtelefone = new System.Windows.Forms.TextBox();
            this.LBsenha = new System.Windows.Forms.Label();
            this.TBsenha = new System.Windows.Forms.TextBox();
            this.LBrua = new System.Windows.Forms.Label();
            this.LBbairro = new System.Windows.Forms.Label();
            this.LBnumero = new System.Windows.Forms.Label();
            this.TBrua = new System.Windows.Forms.TextBox();
            this.TBbairro = new System.Windows.Forms.TextBox();
            this.TBnumero = new System.Windows.Forms.TextBox();
            this.Bsalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBnome
            // 
            this.LBnome.AutoSize = true;
            this.LBnome.Location = new System.Drawing.Point(33, 42);
            this.LBnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBnome.Name = "LBnome";
            this.LBnome.Size = new System.Drawing.Size(56, 21);
            this.LBnome.TabIndex = 0;
            this.LBnome.Text = "Nome:";
            // 
            // LBsobrenome
            // 
            this.LBsobrenome.AutoSize = true;
            this.LBsobrenome.Location = new System.Drawing.Point(291, 42);
            this.LBsobrenome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBsobrenome.Name = "LBsobrenome";
            this.LBsobrenome.Size = new System.Drawing.Size(94, 21);
            this.LBsobrenome.TabIndex = 1;
            this.LBsobrenome.Text = "Sobrenome:";
            // 
            // LBemail
            // 
            this.LBemail.AutoSize = true;
            this.LBemail.Location = new System.Drawing.Point(33, 113);
            this.LBemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBemail.Name = "LBemail";
            this.LBemail.Size = new System.Drawing.Size(57, 21);
            this.LBemail.TabIndex = 2;
            this.LBemail.Text = "E-mail:";
            // 
            // LBtelefone
            // 
            this.LBtelefone.AutoSize = true;
            this.LBtelefone.Location = new System.Drawing.Point(291, 190);
            this.LBtelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBtelefone.Name = "LBtelefone";
            this.LBtelefone.Size = new System.Drawing.Size(70, 21);
            this.LBtelefone.TabIndex = 3;
            this.LBtelefone.Text = "Telefone:";
          
            // 
            // TBnome
            // 
            this.TBnome.Location = new System.Drawing.Point(33, 67);
            this.TBnome.Margin = new System.Windows.Forms.Padding(4);
            this.TBnome.Name = "TBnome";
            this.TBnome.Size = new System.Drawing.Size(219, 29);
            this.TBnome.TabIndex = 5;
            // 
            // TBsobrenome
            // 
            this.TBsobrenome.Location = new System.Drawing.Point(291, 67);
            this.TBsobrenome.Margin = new System.Windows.Forms.Padding(4);
            this.TBsobrenome.Name = "TBsobrenome";
            this.TBsobrenome.Size = new System.Drawing.Size(206, 29);
            this.TBsobrenome.TabIndex = 6;
            
            // 
            // TBemail
            // 
            this.TBemail.Location = new System.Drawing.Point(33, 139);
            this.TBemail.Margin = new System.Windows.Forms.Padding(4);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(463, 29);
            this.TBemail.TabIndex = 7;
            // 
            // TBtelefone
            // 
            this.TBtelefone.Location = new System.Drawing.Point(291, 216);
            this.TBtelefone.Margin = new System.Windows.Forms.Padding(4);
            this.TBtelefone.Name = "TBtelefone";
            this.TBtelefone.Size = new System.Drawing.Size(206, 29);
            this.TBtelefone.TabIndex = 8;
          
            // 
            // LBsenha
            // 
            this.LBsenha.AutoSize = true;
            this.LBsenha.Location = new System.Drawing.Point(33, 190);
            this.LBsenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBsenha.Name = "LBsenha";
            this.LBsenha.Size = new System.Drawing.Size(56, 21);
            this.LBsenha.TabIndex = 9;
            this.LBsenha.Text = "Senha:";
            // 
            // TBsenha
            // 
            this.TBsenha.Location = new System.Drawing.Point(33, 216);
            this.TBsenha.Margin = new System.Windows.Forms.Padding(4);
            this.TBsenha.Name = "TBsenha";
            this.TBsenha.PasswordChar = '*';
            this.TBsenha.Size = new System.Drawing.Size(219, 29);
            this.TBsenha.TabIndex = 10;
            // 
            // LBrua
            // 
            this.LBrua.AutoSize = true;
            this.LBrua.Location = new System.Drawing.Point(33, 267);
            this.LBrua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBrua.Name = "LBrua";
            this.LBrua.Size = new System.Drawing.Size(40, 21);
            this.LBrua.TabIndex = 11;
            this.LBrua.Text = "Rua:";
            // 
            // LBbairro
            // 
            this.LBbairro.AutoSize = true;
            this.LBbairro.Location = new System.Drawing.Point(33, 340);
            this.LBbairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBbairro.Name = "LBbairro";
            this.LBbairro.Size = new System.Drawing.Size(55, 21);
            this.LBbairro.TabIndex = 12;
            this.LBbairro.Text = "Bairro:";
            // 
            // LBnumero
            // 
            this.LBnumero.AutoSize = true;
            this.LBnumero.Location = new System.Drawing.Point(291, 340);
            this.LBnumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBnumero.Name = "LBnumero";
            this.LBnumero.Size = new System.Drawing.Size(71, 21);
            this.LBnumero.TabIndex = 13;
            this.LBnumero.Text = "Número:";
            // 
            // TBrua
            // 
            this.TBrua.Location = new System.Drawing.Point(33, 293);
            this.TBrua.Margin = new System.Windows.Forms.Padding(4);
            this.TBrua.Name = "TBrua";
            this.TBrua.Size = new System.Drawing.Size(463, 29);
            this.TBrua.TabIndex = 14;
            // 
            // TBbairro
            // 
            this.TBbairro.Location = new System.Drawing.Point(35, 365);
            this.TBbairro.Margin = new System.Windows.Forms.Padding(4);
            this.TBbairro.Name = "TBbairro";
            this.TBbairro.Size = new System.Drawing.Size(217, 29);
            this.TBbairro.TabIndex = 15;
            // 
            // TBnumero
            // 
            this.TBnumero.Location = new System.Drawing.Point(291, 365);
            this.TBnumero.Margin = new System.Windows.Forms.Padding(4);
            this.TBnumero.Name = "TBnumero";
            this.TBnumero.Size = new System.Drawing.Size(108, 29);
            this.TBnumero.TabIndex = 16;
            // 
            // Bsalvar
            // 
            this.Bsalvar.BackColor = System.Drawing.Color.Goldenrod;
            this.Bsalvar.ForeColor = System.Drawing.Color.White;
            this.Bsalvar.Location = new System.Drawing.Point(405, 421);
            this.Bsalvar.Margin = new System.Windows.Forms.Padding(4);
            this.Bsalvar.Name = "Bsalvar";
            this.Bsalvar.Size = new System.Drawing.Size(93, 45);
            this.Bsalvar.TabIndex = 17;
            this.Bsalvar.Text = "Salvar";
            this.Bsalvar.UseVisualStyleBackColor = false;
            this.Bsalvar.Click += new System.EventHandler(this.Bsalvar_Click);
            this.Bsalvar.MouseLeave += new System.EventHandler(this.Bsalvar_MouseLeave);
            this.Bsalvar.MouseHover += new System.EventHandler(this.Bsalvar_MouseHover);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(540, 511);
            this.Controls.Add(this.Bsalvar);
            this.Controls.Add(this.TBnumero);
            this.Controls.Add(this.TBbairro);
            this.Controls.Add(this.TBrua);
            this.Controls.Add(this.LBnumero);
            this.Controls.Add(this.LBbairro);
            this.Controls.Add(this.LBrua);
            this.Controls.Add(this.TBsenha);
            this.Controls.Add(this.LBsenha);
            this.Controls.Add(this.TBtelefone);
            this.Controls.Add(this.TBemail);
            this.Controls.Add(this.TBsobrenome);
            this.Controls.Add(this.TBnome);
            this.Controls.Add(this.LBtelefone);
            this.Controls.Add(this.LBemail);
            this.Controls.Add(this.LBsobrenome);
            this.Controls.Add(this.LBnome);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBnome;
        private System.Windows.Forms.Label LBsobrenome;
        private System.Windows.Forms.Label LBemail;
        private System.Windows.Forms.Label LBtelefone;
        private System.Windows.Forms.TextBox TBnome;
        private System.Windows.Forms.TextBox TBsobrenome;
        private System.Windows.Forms.TextBox TBemail;
        private System.Windows.Forms.TextBox TBtelefone;
        private System.Windows.Forms.Label LBsenha;
        private System.Windows.Forms.TextBox TBsenha;
        private System.Windows.Forms.Label LBrua;
        private System.Windows.Forms.Label LBbairro;
        private System.Windows.Forms.Label LBnumero;
        private System.Windows.Forms.TextBox TBrua;
        private System.Windows.Forms.TextBox TBbairro;
        private System.Windows.Forms.TextBox TBnumero;
        private System.Windows.Forms.Button Bsalvar;
    }
}