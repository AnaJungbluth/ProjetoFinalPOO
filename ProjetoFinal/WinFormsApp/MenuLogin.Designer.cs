
namespace WinFormsApp
{
    partial class MenuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLogin));
            this.Lpergunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Bfisico = new System.Windows.Forms.Button();
            this.Bjuridico = new System.Windows.Forms.Button();
            this.Bgerente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Lpergunta
            // 
            this.Lpergunta.AutoSize = true;
            this.Lpergunta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lpergunta.Location = new System.Drawing.Point(27, 26);
            this.Lpergunta.Name = "Lpergunta";
            this.Lpergunta.Size = new System.Drawing.Size(84, 30);
            this.Lpergunta.TabIndex = 0;
            this.Lpergunta.Text = "Você é:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 90);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 256);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(199, 90);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(148, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(369, 90);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(148, 256);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Bfisico
            // 
            this.Bfisico.BackColor = System.Drawing.Color.Goldenrod;
            this.Bfisico.ForeColor = System.Drawing.Color.White;
            this.Bfisico.Location = new System.Drawing.Point(27, 383);
            this.Bfisico.Margin = new System.Windows.Forms.Padding(4);
            this.Bfisico.Name = "Bfisico";
            this.Bfisico.Size = new System.Drawing.Size(147, 64);
            this.Bfisico.TabIndex = 5;
            this.Bfisico.Text = "Cliente Físico";
            this.Bfisico.UseVisualStyleBackColor = false;
            this.Bfisico.Click += new System.EventHandler(this.Bfisico_Click);
            // 
            // Bjuridico
            // 
            this.Bjuridico.BackColor = System.Drawing.Color.Goldenrod;
            this.Bjuridico.ForeColor = System.Drawing.Color.White;
            this.Bjuridico.Location = new System.Drawing.Point(199, 383);
            this.Bjuridico.Margin = new System.Windows.Forms.Padding(4);
            this.Bjuridico.Name = "Bjuridico";
            this.Bjuridico.Size = new System.Drawing.Size(148, 64);
            this.Bjuridico.TabIndex = 6;
            this.Bjuridico.Text = "Cliente Juridico";
            this.Bjuridico.UseVisualStyleBackColor = false;
            this.Bjuridico.Click += new System.EventHandler(this.Bjuridico_Click);
            // 
            // Bgerente
            // 
            this.Bgerente.BackColor = System.Drawing.Color.Goldenrod;
            this.Bgerente.ForeColor = System.Drawing.Color.White;
            this.Bgerente.Location = new System.Drawing.Point(369, 383);
            this.Bgerente.Margin = new System.Windows.Forms.Padding(4);
            this.Bgerente.Name = "Bgerente";
            this.Bgerente.Size = new System.Drawing.Size(148, 64);
            this.Bgerente.TabIndex = 7;
            this.Bgerente.Text = "Gerente";
            this.Bgerente.UseVisualStyleBackColor = false;
            this.Bgerente.Click += new System.EventHandler(this.Bgerente_Click);
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(540, 511);
            this.Controls.Add(this.Bgerente);
            this.Controls.Add(this.Bjuridico);
            this.Controls.Add(this.Bfisico);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lpergunta);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lpergunta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Bfisico;
        private System.Windows.Forms.Button Bjuridico;
        private System.Windows.Forms.Button Bgerente;
    }
}