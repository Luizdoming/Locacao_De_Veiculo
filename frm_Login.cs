using System.Windows.Forms;

namespace SistemaLocacaoVeiculo.Relatorio
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void txt_login_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificando se o caractere digitado é uma Letra
            //if (Char.IsLetter(e.KeyChar))
            //{
            //    MessageBox.Show("Este campo so aceita números!");
            //    e.Handled = true;
            //}
        }

        void Login()
        {
            string senha = "270815";
            string user = "LUIZ";

            if (txt_login_pass.Text.Trim() == senha && txt_login_user.Text.Trim().ToLower() == user.ToLower())
            {
                using (frmMenu frm = new frmMenu())
                {
                    this.Hide();
                    frm.ShowDialog();
                }
            }
            else
            {
                Messagem.Show();
                this.txt_login_pass.ResetText();
                this.txt_login_user.ResetText();
            }
        }

        private void txt_login_pass_TextChanged(object sender, System.EventArgs e)
        {
            if (txt_login_user.TextLength >= 4 && txt_login_pass.TextLength >= 6)
                Login();
            else { return; }
        }
    }
}
