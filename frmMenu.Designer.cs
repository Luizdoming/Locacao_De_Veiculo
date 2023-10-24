namespace SistemaLocacaoVeiculo
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.btn_veiculos_alugados = new System.Windows.Forms.Button();
            this.btn_veiculos_AlugarVeiculos = new System.Windows.Forms.Button();
            this.btn_Tela_Cadastrar = new System.Windows.Forms.Button();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2CircleProgressBar2 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.guna2CircleProgressBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_veiculos_alugados
            // 
            this.btn_veiculos_alugados.BackColor = System.Drawing.SystemColors.Window;
            this.btn_veiculos_alugados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_veiculos_alugados.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veiculos_alugados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_veiculos_alugados.Location = new System.Drawing.Point(852, 198);
            this.btn_veiculos_alugados.Name = "btn_veiculos_alugados";
            this.btn_veiculos_alugados.Size = new System.Drawing.Size(57, 33);
            this.btn_veiculos_alugados.TabIndex = 0;
            this.btn_veiculos_alugados.Text = "Veiculos Alugados";
            this.toolTip1.SetToolTip(this.btn_veiculos_alugados, "Exibir a tela de Veiculos alugados.\r\n\r\n");
            this.btn_veiculos_alugados.UseVisualStyleBackColor = false;
            this.btn_veiculos_alugados.Click += new System.EventHandler(this.btn_veiculos_alugados_Click);
            // 
            // btn_veiculos_AlugarVeiculos
            // 
            this.btn_veiculos_AlugarVeiculos.BackColor = System.Drawing.SystemColors.Window;
            this.btn_veiculos_AlugarVeiculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_veiculos_AlugarVeiculos.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veiculos_AlugarVeiculos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_veiculos_AlugarVeiculos.Location = new System.Drawing.Point(852, 164);
            this.btn_veiculos_AlugarVeiculos.Name = "btn_veiculos_AlugarVeiculos";
            this.btn_veiculos_AlugarVeiculos.Size = new System.Drawing.Size(57, 28);
            this.btn_veiculos_AlugarVeiculos.TabIndex = 0;
            this.btn_veiculos_AlugarVeiculos.Text = "Alugar Veiculos";
            this.toolTip1.SetToolTip(this.btn_veiculos_AlugarVeiculos, "Exibir a tela para alugar veiculos.\r\n");
            this.btn_veiculos_AlugarVeiculos.UseVisualStyleBackColor = false;
            this.btn_veiculos_AlugarVeiculos.Click += new System.EventHandler(this.btn_veiculos_AlugarVeiculos_Click);
            // 
            // btn_Tela_Cadastrar
            // 
            this.btn_Tela_Cadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(99)))), ((int)(((byte)(247)))));
            this.btn_Tela_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tela_Cadastrar.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tela_Cadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Tela_Cadastrar.Location = new System.Drawing.Point(852, 131);
            this.btn_Tela_Cadastrar.Name = "btn_Tela_Cadastrar";
            this.btn_Tela_Cadastrar.Size = new System.Drawing.Size(57, 27);
            this.btn_Tela_Cadastrar.TabIndex = 0;
            this.btn_Tela_Cadastrar.Text = "Cadastrar Veiculos";
            this.toolTip1.SetToolTip(this.btn_Tela_Cadastrar, "Exibir a tela para cadastrar os veiculos.\r\n");
            this.btn_Tela_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Tela_Cadastrar.Click += new System.EventHandler(this.btn_Tela_Cadastrar_Click);
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_hora.Font = new System.Drawing.Font("Roboto", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_hora.Location = new System.Drawing.Point(739, 456);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(167, 46);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "----";
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer_menu
            // 
            this.timer_menu.Enabled = true;
            this.timer_menu.Tick += new System.EventHandler(this.timer_menu_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "LD System";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2Button6);
            this.guna2Panel1.Controls.Add(this.guna2Button5);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(228, 511);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = global::SistemaLocacaoVeiculo.Properties.Resources.luiz;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(57, 350);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(114, 113);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 6;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Button6
            // 
            this.guna2Button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button6.BorderRadius = 6;
            this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = global::SistemaLocacaoVeiculo.Properties.Resources.icons8_linkedin_48;
            this.guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button6.ImageOffset = new System.Drawing.Point(-10, 0);
            this.guna2Button6.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2Button6.Location = new System.Drawing.Point(68, 473);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.guna2Button6.Size = new System.Drawing.Size(41, 35);
            this.guna2Button6.TabIndex = 6;
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button5.BorderRadius = 6;
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::SistemaLocacaoVeiculo.Properties.Resources.icons8_instagram_48;
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageOffset = new System.Drawing.Point(-10, 0);
            this.guna2Button5.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2Button5.Location = new System.Drawing.Point(115, 473);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.guna2Button5.Size = new System.Drawing.Size(41, 35);
            this.guna2Button5.TabIndex = 6;
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Button1.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::SistemaLocacaoVeiculo.Properties.Resources.icons8_Handshake_Heart;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(2, 7);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.guna2Button1.ShadowDecoration.BorderRadius = 10;
            this.guna2Button1.Size = new System.Drawing.Size(224, 46);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "    Alugar Veiculos";
            this.guna2Button1.Click += new System.EventHandler(this.btn_veiculos_AlugarVeiculos_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button4.Animated = true;
            this.guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.guna2Button4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button4.BorderThickness = 1;
            this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button4.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Button4.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button4.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::SistemaLocacaoVeiculo.Properties.Resources.icons8_Checkmark;
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button4.Location = new System.Drawing.Point(2, 139);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.guna2Button4.ShadowDecoration.BorderRadius = 10;
            this.guna2Button4.Size = new System.Drawing.Size(224, 46);
            this.guna2Button4.TabIndex = 2;
            this.guna2Button4.Text = "     Cadastrar Veiculos";
            this.guna2Button4.Click += new System.EventHandler(this.btn_Tela_Cadastrar_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.Animated = true;
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.guna2Button2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button2.BorderThickness = 1;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.guna2Button2.CustomImages.ImageSize = new System.Drawing.Size(15, 15);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2Button2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::SistemaLocacaoVeiculo.Properties.Resources.icons8_Car_Rental;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(2, 73);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(80)))), ((int)(((byte)(247)))));
            this.guna2Button2.ShadowDecoration.BorderRadius = 10;
            this.guna2Button2.Size = new System.Drawing.Size(224, 46);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "     Veiculos Alugados";
            this.guna2Button2.Click += new System.EventHandler(this.btn_veiculos_alugados_Click);
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.AnimationSpeed = 0.2F;
            this.guna2CircleProgressBar1.Controls.Add(this.guna2CircleProgressBar2);
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CircleProgressBar1.FillThickness = 25;
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(492, 36);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(90)))), ((int)(((byte)(247)))));
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(90)))), ((int)(((byte)(247)))));
            this.guna2CircleProgressBar1.ProgressThickness = 25;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShowText = true;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(417, 417);
            this.guna2CircleProgressBar1.TabIndex = 5;
            this.guna2CircleProgressBar1.Text = "System Developement Luiz domingo";
            this.guna2CircleProgressBar1.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.guna2CircleProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2CircleProgressBar1.Value = 75;
            // 
            // guna2CircleProgressBar2
            // 
            this.guna2CircleProgressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CircleProgressBar2.Animated = true;
            this.guna2CircleProgressBar2.AutoScroll = true;
            this.guna2CircleProgressBar2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2CircleProgressBar2.FillThickness = 25;
            this.guna2CircleProgressBar2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar2.Location = new System.Drawing.Point(108, 111);
            this.guna2CircleProgressBar2.Minimum = 0;
            this.guna2CircleProgressBar2.Name = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2CircleProgressBar2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.guna2CircleProgressBar2.ProgressThickness = 25;
            this.guna2CircleProgressBar2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar2.Size = new System.Drawing.Size(194, 194);
            this.guna2CircleProgressBar2.TabIndex = 6;
            this.guna2CircleProgressBar2.Text = "guna2CircleProgressBar2";
            this.guna2CircleProgressBar2.Value = 50;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(914, 511);
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Controls.Add(this.btn_veiculos_alugados);
            this.Controls.Add(this.btn_Tela_Cadastrar);
            this.Controls.Add(this.btn_veiculos_AlugarVeiculos);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.lbl_hora);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "      ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.guna2CircleProgressBar1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_veiculos_alugados;
        private System.Windows.Forms.Button btn_veiculos_AlugarVeiculos;
        private System.Windows.Forms.Button btn_Tela_Cadastrar;
        private System.Windows.Forms.Label lbl_hora;
        public System.Windows.Forms.Timer timer_menu;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar2;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}