
namespace WinFormsApp
{
    partial class MenuServico
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
            this.TBservico = new System.Windows.Forms.TextBox();
            this.DTmenuServico = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Bfuncionarios = new System.Windows.Forms.Button();
            this.Bcancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DTmenuServico)).BeginInit();
            this.SuspendLayout();
            // 
            // TBservico
            // 
            this.TBservico.Location = new System.Drawing.Point(25, 26);
            this.TBservico.Name = "TBservico";
            this.TBservico.ReadOnly = true;
            this.TBservico.Size = new System.Drawing.Size(285, 29);
            this.TBservico.TabIndex = 0;
            // 
            // DTmenuServico
            // 
            this.DTmenuServico.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DTmenuServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTmenuServico.Location = new System.Drawing.Point(25, 140);
            this.DTmenuServico.Name = "DTmenuServico";
            this.DTmenuServico.RowTemplate.Height = 25;
            this.DTmenuServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTmenuServico.Size = new System.Drawing.Size(492, 349);
            this.DTmenuServico.TabIndex = 2;
            this.DTmenuServico.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTmenuServico_RowEnter);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(12, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(516, 29);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Observação: os preços são referentes a MEIO TURNO, ou seja, meio dia.";
            // 
            // Bfuncionarios
            // 
            this.Bfuncionarios.BackColor = System.Drawing.Color.Goldenrod;
            this.Bfuncionarios.Enabled = false;
            this.Bfuncionarios.ForeColor = System.Drawing.Color.White;
            this.Bfuncionarios.Location = new System.Drawing.Point(341, 12);
            this.Bfuncionarios.Name = "Bfuncionarios";
            this.Bfuncionarios.Size = new System.Drawing.Size(176, 35);
            this.Bfuncionarios.TabIndex = 5;
            this.Bfuncionarios.Text = "Funcionários";
            this.Bfuncionarios.UseVisualStyleBackColor = false;
            this.Bfuncionarios.Click += new System.EventHandler(this.Bfuncionarios_Click);
            // 
            // Bcancelar
            // 
            this.Bcancelar.BackColor = System.Drawing.Color.Goldenrod;
            this.Bcancelar.Enabled = false;
            this.Bcancelar.ForeColor = System.Drawing.Color.White;
            this.Bcancelar.Location = new System.Drawing.Point(341, 53);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(176, 35);
            this.Bcancelar.TabIndex = 6;
            this.Bcancelar.Text = "Cancelar";
            this.Bcancelar.UseVisualStyleBackColor = false;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            // 
            // MenuServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(540, 511);
            this.Controls.Add(this.Bcancelar);
            this.Controls.Add(this.Bfuncionarios);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DTmenuServico);
            this.Controls.Add(this.TBservico);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MenuServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuServico";
            this.Shown += new System.EventHandler(this.MenuServico_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.DTmenuServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBservico;
        private System.Windows.Forms.DataGridView DTmenuServico;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Bfuncionarios;
        private System.Windows.Forms.Button Bcancelar;
    }
}