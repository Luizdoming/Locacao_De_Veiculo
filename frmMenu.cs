using System;
using System.Windows.Forms;

namespace SistemaLocacaoVeiculo
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btn_veiculos_alugados_Click(object sender, EventArgs e)
        {
            using (frmVeiculosAlugados frm = new frmVeiculosAlugados())
            {
                frm.ShowDialog();
            }
        }

        private void btn_veiculos_AlugarVeiculos_Click(object sender, EventArgs e)
        {
            using (frmAlugarVeiculos frm = new frmAlugarVeiculos())
            {
                frm.ShowDialog();
            }
        }

        private void btn_Tela_Cadastrar_Click(object sender, EventArgs e)
        {
            using (frm_CadastrarVeiculos frm = new frm_CadastrarVeiculos())
            {
                frm.ShowDialog();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            timer_menu.Start();
            btn_Tela_Cadastrar.Visible = false;
            btn_veiculos_alugados.Visible = false;
            btn_veiculos_AlugarVeiculos.Visible = false;
        }

        private void timer_menu_Tick(object sender, EventArgs e)
        {
            this.lbl_hora.Text = Convert.ToString($"{DateTime.Now:T}");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/vba_python/");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/luiz-devweb");
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
