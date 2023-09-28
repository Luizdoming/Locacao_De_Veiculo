namespace SistemaLocacaoVeiculo
{
    partial class frm_Veiculos_Cadastrados
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Veiculos_Cadastrados));
            this.list_veiculosCadastrados = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Categoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Diaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_totalVeiculos_Cadastrados = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // list_veiculosCadastrados
            // 
            this.list_veiculosCadastrados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.list_veiculosCadastrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.list_veiculosCadastrados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list_veiculosCadastrados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Fabricante,
            this.Modelo,
            this.Categoria,
            this.Placa,
            this.Cor,
            this.Ano,
            this.Diaria});
            this.list_veiculosCadastrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.list_veiculosCadastrados.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_veiculosCadastrados.ForeColor = System.Drawing.Color.DarkGray;
            this.list_veiculosCadastrados.FullRowSelect = true;
            this.list_veiculosCadastrados.GridLines = true;
            this.list_veiculosCadastrados.HideSelection = false;
            this.list_veiculosCadastrados.LabelEdit = true;
            this.list_veiculosCadastrados.Location = new System.Drawing.Point(13, 117);
            this.list_veiculosCadastrados.MultiSelect = false;
            this.list_veiculosCadastrados.Name = "list_veiculosCadastrados";
            this.list_veiculosCadastrados.ShowItemToolTips = true;
            this.list_veiculosCadastrados.Size = new System.Drawing.Size(842, 414);
            this.list_veiculosCadastrados.TabIndex = 0;
            this.list_veiculosCadastrados.UseCompatibleStateImageBehavior = false;
            this.list_veiculosCadastrados.View = System.Windows.Forms.View.Details;
            this.list_veiculosCadastrados.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.list_veiculosCadastrados_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 9;
            // 
            // Fabricante
            // 
            this.Fabricante.Text = "Fabricante";
            this.Fabricante.Width = 195;
            // 
            // Modelo
            // 
            this.Modelo.Text = "Modelo";
            this.Modelo.Width = 100;
            // 
            // Categoria
            // 
            this.Categoria.Text = "Categoria";
            this.Categoria.Width = 130;
            // 
            // Placa
            // 
            this.Placa.Text = "Placa";
            this.Placa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Placa.Width = 115;
            // 
            // Cor
            // 
            this.Cor.Text = "Cor";
            this.Cor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cor.Width = 90;
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            this.Ano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ano.Width = 90;
            // 
            // Diaria
            // 
            this.Diaria.Text = "Diaria";
            this.Diaria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Diaria.Width = 103;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Veiculos Cadastrados";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox1.IconColor = System.Drawing.SystemColors.Window;
            this.guna2ControlBox1.Location = new System.Drawing.Point(823, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_totalVeiculos_Cadastrados
            // 
            this.txt_totalVeiculos_Cadastrados.BorderRadius = 10;
            this.txt_totalVeiculos_Cadastrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_totalVeiculos_Cadastrados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.txt_totalVeiculos_Cadastrados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.txt_totalVeiculos_Cadastrados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txt_totalVeiculos_Cadastrados.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.txt_totalVeiculos_Cadastrados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.txt_totalVeiculos_Cadastrados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_totalVeiculos_Cadastrados.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_totalVeiculos_Cadastrados.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalVeiculos_Cadastrados.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_totalVeiculos_Cadastrados.Location = new System.Drawing.Point(343, 9);
            this.txt_totalVeiculos_Cadastrados.Name = "txt_totalVeiculos_Cadastrados";
            this.txt_totalVeiculos_Cadastrados.Size = new System.Drawing.Size(476, 36);
            this.txt_totalVeiculos_Cadastrados.TabIndex = 3;
            this.txt_totalVeiculos_Cadastrados.Text = "0";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(844, 5);
            this.label2.TabIndex = 4;
            // 
            // frm_Veiculos_Cadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(870, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_totalVeiculos_Cadastrados);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_veiculosCadastrados);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frm_Veiculos_Cadastrados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Veiculos_Cadastrados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list_veiculosCadastrados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader Fabricante;
        private System.Windows.Forms.ColumnHeader Modelo;
        private System.Windows.Forms.ColumnHeader Categoria;
        private System.Windows.Forms.ColumnHeader Placa;
        private System.Windows.Forms.ColumnHeader Cor;
        private System.Windows.Forms.ColumnHeader Ano;
        private System.Windows.Forms.ColumnHeader Diaria;
        private System.Windows.Forms.ColumnHeader ID;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GradientButton txt_totalVeiculos_Cadastrados;
        private System.Windows.Forms.Label label2;
    }
}