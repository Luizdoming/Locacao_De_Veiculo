using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SistemaLocacaoVeiculo
{
    public partial class frm_Fatura : Form
    {
        public frm_Fatura()
        {
            InitializeComponent();
            this.lblData.Text = DateTime.Now.ToString("D");
            this.lblHora.Text = DateTime.Now.ToString("T");
        }

        private void ImprimirBoleto(Panel painel)
        {
            //Definindo as configuração de imprimir - a classe printSettings 
            PrinterSettings sp = new PrinterSettings();

            //Passando o paremtro para o painelboleto
            panelboleto = painel;

            //Metodo que ira definir a area de impressao do painel
            GetPrintArea(painel);

            //Chamando nosso printpreview - print_invoice
            Preview_Invoice.Document = print_invoice;


            print_invoice.PrintPage += new PrintPageEventHandler(print_invoice_PrintPage);
            Preview_Invoice.ShowDialog();

            /*string dt = Convert.ToString($"{DateTime.Now:D}");
            //string titulo = "Recibo Gerado " + dt;
            //Font fonte_titulo = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Point);
            //Font fonte_normal = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
            //Brush pincel = new SolidBrush(Color.Black);
            //Point pontoInicial = new Point(100, 50);
            //string cliente = txt_NomeClienteLocacao.Text;
            //string endereco = txt_EnderecoLocacao.Text;

            //e.Graphics.DrawString(titulo, fonte_titulo, Brushes.Red, pontoInicial);
            //e.Graphics.DrawString(cliente, fonte_normal, pincel, new Point(100, 150));
            e.Graphics.DrawString(endereco, fonte_normal, pincel, new Point(100, 210));*/
        }

        private Bitmap imagem_bitmap;

        // metodo para criar o objeto de imprimir tipo imagem
        private void GetPrintArea(Panel painel)
        {
            //Passando qual objeto que será transformado em Bitmap
            imagem_bitmap = new Bitmap(painel.Width, painel.Height);

            //Transformando em Bitmap
            painel.DrawToBitmap(imagem_bitmap, new Rectangle(0, 0, painel.Width, painel.Height));
        }

        private void print_invoice_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle AreaPagina = e.PageBounds;
            e.Graphics.DrawImage(imagem_bitmap, (AreaPagina.Width / 2) -
                (panelboleto.Width / 2), panelboleto.Location.X + 125);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ImprimirBoleto(panelboleto);
        }
    }
}
