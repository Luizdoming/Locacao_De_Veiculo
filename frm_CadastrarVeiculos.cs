using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemaLocacaoVeiculo
{
    public partial class frm_CadastrarVeiculos : Form
    {
        public void LimparCampos()
        {
            try
            {
                foreach (Control controles in this.Controls)
                {
                    if (controles is TextBox)
                    {
                        controles.Text = string.Empty;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Erro ao Limpar os campos", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        public frm_CadastrarVeiculos()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ConexaoBanco mv = new ConexaoBanco();

            try
            {
                //Verificando os controles se estão vazios
                foreach (Control controles in this.Controls)
                {
                    if (controles is TextBox)
                    {
                        if (controles.Text == string.Empty)
                        {
                            MessageBox.Show("O campo é obrigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            controles.Focus();
                            return;
                        }
                    }
                }

                #region Salvar os dados No data base
                string sqlverifica, sqlSavar;
                decimal valor = Convert.ToDecimal(txt_valor_diaria_cadastro.Text);
                string result = String.Format("{0:C2}", txt_valor_diaria_cadastro.Text);

                sqlverifica = "SELECT Placa FROM Veiculos WHERE Placa ='" + txtPlaca_Veiculo.Text + "'";
                mv.Placa = txtPlaca_Veiculo.Text;

                sqlSavar = "INSERT INTO Veiculos (Marca, Modelo, Categoria, Placa, Cor, Ano, Diaria)" +
                    "VALUES ('" + txt_Marca_Cadastra.Text + "', '" + txtModelo_Veiculo.Text + "', '" + txtCategoria_Veiculo.Text + "', '" + txtPlaca_Veiculo.Text + "', '" + txtCor_Veiculo.Text + "', '" + Convert.ToInt16(txtAnoFabricacao_Veiculo.Text) + "', '" + result + "')";

                mv.Cadastra_Veiculos(sqlverifica, sqlSavar);

                #endregion

                //Limpando os controles TextBox
                foreach (Control obj in this.Controls)
                {
                    if (obj is TextBox)
                    {
                        obj.Text = "";
                    }
                }

                mv.Desconectar();
                txt_Marca_Cadastra.Focus();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao cadastrar veiculo" + ex.Message);
            }
            finally
            {
                mv.Desconectar();
            }
        }

        private void Frm_CadastrarVeiculos_Load(object sender, EventArgs e)
        {

            txt_Marca_Cadastra.CharacterCasing = CharacterCasing.Upper;
            txt_Marca_Cadastra.CharacterCasing = CharacterCasing.Upper;
            txtCategoria_Veiculo.CharacterCasing = CharacterCasing.Upper;
            txtCor_Veiculo.CharacterCasing = CharacterCasing.Upper;
            txtModelo_Veiculo.CharacterCasing = CharacterCasing.Upper;
            txtPlaca_Veiculo.CharacterCasing = CharacterCasing.Upper;
            ConexaoBanco mv = new ConexaoBanco();
            mv.AdcionarPlacasNaCombobox(Cbo_Placa);
        }

        private void Btn_visualizarVeiculos_Click(object sender, EventArgs e)
        {
            using (frm_Veiculos_Cadastrados frm = new frm_Veiculos_Cadastrados())
            {
                frm.ShowDialog();
            }
        }

        private void Btn_editar_cadastrados_Click(object sender, EventArgs e)
        {
            ConexaoBanco mv = new ConexaoBanco();

            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    if (ctr.Text == string.Empty)
                    {
                        MessageBox.Show("Para atualizar os dados preencha todos os campos", "Atenção");
                        return;
                    }
                }
            }
            try
            {
                if (Guna.UI2.WinForms.MessageDialog.Show(this, "Deseja atualizar este veiculo ?", "Atenção", Guna.UI2.WinForms.MessageDialogButtons.OKCancel, Guna.UI2.WinForms.MessageDialogIcon.Question,
                    Guna.UI2.WinForms.MessageDialogStyle.Dark) == DialogResult.OK)
                {

                    mv.Placa = txtPlaca_Veiculo.Text.Trim(); mv.Fabricante = txt_Marca_Cadastra.Text.Trim();
                    mv.Cor = txtCor_Veiculo.Text.Trim(); mv.Diaria = double.Parse(txt_valor_diaria_cadastro.Text.Trim());
                    mv.Ano = int.Parse(txtAnoFabricacao_Veiculo.Text.Trim()); mv.Categoria = txtCategoria_Veiculo.Text.Trim();
                    mv.Modelo = txtModelo_Veiculo.Text.Trim();
                    mv.EditarVeiculosCadastrados();
                    LimparCampos();

                    //Mensagem personalizada
                    Guna.UI2.WinForms.MessageDialog.Show(this, "Dados atualizado com sucesso!", "Aviso!", Guna.UI2.WinForms.MessageDialogButtons.OK, Guna.UI2.WinForms.MessageDialogIcon.Information, Guna.UI2.WinForms.MessageDialogStyle.Dark);
                }
                else { return; }

            }
            catch
            {
                MessageBox.Show("Erro encontrado, verifique se a placa existe", "Aviso!");
                return;
            }
        }

        private void Cbo_Placa_SelectedValueChanged(object sender, EventArgs e)
        {
            ConexaoBanco mv = new ConexaoBanco();
            try
            {
                if (Cbo_Placa.Text != "" || Cbo_Placa.SelectedItem.ToString() != null)
                {
                    mv.Placa = Cbo_Placa.Text;
                    mv.BuscarDadosParaEditar();

                    try
                    {
                        if (mv.Fabricante.ToString() == null || mv.Diaria.ToString() == null || mv.Cor.ToString() == null)
                        {
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erro ao buscar placa verifique se digitou corretamente", "Atenção");
                        return;
                    }

                    txt_Marca_Cadastra.Text = mv.Fabricante.ToString();
                    txt_valor_diaria_cadastro.Text = mv.Diaria.ToString();
                    txtModelo_Veiculo.Text = mv.Modelo.ToString();
                    txtCategoria_Veiculo.Text = mv.Categoria.ToString();
                    txtAnoFabricacao_Veiculo.Text = mv.Ano.ToString();
                    txtCor_Veiculo.Text = mv.Cor.ToString();
                    txtPlaca_Veiculo.Text = mv.Placa.ToString();
                }
                else
                {
                    return;
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Placa não cadastrada..." + ex.Message, "Aviso!");
            }
        }

        private void Txt_valor_diaria_cadastro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Metodo ppara verificar se o valor digitado em uma letra
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            //if (e.KeyChar < 47 || e.KeyChar > 58)
            //{
            //    e.KeyChar = (Char)0;
            //}
        }

        private void Txt_valor_diaria_cadastro_TextChanged(object sender, EventArgs e)
        {
            //    //decimal valor = txt_valor_diaria_cadastro.Text;
            //    string result = String.Format("{0:C2}", txt_valor_diaria_cadastro.Text);
            //    this.txt_valor_diaria_cadastro.Text = result;
        }
    }
}

