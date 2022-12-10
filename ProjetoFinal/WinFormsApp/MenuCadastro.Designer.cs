
namespace WinFormsApp
{
    partial class MenuCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCadastro));
            this.LBpergunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Bfisico = new System.Windows.Forms.Button();
            this.Bjuridica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LBpergunta
            // 
            this.LBpergunta.AutoSize = true;
            this.LBpergunta.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBpergunta.Location = new System.Drawing.Point(21, 33);
            this.LBpergunta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBpergunta.Name = "LBpergunta";
            this.LBpergunta.Size = new System.Drawing.Size(90, 32);
            this.LBpergunta.TabIndex = 0;
            this.LBpergunta.Text = "Você é:";
           
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 106);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 256);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(312, 106);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Bfisico
            // 
            this.Bfisico.BackColor = System.Drawing.Color.Goldenrod;
            this.Bfisico.ForeColor = System.Drawing.Color.White;
            this.Bfisico.Location = new System.Drawing.Point(48, 390);
            this.Bfisico.Margin = new System.Windows.Forms.Padding(4);
            this.Bfisico.Name = "Bfisico";
            this.Bfisico.Size = new System.Drawing.Size(181, 64);
            this.Bfisico.TabIndex = 3;
            this.Bfisico.Text = "Cliente Físico";
            this.Bfisico.UseVisualStyleBackColor = false;
            this.Bfisico.Click += new System.EventHandler(this.Bfisico_Click);
            this.Bfisico.MouseLeave += new System.EventHandler(this.Bfisico_MouseLeave);
            this.Bfisico.MouseHover += new System.EventHandler(this.Bfisico_MouseHover);
            // 
            // Bjuridica
            // 
            this.Bjuridica.BackColor = System.Drawing.Color.Goldenrod;
            this.Bjuridica.ForeColor = System.Drawing.Color.White;
            this.Bjuridica.Location = new System.Drawing.Point(296, 390);
            this.Bjuridica.Margin = new System.Windows.Forms.Padding(4);
            this.Bjuridica.Name = "Bjuridica";
            this.Bjuridica.Size = new System.Drawing.Size(181, 62);
            this.Bjuridica.TabIndex = 4;
            this.Bjuridica.Text = "Pessoa Jurídica";
            this.Bjuridica.UseVisualStyleBackColor = false;
            this.Bjuridica.Click += new System.EventHandler(this.Bjuridica_Click);
            this.Bjuridica.MouseLeave += new System.EventHandler(this.Bjuridica_MouseLeave);
            this.Bjuridica.MouseHover += new System.EventHandler(this.Bjuridica_MouseHover);
            // 
            // MenuCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(540, 511);
            this.Controls.Add(this.Bjuridica);
            this.Controls.Add(this.Bfisico);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LBpergunta);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuCadastro";
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBpergunta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Bfisico;
        private System.Windows.Forms.Button Bjuridica;
    }
}