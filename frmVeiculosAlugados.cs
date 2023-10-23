using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SistemaLocacaoVeiculo
{
    public partial class frmVeiculosAlugados : Form
    {
        public frmVeiculosAlugados()
        {
            InitializeComponent();
            //AdcionarImpressoras();
        }

        private void frmVeiculosAlugados_Load(object sender, EventArgs e)
        {
            //Instanciando a classe AlugarVeiculos
            AlugarVeiculos av = new AlugarVeiculos();

            //Chamamndo o metodo popular listview
            av.PopularListaVeiculosAlugados(this.ListGridview);
        }

        private void AdcionarImpressoras()
        {
            //this.cboImpressoras.Items.Clear();

            //foreach (var impresssoras in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            //{
            //    cboImpressoras.Items.Add(impresssoras);
            //}
        }

        private void txt_pesquisarAlugados_TextChanged_1(object sender, EventArgs e)
        {
            AlugarVeiculos av = new AlugarVeiculos();
            av.Nome_cliente = this.txt_pesquisarAlugados.Text;
            av.FiltrarVeiculosAlugados(this.ListGridview);
        }

        private void ListGridview_DoubleClick(object sender, EventArgs e)
        {
            using (frm_Fatura fatura = new frm_Fatura())
            {
                string formatada = ListGridview.SelectedItems[0].SubItems[8].Text;

                double valor_Total = Double.Parse(formatada.Replace("R$", ""));
                int Qtd_Dias = int.Parse(ListGridview.SelectedItems[0].SubItems[6].Text);

                double Diaria = valor_Total / Qtd_Dias;

                fatura.txtNomeClienteBoleto.Text = ListGridview.SelectedItems[0].SubItems[1].Text;
                fatura.txt_EnderecoBoleto.Text = ListGridview.SelectedItems[0].SubItems[2].Text;
                fatura.txt_PlacaBoleto.Text = ListGridview.SelectedItems[0].SubItems[3].Text;
                fatura.txt_ModeloVeiculoBoleto.Text = ListGridview.SelectedItems[0].SubItems[4].Text;
                fatura.txt_datAludaga.Text = ListGridview.SelectedItems[0].SubItems[5].Text;
                fatura.txt_quantidade_DiasBoleto.Text = ListGridview.SelectedItems[0].SubItems[6].Text;
                fatura.txt_dataentregaBoleto.Text = ListGridview.SelectedItems[0].SubItems[7].Text;
                fatura.txt_TotalBoleto.Text = ListGridview.SelectedItems[0].SubItems[8].Text;
                fatura.txt_diaria_Boleto.Text = String.Format("{0:C2}", Diaria);
                fatura.ShowDialog();
            }
        }

        private void Create_TextFile()
        {
            if (MessageBox.Show("Deseja criar o Arquivo ?", "LD System", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                // Indicando o caminho e a pasta onde será salvo os arquivos de texto
                string path_ = @"D:\Reports\"; // Nome da pasta
                Random Numbers_reports = new Random(); // Gera um número aleatorio para cada File.
                string NameFile = $"File_de_Número{Numbers_reports.Next(0, 900000)}" + ".txt";

                //C:\Users\luiz-\Documents

                //Criando o File
                File.Create(path_ + NameFile).Close();

                //Iniciando o processo de escrita
                StreamWriter Escrita_File = new StreamWriter(path_ + NameFile, true, Encoding.Default);

                //Percorrendo toda lista de veiculos alugados e adcioando dentro do arquivo de texto
                List<string> lista = new List<string>();

                foreach (ListViewItem veiculos in ListGridview.Items)
                {
                    foreach (ListViewItem.ListViewSubItem ListSubItem in veiculos.SubItems)
                    {
                        //Adcionando os Itens da listview dentro da nossa Lista
                        lista.Add(ListSubItem.Text);
                    }
                }

                //Variavél onde irá criar a linha completa com o item da litview
                string name = "";
                int i = 0;

                foreach (var item in lista)
                {
                    //Montando a linha
                    name += " " + item + "  ";
                    i++;

                    if (i == 9)
                    {
                        Escrita_File.WriteLine(name);
                        name = string.Empty;
                        i = 0;
                        Escrita_File.WriteLine("--------------------------------------------------------------------------------------------------------------------");
                    }
                }

                Escrita_File.Close(); //Temos que fechar nosso Arquivo
                MessageBox.Show("Arquivo criado com sucesso!");
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Chamando o metodo de criar o Arquivo de texto
            Create_TextFile();
        }
    }
}
