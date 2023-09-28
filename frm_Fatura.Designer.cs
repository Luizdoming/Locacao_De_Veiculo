namespace SistemaLocacaoVeiculo
{
    partial class frm_Fatura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Fatura));
            this.print_invoice = new System.Drawing.Printing.PrintDocument();
            this.Preview_Invoice = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeClienteBoleto = new System.Windows.Forms.TextBox();
            this.txt_EnderecoBoleto = new System.Windows.Forms.TextBox();
            this.txt_ModeloVeiculoBoleto = new System.Windows.Forms.TextBox();
            this.txt_PlacaBoleto = new System.Windows.Forms.TextBox();
            this.txt_diaria_Boleto = new System.Windows.Forms.TextBox();
            this.txt_dataentregaBoleto = new System.Windows.Forms.TextBox();
            this.txt_quantidade_DiasBoleto = new System.Windows.Forms.TextBox();
            this.txt_TotalBoleto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panelboleto = new System.Windows.Forms.Panel();
            this.txt_datAludaga = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelboleto.SuspendLayout();
            this.SuspendLayout();
            // 
            // print_invoice
            // 
            this.print_invoice.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_invoice_PrintPage);
            // 
            // Preview_Invoice
            // 
            this.Preview_Invoice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.Preview_Invoice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.Preview_Invoice.ClientSize = new System.Drawing.Size(400, 300);
            this.Preview_Invoice.Enabled = true;
            this.Preview_Invoice.Icon = ((System.Drawing.Icon)(resources.GetObject("Preview_Invoice.Icon")));
            this.Preview_Invoice.Name = "Preview_Invoice";
            this.Preview_Invoice.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.label1.Location = new System.Drawing.Point(33, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 14);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 852);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 14);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ld System Locação de Veiculos";
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(386, 831);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(284, 18);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data";
            this.lblData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblHora
            // 
            this.lblHora.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(29, 831);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(118, 18);
            this.lblHora.TabIndex = 4;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 740);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(611, 2);
            this.label5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 742);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Assinatura:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 723);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Veiculo";
            // 
            // txtNomeClienteBoleto
            // 
            this.txtNomeClienteBoleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomeClienteBoleto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeClienteBoleto.Location = new System.Drawing.Point(299, 196);
            this.txtNomeClienteBoleto.Name = "txtNomeClienteBoleto";
            this.txtNomeClienteBoleto.Size = new System.Drawing.Size(306, 17);
            this.txtNomeClienteBoleto.TabIndex = 9;
            // 
            // txt_EnderecoBoleto
            // 
            this.txt_EnderecoBoleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_EnderecoBoleto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EnderecoBoleto.Location = new System.Drawing.Point(257, 317);
            this.txt_EnderecoBoleto.Name = "txt_EnderecoBoleto";
            this.txt_EnderecoBoleto.Size = new System.Drawing.Size(318, 17);
            this.txt_EnderecoBoleto.TabIndex = 9;
            // 
            // txt_ModeloVeiculoBoleto
            // 
            this.txt_ModeloVeiculoBoleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ModeloVeiculoBoleto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ModeloVeiculoBoleto.Location = new System.Drawing.Point(115, 123);
            this.txt_ModeloVeiculoBoleto.Name = "txt_ModeloVeiculoBoleto";
            this.txt_ModeloVeiculoBoleto.Size = new System.Drawing.Size(173, 17);
            this.txt_ModeloVeiculoBoleto.TabIndex = 9;
            // 
            // txt_PlacaBoleto
            // 
            this.txt_PlacaBoleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PlacaBoleto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PlacaBoleto.Location = new System.Drawing.Point(469, 123);
            this.txt_PlacaBoleto.Name = "txt_PlacaBoleto";
            this.txt_PlacaBoleto.Size = new System.Drawing.Size(111, 17);
            this.txt_PlacaBoleto.TabIndex = 9;
            this.txt_PlacaBoleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_diaria_Boleto
            // 
            this.txt_diaria_Boleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_diaria_Boleto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaria_Boleto.Location = new System.Drawing.Point(531, 386);
            this.txt_diaria_Boleto.Name = "txt_diaria_Boleto";
            this.txt_diaria_Boleto.Size = new System.Drawing.Size(107, 17);
            this.txt_diaria_Boleto.TabIndex = 9;
            this.txt_diaria_Boleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dataentregaBoleto
            // 
            this.txt_dataentregaBoleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_dataentregaBoleto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataentregaBoleto.Location = new System.Drawing.Point(382, 530);
            this.txt_dataentregaBoleto.Name = "txt_dataentregaBoleto";
            this.txt_dataentregaBoleto.Size = new System.Drawing.Size(110, 17);
            this.txt_dataentregaBoleto.TabIndex = 9;
            this.txt_dataentregaBoleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_quantidade_DiasBoleto
            // 
            this.txt_quantidade_DiasBoleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_quantidade_DiasBoleto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantidade_DiasBoleto.Location = new System.Drawing.Point(252, 459);
            this.txt_quantidade_DiasBoleto.Name = "txt_quantidade_DiasBoleto";
            this.txt_quantidade_DiasBoleto.Size = new System.Drawing.Size(69, 17);
            this.txt_quantidade_DiasBoleto.TabIndex = 9;
            this.txt_quantidade_DiasBoleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_TotalBoleto
            // 
            this.txt_TotalBoleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TotalBoleto.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TotalBoleto.Location = new System.Drawing.Point(464, 593);
            this.txt_TotalBoleto.Name = "txt_TotalBoleto";
            this.txt_TotalBoleto.Size = new System.Drawing.Size(158, 17);
            this.txt_TotalBoleto.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "De placa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Foi alugado para o Cliente";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Onde o mesmo Reside em";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 386);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(485, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Tendo o conhecimento no valor da diaria do veiculo em";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 458);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 17);
            this.label12.TabIndex = 8;
            this.label12.Text = "Com uma necessidade de ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(335, 458);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "dias.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 529);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(341, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Com data para entrega do mesmo no dia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(39, 594);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(422, 17);
            this.label15.TabIndex = 8;
            this.label15.Text = "Com base nas informações,  pagarei um valor de";
            // 
            // panelboleto
            // 
            this.panelboleto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelboleto.Controls.Add(this.label2);
            this.panelboleto.Controls.Add(this.txt_TotalBoleto);
            this.panelboleto.Controls.Add(this.guna2Button1);
            this.panelboleto.Controls.Add(this.txt_quantidade_DiasBoleto);
            this.panelboleto.Controls.Add(this.label1);
            this.panelboleto.Controls.Add(this.txt_dataentregaBoleto);
            this.panelboleto.Controls.Add(this.label3);
            this.panelboleto.Controls.Add(this.txt_diaria_Boleto);
            this.panelboleto.Controls.Add(this.lblData);
            this.panelboleto.Controls.Add(this.txt_PlacaBoleto);
            this.panelboleto.Controls.Add(this.lblHora);
            this.panelboleto.Controls.Add(this.txt_ModeloVeiculoBoleto);
            this.panelboleto.Controls.Add(this.label5);
            this.panelboleto.Controls.Add(this.txt_datAludaga);
            this.panelboleto.Controls.Add(this.txt_EnderecoBoleto);
            this.panelboleto.Controls.Add(this.label16);
            this.panelboleto.Controls.Add(this.label4);
            this.panelboleto.Controls.Add(this.txtNomeClienteBoleto);
            this.panelboleto.Controls.Add(this.label6);
            this.panelboleto.Controls.Add(this.label8);
            this.panelboleto.Controls.Add(this.label7);
            this.panelboleto.Controls.Add(this.label13);
            this.panelboleto.Controls.Add(this.label9);
            this.panelboleto.Controls.Add(this.label15);
            this.panelboleto.Controls.Add(this.label17);
            this.panelboleto.Controls.Add(this.label10);
            this.panelboleto.Controls.Add(this.label14);
            this.panelboleto.Controls.Add(this.label11);
            this.panelboleto.Controls.Add(this.label12);
            this.panelboleto.Location = new System.Drawing.Point(0, 0);
            this.panelboleto.Name = "panelboleto";
            this.panelboleto.Size = new System.Drawing.Size(703, 911);
            this.panelboleto.TabIndex = 10;
            // 
            // txt_datAludaga
            // 
            this.txt_datAludaga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_datAludaga.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datAludaga.Location = new System.Drawing.Point(105, 257);
            this.txt_datAludaga.Name = "txt_datAludaga";
            this.txt_datAludaga.Size = new System.Drawing.Size(100, 17);
            this.txt_datAludaga.TabIndex = 9;
            this.txt_datAludaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(143, 884);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(417, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "Copyright todos os direitos reservados  |  Luiz domingo da silva";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(39, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 18);
            this.label17.TabIndex = 8;
            this.label17.Text = "No dia";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 3;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::SistemaLocacaoVeiculo.Properties.Resources.print1;
            this.guna2Button1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2Button1.Location = new System.Drawing.Point(637, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(40, 40);
            this.guna2Button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.guna2Button1, "Imprimir Boleto");
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(84)))), ((int)(((byte)(247)))));
            this.toolTip1.ForeColor = System.Drawing.Color.Silver;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // frm_Fatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(703, 911);
            this.Controls.Add(this.panelboleto);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Fatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.panelboleto.ResumeLayout(false);
            this.panelboleto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument print_invoice;
        private System.Windows.Forms.PrintPreviewDialog Preview_Invoice;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelboleto;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox txtNomeClienteBoleto;
        public System.Windows.Forms.TextBox txt_EnderecoBoleto;
        public System.Windows.Forms.TextBox txt_ModeloVeiculoBoleto;
        public System.Windows.Forms.TextBox txt_PlacaBoleto;
        public System.Windows.Forms.TextBox txt_diaria_Boleto;
        public System.Windows.Forms.TextBox txt_dataentregaBoleto;
        public System.Windows.Forms.TextBox txt_quantidade_DiasBoleto;
        public System.Windows.Forms.TextBox txt_TotalBoleto;
        public System.Windows.Forms.TextBox txt_datAludaga;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}