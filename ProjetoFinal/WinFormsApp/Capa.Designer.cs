
namespace WinFormsApp
{
    partial class Capa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Capa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBempresa = new System.Windows.Forms.Label();
            this.Bfechar = new System.Windows.Forms.Button();
            this.Pmenu = new System.Windows.Forms.Panel();
            this.Bcontato = new System.Windows.Forms.Button();
            this.Bcadastro = new System.Windows.Forms.Button();
            this.Blogin = new System.Windows.Forms.Button();
            this.Bsobre = new System.Windows.Forms.Button();
            this.PBcapa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.Pmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBcapa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.LBempresa);
            this.panel1.Controls.Add(this.Bfechar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 40);
            this.panel1.TabIndex = 0;
            // 
            // LBempresa
            // 
            this.LBempresa.AutoSize = true;
            this.LBempresa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBempresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LBempresa.Location = new System.Drawing.Point(51, 6);
            this.LBempresa.Name = "LBempresa";
            this.LBempresa.Size = new System.Drawing.Size(331, 30);
            this.LBempresa.TabIndex = 1;
            this.LBempresa.Text = "Empresa de Serviços Domésticos";
            // 
            // Bfechar
            // 
            this.Bfechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bfechar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Bfechar.FlatAppearance.BorderSize = 0;
            this.Bfechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bfechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.Bfechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bfechar.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bfechar.Image = ((System.Drawing.Image)(resources.GetObject("Bfechar.Image")));
            this.Bfechar.Location = new System.Drawing.Point(492, 2);
            this.Bfechar.Name = "Bfechar";
            this.Bfechar.Size = new System.Drawing.Size(40, 34);
            this.Bfechar.TabIndex = 0;
            this.Bfechar.UseVisualStyleBackColor = true;
            this.Bfechar.Click += new System.EventHandler(this.Bfechar_Click);
            // 
            // Pmenu
            // 
            this.Pmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Pmenu.Controls.Add(this.Bcontato);
            this.Pmenu.Controls.Add(this.Bcadastro);
            this.Pmenu.Controls.Add(this.Blogin);
            this.Pmenu.Controls.Add(this.Bsobre);
            this.Pmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pmenu.ForeColor = System.Drawing.Color.White;
            this.Pmenu.Location = new System.Drawing.Point(0, 40);
            this.Pmenu.Name = "Pmenu";
            this.Pmenu.Size = new System.Drawing.Size(130, 500);
            this.Pmenu.TabIndex = 1;
            // 
            // Bcontato
            // 
            this.Bcontato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Bcontato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcontato.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bcontato.Location = new System.Drawing.Point(0, 277);
            this.Bcontato.Name = "Bcontato";
            this.Bcontato.Size = new System.Drawing.Size(130, 42);
            this.Bcontato.TabIndex = 4;
            this.Bcontato.Text = "Contato";
            this.Bcontato.UseVisualStyleBackColor = true;
            this.Bcontato.Click += new System.EventHandler(this.Bcontato_Click);
            this.Bcontato.MouseLeave += new System.EventHandler(this.Bcontato_MouseLeave);
            this.Bcontato.MouseHover += new System.EventHandler(this.Bcontato_MouseHover);
            // 
            // Bcadastro
            // 
            this.Bcadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Bcadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcadastro.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bcadastro.Location = new System.Drawing.Point(0, 229);
            this.Bcadastro.Name = "Bcadastro";
            this.Bcadastro.Size = new System.Drawing.Size(130, 42);
            this.Bcadastro.TabIndex = 3;
            this.Bcadastro.Text = "Cadastro";
            this.Bcadastro.UseVisualStyleBackColor = true;
            this.Bcadastro.Click += new System.EventHandler(this.Bcadastro_Click);
            this.Bcadastro.MouseLeave += new System.EventHandler(this.Bcadastro_MouseLeave);
            this.Bcadastro.MouseHover += new System.EventHandler(this.Bcadastro_MouseHover);
            // 
            // Blogin
            // 
            this.Blogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Blogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Blogin.Location = new System.Drawing.Point(0, 180);
            this.Blogin.Name = "Blogin";
            this.Blogin.Size = new System.Drawing.Size(130, 42);
            this.Blogin.TabIndex = 2;
            this.Blogin.Text = "Login";
            this.Blogin.UseVisualStyleBackColor = true;
            this.Blogin.Click += new System.EventHandler(this.Blogin_Click);
            this.Blogin.MouseLeave += new System.EventHandler(this.Blogin_MouseLeave);
            this.Blogin.MouseHover += new System.EventHandler(this.Blogin_MouseHover);
            // 
            // Bsobre
            // 
            this.Bsobre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Bsobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bsobre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bsobre.Location = new System.Drawing.Point(0, 132);
            this.Bsobre.Name = "Bsobre";
            this.Bsobre.Size = new System.Drawing.Size(130, 42);
            this.Bsobre.TabIndex = 0;
            this.Bsobre.Text = "Sobre";
            this.Bsobre.UseVisualStyleBackColor = true;
            this.Bsobre.Click += new System.EventHandler(this.Bsobre_Click);
            this.Bsobre.MouseLeave += new System.EventHandler(this.Bsobre_MouseLeave);
            this.Bsobre.MouseHover += new System.EventHandler(this.Bsobre_MouseHover);
            // 
            // PBcapa
            // 
            this.PBcapa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PBcapa.Image = global::WinFormsApp.Properties.Resources._2021_11_19__5_;
            this.PBcapa.Location = new System.Drawing.Point(130, 40);
            this.PBcapa.Name = "PBcapa";
            this.PBcapa.Size = new System.Drawing.Size(405, 500);
            this.PBcapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBcapa.TabIndex = 2;
            this.PBcapa.TabStop = false;
            // 
            // Capa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(535, 540);
            this.Controls.Add(this.PBcapa);
            this.Controls.Add(this.Pmenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Capa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Pmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBcapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Bfechar;
        private System.Windows.Forms.Label LBempresa;
        private System.Windows.Forms.Panel Pmenu;
        private System.Windows.Forms.Button Blogin;
        private System.Windows.Forms.Button Bsobre;
        private System.Windows.Forms.Button Bcontato;
        private System.Windows.Forms.Button Bcadastro;
        private System.Windows.Forms.PictureBox PBcapa;
    }
}