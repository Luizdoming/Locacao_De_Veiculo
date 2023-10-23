using System;
using System.Windows.Forms;

namespace SistemaLocacaoVeiculo
{
    public partial class frmAlugarVeiculos : Form
    {

        public frmAlugarVeiculos()
        {
            InitializeComponent();
        }

        private void frmCadVeiculos_Load(object sender, EventArgs e)
        {
            //Campos para permitir somente leitura dos dados, não a inserção
            this.txt_TotalLocacao.ReadOnly = true;
            this.txt_CategoriaLocaca.ReadOnly = true;
            this.txt_MarcaLocacao.ReadOnly = true;
            this.txt_PlacaLocacao.ReadOnly = true;
            this.txt_AnoLocacao.ReadOnly = true;
            this.txt_CorLocacao.ReadOnly = true;
            this.txt_DiariaLocacao.ReadOnly = true;
            this.txt_EnderecoLocacao.MaxLength = 30;
            this.txt_NomeClienteLocacao.MaxLength = 30;
            txt_NomeClienteLocacao.Focus();
        }

        private void btn_abrir_tela_veiculosCadastrados_Click(object sender, EventArgs e)
        {
            frm_Veiculos_Cadastrados frm = new frm_Veiculos_Cadastrados();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void numeric_Alugar_Veiculos_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int qtd_Dias = Convert.ToInt16(this.numeric_Alugar_Veiculos.Value);
                double valor_Diaria = Convert.ToDouble(this.txt_DiariaLocacao.Text);
                decimal result = Convert.ToDecimal(qtd_Dias * valor_Diaria);
                this.txt_TotalLocacao.Text = String.Format("{0:C2}", result);

                // Váriavel para aramzenar o valor da data atual 
                DateTime dt = DateTime.Now;
                this.txt_Data_Entrega.Text = dt.AddDays(qtd_Dias).ToString("d");

            }
            catch
            {
                MessageBox.Show("O campo valor diaria está Vazio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.numeric_Alugar_Veiculos.Value = 1;
                this.txt_TotalLocacao.Clear();
                this.txt_TotalLocacao.Focus();
                return;
            }

        }

        private void btn_AbrirF_Valugados_Click(object sender, EventArgs e)
        {
            using (frmVeiculosAlugados frm = new frmVeiculosAlugados())
            {
                frm.ShowDialog();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            foreach (Control controles in this.Controls)
            {
                if (controles is TextBox)
                {
                    if (controles.Text == string.Empty)
                    {
                        MessageBox.Show("Existe campos vazio", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        controles.Focus();
                        return;
                    }
                }
            }

            String novo = txt_TotalLocacao.Text;
            string formatada = novo.Replace("R$", "");
            AlugarVeiculos alugar = new AlugarVeiculos();

            alugar.Placa = txt_PlacaLocacao.Text;
            //alugar.Data_Locacao = Data_Saida.Text; Esse valor foi atribuido diretamente no codigo do banco de dados
            alugar.Data_Entrega = txt_Data_Entrega.Text;
            alugar.Marca = txt_MarcaLocacao.Text;
            alugar.Ano = int.Parse(txt_AnoLocacao.Text);
            alugar.Categoria = txt_CategoriaLocaca.Text;
            alugar.Cor = txt_CorLocacao.Text;
            alugar.Endereco = txt_EnderecoLocacao.Text;
            alugar.Nome_cliente = txt_NomeClienteLocacao.Text;
            alugar.Modelo = txt_ModeloLocacao.Text;
            alugar.Qtd_Dias = Convert.ToInt16(numeric_Alugar_Veiculos.Value);
            alugar.Valor_Diaria = double.Parse(txt_DiariaLocacao.Text);
            alugar.Valor_Total = Convert.ToDouble(formatada);

            alugar.Salvar_Aluguel_Veiculos();

            /* Adcionando os valores ao formulario Fatura para imprimir */
            using (frm_Fatura frm = new frm_Fatura())
            {
                // Formatando o valor para moeda
                double diaria = Convert.ToDouble(txt_DiariaLocacao.Text);
                string valor = String.Format("{0:C2}", diaria);

                frm.txtNomeClienteBoleto.Text = txt_NomeClienteLocacao.Text;
                frm.txt_dataentregaBoleto.Text = txt_Data_Entrega.Text;
                frm.txt_diaria_Boleto.Text = valor;
                frm.txt_EnderecoBoleto.Text = txt_EnderecoLocacao.Text;
                frm.txt_ModeloVeiculoBoleto.Text = txt_ModeloLocacao.Text;
                frm.txt_PlacaBoleto.Text = txt_PlacaLocacao.Text;
                frm.txt_quantidade_DiasBoleto.Text = Convert.ToInt16(numeric_Alugar_Veiculos.Value).ToString();
                frm.txt_TotalBoleto.Text = txt_TotalLocacao.Text;
                frm.txt_datAludaga.Text = DateTime.Now.ToString("d");

                foreach (Control obj in this.Controls)
                {
                    if (obj is TextBox)
                        obj.Text = string.Empty;
                }
                this.numeric_Alugar_Veiculos.ResetText();
                frm.ShowDialog();
            }

        }
    }
}
