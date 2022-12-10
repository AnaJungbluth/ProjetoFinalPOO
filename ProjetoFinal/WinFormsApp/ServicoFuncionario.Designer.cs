
namespace WinFormsApp
{
    partial class ServicoFuncionario
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
            this.TBturno = new System.Windows.Forms.TextBox();
            this.Lturnos = new System.Windows.Forms.Label();
            this.TBhistorico = new System.Windows.Forms.TextBox();
            this.Lhistorico = new System.Windows.Forms.Label();
            this.TBsobrenome = new System.Windows.Forms.TextBox();
            this.TBnome = new System.Windows.Forms.TextBox();
            this.Lsobrenome = new System.Windows.Forms.Label();
            this.Lnome = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Bcontratar = new System.Windows.Forms.Button();
            this.Bcancelar = new System.Windows.Forms.Button();
            this.DTfuncionarios = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTfuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // TBturno
            // 
            this.TBturno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.TBturno, 3);
            this.TBturno.Location = new System.Drawing.Point(84, 65);
            this.TBturno.Name = "TBturno";
            this.TBturno.ReadOnly = true;
            this.TBturno.Size = new System.Drawing.Size(453, 29);
            this.TBturno.TabIndex = 7;
            // 
            // Lturnos
            // 
            this.Lturnos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lturnos.AutoSize = true;
            this.Lturnos.Location = new System.Drawing.Point(3, 69);
            this.Lturnos.Name = "Lturnos";
            this.Lturnos.Size = new System.Drawing.Size(71, 21);
            this.Lturnos.TabIndex = 6;
            this.Lturnos.Text = "Turno(s):";
            // 
            // TBhistorico
            // 
            this.TBhistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.TBhistorico, 3);
            this.TBhistorico.Location = new System.Drawing.Point(84, 113);
            this.TBhistorico.Multiline = true;
            this.TBhistorico.Name = "TBhistorico";
            this.TBhistorico.ReadOnly = true;
            this.TBhistorico.Size = new System.Drawing.Size(453, 94);
            this.TBhistorico.TabIndex = 9;
            // 
            // Lhistorico
            // 
            this.Lhistorico.AutoSize = true;
            this.Lhistorico.Location = new System.Drawing.Point(3, 110);
            this.Lhistorico.Name = "Lhistorico";
            this.Lhistorico.Size = new System.Drawing.Size(75, 21);
            this.Lhistorico.TabIndex = 8;
            this.Lhistorico.Text = "Histórico:";
            // 
            // TBsobrenome
            // 
            this.TBsobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBsobrenome.Location = new System.Drawing.Point(354, 15);
            this.TBsobrenome.Name = "TBsobrenome";
            this.TBsobrenome.ReadOnly = true;
            this.TBsobrenome.Size = new System.Drawing.Size(183, 29);
            this.TBsobrenome.TabIndex = 3;
            // 
            // TBnome
            // 
            this.TBnome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBnome.Location = new System.Drawing.Point(84, 15);
            this.TBnome.Name = "TBnome";
            this.TBnome.ReadOnly = true;
            this.TBnome.Size = new System.Drawing.Size(156, 29);
            this.TBnome.TabIndex = 2;
            // 
            // Lsobrenome
            // 
            this.Lsobrenome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lsobrenome.AutoSize = true;
            this.Lsobrenome.Location = new System.Drawing.Point(246, 19);
            this.Lsobrenome.Name = "Lsobrenome";
            this.Lsobrenome.Size = new System.Drawing.Size(94, 21);
            this.Lsobrenome.TabIndex = 1;
            this.Lsobrenome.Text = "Sobrenome:";
            // 
            // Lnome
            // 
            this.Lnome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lnome.AutoSize = true;
            this.Lnome.Location = new System.Drawing.Point(3, 19);
            this.Lnome.Name = "Lnome";
            this.Lnome.Size = new System.Drawing.Size(56, 21);
            this.Lnome.TabIndex = 0;
            this.Lnome.Text = "Nome:";
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
            this.tableLayoutPanel1.Controls.Add(this.Lhistorico, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.TBhistorico, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Lturnos, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.TBturno, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.DTfuncionarios, 0, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(540, 511);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 4);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Bcontratar, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Bcancelar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 223);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(534, 44);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // Bcontratar
            // 
            this.Bcontratar.BackColor = System.Drawing.Color.Goldenrod;
            this.Bcontratar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bcontratar.ForeColor = System.Drawing.Color.White;
            this.Bcontratar.Location = new System.Drawing.Point(3, 3);
            this.Bcontratar.Name = "Bcontratar";
            this.Bcontratar.Size = new System.Drawing.Size(256, 38);
            this.Bcontratar.TabIndex = 0;
            this.Bcontratar.Text = "Contratar";
            this.Bcontratar.UseVisualStyleBackColor = false;
            this.Bcontratar.Click += new System.EventHandler(this.Bcontratar_Click);
            // 
            // Bcancelar
            // 
            this.Bcancelar.BackColor = System.Drawing.Color.Goldenrod;
            this.Bcancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bcancelar.ForeColor = System.Drawing.Color.White;
            this.Bcancelar.Location = new System.Drawing.Point(275, 3);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(256, 38);
            this.Bcancelar.TabIndex = 1;
            this.Bcancelar.Text = "Cancelar";
            this.Bcancelar.UseVisualStyleBackColor = false;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            // 
            // DTfuncionarios
            // 
            this.DTfuncionarios.AllowUserToAddRows = false;
            this.DTfuncionarios.AllowUserToDeleteRows = false;
            this.DTfuncionarios.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.DTfuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.DTfuncionarios, 4);
            this.DTfuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTfuncionarios.Location = new System.Drawing.Point(3, 283);
            this.DTfuncionarios.Name = "DTfuncionarios";
            this.DTfuncionarios.ReadOnly = true;
            this.DTfuncionarios.RowTemplate.Height = 25;
            this.DTfuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTfuncionarios.Size = new System.Drawing.Size(534, 214);
            this.DTfuncionarios.TabIndex = 11;
            this.DTfuncionarios.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTfuncionarios_RowEnter);
            // 
            // ServicoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(540, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ServicoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServicoFuncionario";
            this.Shown += new System.EventHandler(this.ServicoFuncionario_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTfuncionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TBturno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Lnome;
        private System.Windows.Forms.Label Lsobrenome;
        private System.Windows.Forms.TextBox TBnome;
        private System.Windows.Forms.TextBox TBsobrenome;
        private System.Windows.Forms.Label Lhistorico;
        private System.Windows.Forms.TextBox TBhistorico;
        private System.Windows.Forms.Label Lturnos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView DTfuncionarios;
        private System.Windows.Forms.Button Bcontratar;
        private System.Windows.Forms.Button Bcancelar;
    }
}