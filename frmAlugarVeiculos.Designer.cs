namespace SistemaLocacaoVeiculo
{
    partial class frmAlugarVeiculos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlugarVeiculos));
            this.lbl_titulo_Principal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_NomeClienteLocacao = new System.Windows.Forms.TextBox();
            this.txt_EnderecoLocacao = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_MarcaLocacao = new System.Windows.Forms.TextBox();
            this.txt_ModeloLocacao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_PlacaLocacao = new System.Windows.Forms.TextBox();
            this.txt_AnoLocacao = new System.Windows.Forms.TextBox();
            this.txt_CorLocacao = new System.Windows.Forms.TextBox();
            this.txt_CategoriaLocaca = new System.Windows.Forms.TextBox();
            this.txt_DiariaLocacao = new System.Windows.Forms.TextBox();
            this.txt_TotalLocacao = new System.Windows.Forms.TextBox();
            this.numeric_Alugar_Veiculos = new System.Windows.Forms.NumericUpDown();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_Data_Entrega = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_AbrirF_Valugados = new Guna.UI2.WinForms.Guna2Button();
            this.btn_abrir_tela_veiculosCadastrados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Alugar_Veiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo_Principal
            // 
            this.lbl_titulo_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lbl_titulo_Principal.Font = new System.Drawing.Font("Roboto Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo_Principal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_titulo_Principal.Location = new System.Drawing.Point(5, 4);
            this.lbl_titulo_Principal.Name = "lbl_titulo_Principal";
            this.lbl_titulo_Principal.Size = new System.Drawing.Size(526, 36);
            this.lbl_titulo_Principal.TabIndex = 1;
            this.lbl_titulo_Principal.Text = "Locadora De Veiculos - Two Brothers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(7, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(7, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Placa:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(655, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data Entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(655, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "N° Dias:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(9, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "Categoria:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(395, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Diaria R$:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(395, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Cor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(655, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Total R$:";
            // 
            // txt_NomeClienteLocacao
            // 
            this.txt_NomeClienteLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_NomeClienteLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_NomeClienteLocacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_NomeClienteLocacao.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NomeClienteLocacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_NomeClienteLocacao.Location = new System.Drawing.Point(116, 86);
            this.txt_NomeClienteLocacao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txt_NomeClienteLocacao.Name = "txt_NomeClienteLocacao";
            this.txt_NomeClienteLocacao.Size = new System.Drawing.Size(244, 27);
            this.txt_NomeClienteLocacao.TabIndex = 0;
            this.txt_NomeClienteLocacao.Tag = "Letras";
            this.txt_NomeClienteLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_EnderecoLocacao
            // 
            this.txt_EnderecoLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_EnderecoLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_EnderecoLocacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_EnderecoLocacao.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EnderecoLocacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_EnderecoLocacao.Location = new System.Drawing.Point(116, 143);
            this.txt_EnderecoLocacao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txt_EnderecoLocacao.Name = "txt_EnderecoLocacao";
            this.txt_EnderecoLocacao.Size = new System.Drawing.Size(244, 27);
            this.txt_EnderecoLocacao.TabIndex = 1;
            this.txt_EnderecoLocacao.Tag = "Letras";
            this.txt_EnderecoLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(7, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 19);
            this.label15.TabIndex = 2;
            this.label15.Text = "Marca:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(395, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 19);
            this.label16.TabIndex = 2;
            this.label16.Text = "Modelo:";
            // 
            // txt_MarcaLocacao
            // 
            this.txt_MarcaLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_MarcaLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MarcaLocacao.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MarcaLocacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_MarcaLocacao.Location = new System.Drawing.Point(116, 196);
            this.txt_MarcaLocacao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txt_MarcaLocacao.Name = "txt_MarcaLocacao";
            this.txt_MarcaLocacao.Size = new System.Drawing.Size(244, 27);
            this.txt_MarcaLocacao.TabIndex = 10;
            this.txt_MarcaLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ModeloLocacao
            // 
            this.txt_ModeloLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_ModeloLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ModeloLocacao.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModeloLocacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_ModeloLocacao.Location = new System.Drawing.Point(481, 196);
            this.txt_ModeloLocacao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txt_ModeloLocacao.Name = "txt_ModeloLocacao";
            this.txt_ModeloLocacao.Size = new System.Drawing.Size(111, 27);
            this.txt_ModeloLocacao.TabIndex = 3;
            this.txt_ModeloLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.DarkGray;
            this.label17.Location = new System.Drawing.Point(395, 90);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 19);
            this.label17.TabIndex = 2;
            this.label17.Text = "Ano:";
            // 
            // txt_PlacaLocacao
            // 
            this.txt_PlacaLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_PlacaLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PlacaLocacao.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PlacaLocacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_PlacaLocacao.Location = new System.Drawing.Point(116, 295);
            this.txt_PlacaLocacao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txt_PlacaLocacao.Name = "txt_PlacaLocacao";
            this.txt_PlacaLocacao.Size = new System.Drawing.Size(244, 27);
            this.txt_PlacaLocacao.TabIndex = 4;
            this.txt_PlacaLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_AnoLocacao
            // 
            this.txt_AnoLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_AnoLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_AnoLocacao.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AnoLocacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_AnoLocacao.Location = new System.Drawing.Point(481, 86);
            this.txt_AnoLocacao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txt_AnoLocacao.Name = "txt_AnoLocacao";
            this.txt_AnoLocacao.Size = new System.Drawing.Size(111, 27);
            this.txt_AnoLocacao.TabIndex = 5;
            this.txt_AnoLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_CorLocacao
            // 
            this.txt_CorLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_CorLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CorLocacao.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CorLocacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_CorLocacao.Location = new System.Drawing.Point(481, 143);
            this.txt_CorLocacao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txt_CorLocacao.Name = "txt_CorLocacao";
            this.txt_CorLocacao.Size = new System.Drawing.Size(111, 27);
            this.txt_CorLocacao.TabIndex = 6;
            this.txt_CorLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_CategoriaLocaca
            // 
            this.txt_CategoriaLocaca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_CategoriaLocaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CategoriaLocaca.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CategoriaLocaca.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_CategoriaLocaca.Location = new System.Drawing.Point(116, 247);
            this.txt_CategoriaLocaca.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txt_CategoriaLocaca.Name = "txt_CategoriaLocaca";
            this.txt_CategoriaLocaca.Size = new System.Drawing.Size(244, 27);
            this.txt_CategoriaLocaca.TabIndex = 7;
            this.txt_CategoriaLocaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_DiariaLocacao
            // 
            this.txt_DiariaLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_DiariaLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DiariaLocacao.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiariaLocacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_DiariaLocacao.Location = new System.Drawing.Point(481, 247);
            this.txt_DiariaLocacao.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.txt_DiariaLocacao.Name = "txt_DiariaLocacao";
            this.txt_DiariaLocacao.Size = new System.Drawing.Size(111, 27);
            this.txt_DiariaLocacao.TabIndex = 8;
            this.txt_DiariaLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalLocacao
            // 
            this.txt_TotalLocacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txt_TotalLocacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TotalLocacao.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalLocacao.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_TotalLocacao.Location = new System.Drawing.Point(766, 143);
            this.txt_TotalLocacao.Name = "txt_TotalLocacao";
            this.txt_TotalLocacao.Size = new System.Drawing.Size(121, 27);
            this.txt_TotalLocacao.TabIndex = 2;
            this.txt_TotalLocacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numeric_Alugar_Veiculos
            // 
            this.numeric_Alugar_Veiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.numeric_Alugar_Veiculos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_Alugar_Veiculos.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_Alugar_Veiculos.ForeColor = System.Drawing.SystemColors.Window;
            this.numeric_Alugar_Veiculos.Location = new System.Drawing.Point(766, 86);
            this.numeric_Alugar_Veiculos.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numeric_Alugar_Veiculos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Alugar_Veiculos.Name = "numeric_Alugar_Veiculos";
            this.numeric_Alugar_Veiculos.Size = new System.Drawing.Size(61, 27);
            this.numeric_Alugar_Veiculos.TabIndex = 9;
            this.numeric_Alugar_Veiculos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_Alugar_Veiculos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_Alugar_Veiculos.ValueChanged += new System.EventHandler(this.numeric_Alugar_Veiculos_ValueChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox1.IconColor = System.Drawing.SystemColors.Window;
            this.guna2ControlBox1.Location = new System.Drawing.Point(874, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(38, 21);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2ControlBox2.IconColor = System.Drawing.SystemColors.Window;
            this.guna2ControlBox2.Location = new System.Drawing.Point(835, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(38, 21);
            this.guna2ControlBox2.TabIndex = 8;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_Data_Entrega
            // 
            this.txt_Data_Entrega.AutoSize = false;
            this.txt_Data_Entrega.BackColor = System.Drawing.Color.Transparent;
            this.txt_Data_Entrega.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Data_Entrega.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Data_Entrega.ForeColor = System.Drawing.Color.DarkGray;
            this.txt_Data_Entrega.Location = new System.Drawing.Point(766, 196);
            this.txt_Data_Entrega.Name = "txt_Data_Entrega";
            this.txt_Data_Entrega.Size = new System.Drawing.Size(121, 27);
            this.txt_Data_Entrega.TabIndex = 12;
            this.txt_Data_Entrega.Text = null;
            this.txt_Data_Entrega.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(896, 5);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.toolTip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(100)))), ((int)(((byte)(247)))));
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "LD System";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button1.BorderRadius = 6;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button1.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.Image = global::SistemaLocacaoVeiculo.Properties.Resources.formone_32;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 2);
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(296, 439);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(147, 60);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "    Alugar";
            this.toolTip1.SetToolTip(this.guna2Button1, "Aluga um Veiculo ");
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btn_AbrirF_Valugados
            // 
            this.btn_AbrirF_Valugados.Animated = true;
            this.btn_AbrirF_Valugados.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_AbrirF_Valugados.BorderRadius = 5;
            this.btn_AbrirF_Valugados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AbrirF_Valugados.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_AbrirF_Valugados.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_AbrirF_Valugados.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_AbrirF_Valugados.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_AbrirF_Valugados.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.btn_AbrirF_Valugados.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AbrirF_Valugados.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_AbrirF_Valugados.Image = global::SistemaLocacaoVeiculo.Properties.Resources.formetree_32;
            this.btn_AbrirF_Valugados.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_AbrirF_Valugados.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_AbrirF_Valugados.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_AbrirF_Valugados.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_AbrirF_Valugados.IndicateFocus = true;
            this.btn_AbrirF_Valugados.Location = new System.Drawing.Point(143, 439);
            this.btn_AbrirF_Valugados.Name = "btn_AbrirF_Valugados";
            this.btn_AbrirF_Valugados.Size = new System.Drawing.Size(147, 60);
            this.btn_AbrirF_Valugados.TabIndex = 11;
            this.btn_AbrirF_Valugados.Text = "      Alugados";
            this.toolTip1.SetToolTip(this.btn_AbrirF_Valugados, "Visualizar Veiculos Alugados\r\n\r\n");
            this.btn_AbrirF_Valugados.Click += new System.EventHandler(this.btn_AbrirF_Valugados_Click);
            // 
            // btn_abrir_tela_veiculosCadastrados
            // 
            this.btn_abrir_tela_veiculosCadastrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.btn_abrir_tela_veiculosCadastrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_abrir_tela_veiculosCadastrados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_abrir_tela_veiculosCadastrados.Font = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_abrir_tela_veiculosCadastrados.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_abrir_tela_veiculosCadastrados.Image = global::SistemaLocacaoVeiculo.Properties.Resources.search;
            this.btn_abrir_tela_veiculosCadastrados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_abrir_tela_veiculosCadastrados.Location = new System.Drawing.Point(12, 439);
            this.btn_abrir_tela_veiculosCadastrados.Name = "btn_abrir_tela_veiculosCadastrados";
            this.btn_abrir_tela_veiculosCadastrados.Size = new System.Drawing.Size(125, 60);
            this.btn_abrir_tela_veiculosCadastrados.TabIndex = 6;
            this.btn_abrir_tela_veiculosCadastrados.Text = "     Search";
            this.toolTip1.SetToolTip(this.btn_abrir_tela_veiculosCadastrados, "Pesquisar um Veiculo");
            this.btn_abrir_tela_veiculosCadastrados.UseVisualStyleBackColor = false;
            this.btn_abrir_tela_veiculosCadastrados.Click += new System.EventHandler(this.btn_abrir_tela_veiculosCadastrados_Click);
            // 
            // frmAlugarVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(914, 511);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btn_AbrirF_Valugados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Data_Entrega);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btn_abrir_tela_veiculosCadastrados);
            this.Controls.Add(this.numeric_Alugar_Veiculos);
            this.Controls.Add(this.txt_EnderecoLocacao);
            this.Controls.Add(this.txt_NomeClienteLocacao);
            this.Controls.Add(this.txt_TotalLocacao);
            this.Controls.Add(this.txt_DiariaLocacao);
            this.Controls.Add(this.txt_CategoriaLocaca);
            this.Controls.Add(this.txt_CorLocacao);
            this.Controls.Add(this.txt_AnoLocacao);
            this.Controls.Add(this.txt_PlacaLocacao);
            this.Controls.Add(this.txt_ModeloLocacao);
            this.Controls.Add(this.txt_MarcaLocacao);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_titulo_Principal);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmAlugarVeiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "....";
            this.Load += new System.EventHandler(this.frmCadVeiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_Alugar_Veiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo_Principal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_NomeClienteLocacao;
        private System.Windows.Forms.TextBox txt_EnderecoLocacao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.NumericUpDown numeric_Alugar_Veiculos;
        private System.Windows.Forms.Button btn_abrir_tela_veiculosCadastrados;
        public System.Windows.Forms.TextBox txt_MarcaLocacao;
        public System.Windows.Forms.TextBox txt_ModeloLocacao;
        public System.Windows.Forms.TextBox txt_PlacaLocacao;
        public System.Windows.Forms.TextBox txt_AnoLocacao;
        public System.Windows.Forms.TextBox txt_CorLocacao;
        public System.Windows.Forms.TextBox txt_CategoriaLocaca;
        public System.Windows.Forms.TextBox txt_DiariaLocacao;
        public System.Windows.Forms.TextBox txt_TotalLocacao;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2HtmlLabel txt_Data_Entrega;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_AbrirF_Valugados;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

