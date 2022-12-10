
namespace WinFormsApp
{
    partial class ServicoIAR
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LBnome = new System.Windows.Forms.Label();
            this.LBpreco = new System.Windows.Forms.Label();
            this.TBnome = new System.Windows.Forms.TextBox();
            this.TBpreco = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Bgravar = new System.Windows.Forms.Button();
            this.Bremover = new System.Windows.Forms.Button();
            this.Bcancelar = new System.Windows.Forms.Button();
            this.DTservico = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTservico)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.tableLayoutPanel1.Controls.Add(this.LBnome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.LBpreco, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBnome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBpreco, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.DTservico, 0, 7);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 501);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LBnome
            // 
            this.LBnome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBnome.AutoSize = true;
            this.LBnome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBnome.Location = new System.Drawing.Point(4, 31);
            this.LBnome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBnome.Name = "LBnome";
            this.LBnome.Size = new System.Drawing.Size(80, 21);
            this.LBnome.TabIndex = 0;
            this.LBnome.Text = "Descrição:";
            // 
            // LBpreco
            // 
            this.LBpreco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBpreco.AutoSize = true;
            this.LBpreco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBpreco.Location = new System.Drawing.Point(4, 101);
            this.LBpreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBpreco.Name = "LBpreco";
            this.LBpreco.Size = new System.Drawing.Size(52, 21);
            this.LBpreco.TabIndex = 1;
            this.LBpreco.Text = "Preço:";
            // 
            // TBnome
            // 
            this.TBnome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBnome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBnome.Location = new System.Drawing.Point(101, 27);
            this.TBnome.Margin = new System.Windows.Forms.Padding(4);
            this.TBnome.Name = "TBnome";
            this.TBnome.Size = new System.Drawing.Size(435, 29);
            this.TBnome.TabIndex = 2;
            // 
            // TBpreco
            // 
            this.TBpreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBpreco.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBpreco.Location = new System.Drawing.Point(101, 97);
            this.TBpreco.Margin = new System.Windows.Forms.Padding(4);
            this.TBpreco.Name = "TBpreco";
            this.TBpreco.Size = new System.Drawing.Size(435, 29);
            this.TBpreco.TabIndex = 3;
            this.TBpreco.TextChanged += new System.EventHandler(this.TBpreco_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Bgravar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Bremover, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Bcancelar, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 158);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(532, 48);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // Bgravar
            // 
            this.Bgravar.BackColor = System.Drawing.Color.Goldenrod;
            this.Bgravar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bgravar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bgravar.ForeColor = System.Drawing.Color.White;
            this.Bgravar.Location = new System.Drawing.Point(4, 4);
            this.Bgravar.Margin = new System.Windows.Forms.Padding(4);
            this.Bgravar.Name = "Bgravar";
            this.Bgravar.Size = new System.Drawing.Size(160, 40);
            this.Bgravar.TabIndex = 0;
            this.Bgravar.Text = "Gravar";
            this.Bgravar.UseVisualStyleBackColor = false;
            this.Bgravar.Click += new System.EventHandler(this.Bgravar_Click);
            this.Bgravar.MouseLeave += new System.EventHandler(this.Bgravar_MouseLeave);
            this.Bgravar.MouseHover += new System.EventHandler(this.Bgravar_MouseHover);
            // 
            // Bremover
            // 
            this.Bremover.BackColor = System.Drawing.Color.Goldenrod;
            this.Bremover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bremover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bremover.ForeColor = System.Drawing.Color.White;
            this.Bremover.Location = new System.Drawing.Point(185, 4);
            this.Bremover.Margin = new System.Windows.Forms.Padding(4);
            this.Bremover.Name = "Bremover";
            this.Bremover.Size = new System.Drawing.Size(160, 40);
            this.Bremover.TabIndex = 1;
            this.Bremover.Text = "Remover";
            this.Bremover.UseVisualStyleBackColor = false;
            this.Bremover.Click += new System.EventHandler(this.Bremover_Click);
            this.Bremover.MouseLeave += new System.EventHandler(this.Bremover_MouseLeave);
            this.Bremover.MouseHover += new System.EventHandler(this.Bremover_MouseHover);
            // 
            // Bcancelar
            // 
            this.Bcancelar.BackColor = System.Drawing.Color.Goldenrod;
            this.Bcancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bcancelar.Enabled = false;
            this.Bcancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bcancelar.ForeColor = System.Drawing.Color.White;
            this.Bcancelar.Location = new System.Drawing.Point(366, 4);
            this.Bcancelar.Margin = new System.Windows.Forms.Padding(4);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(162, 40);
            this.Bcancelar.TabIndex = 2;
            this.Bcancelar.Text = "Cancelar";
            this.Bcancelar.UseVisualStyleBackColor = false;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            this.Bcancelar.MouseLeave += new System.EventHandler(this.Bcancelar_MouseLeave);
            this.Bcancelar.MouseHover += new System.EventHandler(this.Bcancelar_MouseHover);
            // 
            // DTservico
            // 
            this.DTservico.AllowUserToAddRows = false;
            this.DTservico.AllowUserToDeleteRows = false;
            this.DTservico.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DTservico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DTservico, 2);
            this.DTservico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTservico.Location = new System.Drawing.Point(4, 233);
            this.DTservico.Margin = new System.Windows.Forms.Padding(4);
            this.DTservico.Name = "DTservico";
            this.DTservico.ReadOnly = true;
            this.DTservico.RowTemplate.Height = 25;
            this.DTservico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTservico.Size = new System.Drawing.Size(532, 254);
            this.DTservico.TabIndex = 5;
            this.DTservico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTservico_CellContentClick);
            this.DTservico.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTservico_RowEnter);
            // 
            // ServicoIAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ServicoIAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServicoIAR";
            this.Shown += new System.EventHandler(this.ServicoIAR_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTservico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LBnome;
        private System.Windows.Forms.Label LBpreco;
        private System.Windows.Forms.TextBox TBnome;
        private System.Windows.Forms.TextBox TBpreco;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Bgravar;
        private System.Windows.Forms.DataGridView DTservico;
        private System.Windows.Forms.Button Bremover;
        private System.Windows.Forms.Button Bcancelar;
    }
}