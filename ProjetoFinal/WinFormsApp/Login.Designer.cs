
namespace WinFormsApp
{
    partial class Login
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
            this.LBLemail = new System.Windows.Forms.Label();
            this.LBLsenha = new System.Windows.Forms.Label();
            this.TBLemail = new System.Windows.Forms.TextBox();
            this.TBLsenha = new System.Windows.Forms.TextBox();
            this.Bentrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLemail
            // 
            this.LBLemail.AutoSize = true;
            this.LBLemail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLemail.Location = new System.Drawing.Point(40, 136);
            this.LBLemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLemail.Name = "LBLemail";
            this.LBLemail.Size = new System.Drawing.Size(57, 21);
            this.LBLemail.TabIndex = 0;
            this.LBLemail.Text = "E-mail:";
            // 
            // LBLsenha
            // 
            this.LBLsenha.AutoSize = true;
            this.LBLsenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBLsenha.Location = new System.Drawing.Point(40, 238);
            this.LBLsenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLsenha.Name = "LBLsenha";
            this.LBLsenha.Size = new System.Drawing.Size(56, 21);
            this.LBLsenha.TabIndex = 1;
            this.LBLsenha.Text = "Senha:";
            // 
            // TBLemail
            // 
            this.TBLemail.Location = new System.Drawing.Point(102, 133);
            this.TBLemail.Name = "TBLemail";
            this.TBLemail.Size = new System.Drawing.Size(342, 29);
            this.TBLemail.TabIndex = 2;
            // 
            // TBLsenha
            // 
            this.TBLsenha.Location = new System.Drawing.Point(102, 235);
            this.TBLsenha.Name = "TBLsenha";
            this.TBLsenha.PasswordChar = '*';
            this.TBLsenha.Size = new System.Drawing.Size(341, 29);
            this.TBLsenha.TabIndex = 3;
            // 
            // Bentrar
            // 
            this.Bentrar.BackColor = System.Drawing.Color.Goldenrod;
            this.Bentrar.ForeColor = System.Drawing.Color.White;
            this.Bentrar.Location = new System.Drawing.Point(351, 324);
            this.Bentrar.Name = "Bentrar";
            this.Bentrar.Size = new System.Drawing.Size(113, 49);
            this.Bentrar.TabIndex = 4;
            this.Bentrar.Text = "Entrar";
            this.Bentrar.UseVisualStyleBackColor = false;
            this.Bentrar.Click += new System.EventHandler(this.BLentrar_Click);
            this.Bentrar.MouseLeave += new System.EventHandler(this.Bentrar_MouseLeave);
            this.Bentrar.MouseHover += new System.EventHandler(this.Bentrar_MouseHover);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(540, 511);
            this.Controls.Add(this.Bentrar);
            this.Controls.Add(this.TBLsenha);
            this.Controls.Add(this.TBLemail);
            this.Controls.Add(this.LBLsenha);
            this.Controls.Add(this.LBLemail);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLemail;
        private System.Windows.Forms.Label LBLsenha;
        private System.Windows.Forms.TextBox TBLemail;
        private System.Windows.Forms.TextBox TBLsenha;
        private System.Windows.Forms.Button Bentrar;
    }
}