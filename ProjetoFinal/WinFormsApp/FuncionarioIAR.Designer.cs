
namespace WinFormsApp
{
    partial class FuncionarioIAR
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
            this.Lnome = new System.Windows.Forms.Label();
            this.Lsobrenome = new System.Windows.Forms.Label();
            this.TBnome = new System.Windows.Forms.TextBox();
            this.TBsobrenome = new System.Windows.Forms.TextBox();
            this.Lemail = new System.Windows.Forms.Label();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.Lturnos = new System.Windows.Forms.Label();
            this.TBturno = new System.Windows.Forms.TextBox();
            this.TBhistorico = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Bgravar = new System.Windows.Forms.Button();
            this.Bremover = new System.Windows.Forms.Button();
            this.Bcancelar = new System.Windows.Forms.Button();
            this.DTfuncionario = new System.Windows.Forms.DataGridView();
            this.Lhistorico = new System.Windows.Forms.Label();
            this.Lservico = new System.Windows.Forms.Label();
            this.CBservico = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTfuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.Lnome, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lsobrenome, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBnome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TBsobrenome, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Lemail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBemail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Lturnos, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TBturno, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.TBhistorico, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.DTfuncionario, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.Lhistorico, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Lservico, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.CBservico, 1, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 511);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Lnome
            // 
            this.Lnome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lnome.AutoSize = true;
            this.Lnome.Location = new System.Drawing.Point(3, 18);
            this.Lnome.Name = "Lnome";
            this.Lnome.Size = new System.Drawing.Size(56, 21);
            this.Lnome.TabIndex = 0;
            this.Lnome.Text = "Nome:";
            // 
            // Lsobrenome
            // 
            this.Lsobrenome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lsobrenome.AutoSize = true;
            this.Lsobrenome.Location = new System.Drawing.Point(246, 18);
            this.Lsobrenome.Name = "Lsobrenome";
            this.Lsobrenome.Size = new System.Drawing.Size(94, 21);
            this.Lsobrenome.TabIndex = 1;
            this.Lsobrenome.Text = "Sobrenome:";
            // 
            // TBnome
            // 
            this.TBnome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBnome.Location = new System.Drawing.Point(84, 14);
            this.TBnome.Name = "TBnome";
            this.TBnome.Size = new System.Drawing.Size(156, 29);
            this.TBnome.TabIndex = 2;
            // 
            // TBsobrenome
            // 
            this.TBsobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBsobrenome.Location = new System.Drawing.Point(354, 14);
            this.TBsobrenome.Name = "TBsobrenome";
            this.TBsobrenome.Size = new System.Drawing.Size(183, 29);
            this.TBsobrenome.TabIndex = 3;
            // 
            // Lemail
            // 
            this.Lemail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lemail.AutoSize = true;
            this.Lemail.Location = new System.Drawing.Point(3, 66);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(51, 21);
            this.Lemail.TabIndex = 4;
            this.Lemail.Text = "Email:";
            // 
            // TBemail
            // 
            this.TBemail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.TBemail, 3);
            this.TBemail.Location = new System.Drawing.Point(84, 63);
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(453, 29);
            this.TBemail.TabIndex = 5;
            // 
            // Lturnos
            // 
            this.Lturnos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lturnos.AutoSize = true;
            this.Lturnos.Location = new System.Drawing.Point(3, 116);
            this.Lturnos.Name = "Lturnos";
            this.Lturnos.Size = new System.Drawing.Size(71, 21);
            this.Lturnos.TabIndex = 6;
            this.Lturnos.Text = "Turno(s):";
            // 
            // TBturno
            // 
            this.TBturno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.TBturno, 3);
            this.TBturno.Location = new System.Drawing.Point(84, 112);
            this.TBturno.Name = "TBturno";
            this.TBturno.Size = new System.Drawing.Size(453, 29);
            this.TBturno.TabIndex = 7;
            // 
            // TBhistorico
            // 
            this.TBhistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.TBhistorico, 3);
            this.TBhistorico.Location = new System.Drawing.Point(84, 159);
            this.TBhistorico.Multiline = true;
            this.TBhistorico.Name = "TBhistorico";
            this.TBhistorico.Size = new System.Drawing.Size(453, 77);
            this.TBhistorico.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.Bgravar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Bremover, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Bcancelar, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 297);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 41);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // Bgravar
            // 
            this.Bgravar.BackColor = System.Drawing.Color.Goldenrod;
            this.Bgravar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bgravar.ForeColor = System.Drawing.Color.White;
            this.Bgravar.Location = new System.Drawing.Point(3, 3);
            this.Bgravar.Name = "Bgravar";
            this.Bgravar.Size = new System.Drawing.Size(163, 35);
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
            this.Bremover.Enabled = false;
            this.Bremover.ForeColor = System.Drawing.Color.White;
            this.Bremover.Location = new System.Drawing.Point(185, 3);
            this.Bremover.Name = "Bremover";
            this.Bremover.Size = new System.Drawing.Size(163, 35);
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
            this.Bcancelar.ForeColor = System.Drawing.Color.White;
            this.Bcancelar.Location = new System.Drawing.Point(367, 3);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(164, 35);
            this.Bcancelar.TabIndex = 2;
            this.Bcancelar.Text = "Cancelar";
            this.Bcancelar.UseVisualStyleBackColor = false;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            this.Bcancelar.MouseLeave += new System.EventHandler(this.Bcancelar_MouseLeave);
            this.Bcancelar.MouseHover += new System.EventHandler(this.Bcancelar_MouseHover);
            // 
            // DTfuncionario
            // 
            this.DTfuncionario.AllowUserToAddRows = false;
            this.DTfuncionario.AllowUserToDeleteRows = false;
            this.DTfuncionario.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DTfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DTfuncionario, 4);
            this.DTfuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTfuncionario.Location = new System.Drawing.Point(3, 344);
            this.DTfuncionario.Name = "DTfuncionario";
            this.DTfuncionario.ReadOnly = true;
            this.DTfuncionario.RowTemplate.Height = 25;
            this.DTfuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTfuncionario.Size = new System.Drawing.Size(534, 164);
            this.DTfuncionario.TabIndex = 11;
            this.DTfuncionario.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTfuncionario_RowEnter);
            // 
            // Lhistorico
            // 
            this.Lhistorico.AutoSize = true;
            this.Lhistorico.Location = new System.Drawing.Point(3, 156);
            this.Lhistorico.Name = "Lhistorico";
            this.Lhistorico.Size = new System.Drawing.Size(75, 21);
            this.Lhistorico.TabIndex = 8;
            this.Lhistorico.Text = "Histórico:";
            // 
            // Lservico
            // 
            this.Lservico.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lservico.AutoSize = true;
            this.Lservico.Location = new System.Drawing.Point(3, 257);
            this.Lservico.Name = "Lservico";
            this.Lservico.Size = new System.Drawing.Size(64, 21);
            this.Lservico.TabIndex = 12;
            this.Lservico.Text = "Serviço:";
            // 
            // CBservico
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CBservico, 3);
            this.CBservico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBservico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBservico.FormattingEnabled = true;
            this.CBservico.Location = new System.Drawing.Point(84, 252);
            this.CBservico.Name = "CBservico";
            this.CBservico.Size = new System.Drawing.Size(453, 29);
            this.CBservico.TabIndex = 13;
            // 
            // FuncionarioIAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FuncionarioIAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuncionarioIAR";
            this.Shown += new System.EventHandler(this.FuncionarioIAR_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTfuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lnome;
        private System.Windows.Forms.Label Lsobrenome;
        private System.Windows.Forms.TextBox TBnome;
        private System.Windows.Forms.TextBox TBsobrenome;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.TextBox TBemail;
        private System.Windows.Forms.Label Lturnos;
        private System.Windows.Forms.TextBox TBturno;
        private System.Windows.Forms.Label Lhistorico;
        private System.Windows.Forms.TextBox TBhistorico;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button Bgravar;
        private System.Windows.Forms.DataGridView DTfuncionario;
        private System.Windows.Forms.Button Bremover;
        private System.Windows.Forms.Button Bcancelar;
        private System.Windows.Forms.Label Lservico;
        private System.Windows.Forms.ComboBox CBservico;
    }
}