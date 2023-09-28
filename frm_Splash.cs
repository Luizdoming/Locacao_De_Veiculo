using System;
using System.Threading;
using System.Windows.Forms;

namespace SistemaLocacaoVeiculo
{
    public partial class frm_Splash : Form
    {
        public frm_Splash()
        {
            InitializeComponent();
            timer1.Enabled = true; // Habilitando o temporizador Timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Progress_Esplash.Increment(1); // Incrementando o valor de 1 em 1 na progresBra

            int valor = 0;
            valor += Progress_Esplash.Value;
            lbl_titulo.Text = $"{valor}% Aguarde...";

            if (Progress_Esplash.Value == 100)
            {
                this.Close();

                Thread t = new Thread(() => Application.Run(new Relatorio.frm_Login()));
                timer1.Stop();
                timer1.Enabled = false;
                t.Start();
            }

        }
    }
}
