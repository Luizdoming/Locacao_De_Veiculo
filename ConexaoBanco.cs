using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemaLocacaoVeiculo
{
    public class ConexaoBanco
    {
        // TIVEMOS PROBLEMAS AO CONECTAR COM SQLITE - observar se a execução do projeto está no modo release
        //public static string Banco = Application.StartupPath + @"\dbveiculos.db";
        public static string caminho = System.Environment.CurrentDirectory; //Caminho relativo ao execultavél
        public static string Banco = caminho + @"\DataBase\dbveiculos.db";
        public static string ConectionString = @"Data Source = " + Banco + "; Version = 3";
        public SQLiteConnection con = new SQLiteConnection(ConectionString);

        #region Campos do Data Base
        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public string Categoria { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        public double Diaria { get; set; }
        public bool result { get; set; }
        #endregion 

        public void Conectar()
        {
            con.Open();
        }

        public void Desconectar()
        {
            con.Close();
        }

        public void Cadastra_Veiculos(string sql)
        {
            try
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados" + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AdListview(ListView list)
        {
            try
            {
                ListViewItem item = new ListViewItem();

                string sql = "SELECT Marca, Modelo, Categoria, Placa, Cor, Ano, Diaria FROM Veiculos";
                Conectar();
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();

                // Vamos limpar os dados da nossa lista
                list.Items.Clear();

                // Agora vamos percorrer todo o data read
                while (dr.Read() == true)
                {
                    item = list.Items.Add(dr.GetString(0));
                    item.SubItems.Add(dr.GetString(0));
                    item.SubItems.Add(dr.GetString(1));
                    item.SubItems.Add(dr.GetString(2));
                    item.SubItems.Add(dr.GetString(3));
                    item.SubItems.Add(dr.GetString(4));
                    item.SubItems.Add(dr["Ano"].ToString());
                    item.SubItems.Add(dr["Diaria"].ToString());
                }
                cmd.Dispose();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao carregar os dados para listview " + "\n" + ex.Message);
                return;
            }
            finally
            {
                Desconectar();
            }
        }

        public void ObterDadosListaVeiculosCadastrados(ListView list)
        {
            Fabricante = list.SelectedItems[0].SubItems[1].Text;
            Modelo = list.SelectedItems[0].SubItems[2].Text;
            Categoria = list.SelectedItems[0].SubItems[3].Text;
            Placa = list.SelectedItems[0].SubItems[4].Text;
            Cor = list.SelectedItems[0].SubItems[5].Text;
            Ano = Convert.ToInt16(list.SelectedItems[0].SubItems[6].Text);
            Diaria = Convert.ToDouble(list.SelectedItems[0].SubItems[7].Text);
        }

        public void EditarVeiculosCadastrados()
        {
            if (Placa == string.Empty)
            {
                MessageBox.Show("O campo Placa está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string sql = "UPDATE Veiculos SET Marca='" + Fabricante + "', Modelo='" + Modelo + "', Categoria='" + Categoria + "', Placa='" + Placa + "', Cor='" + Cor + "',Ano='" + Ano + "', Diaria='" + Diaria + "' WHERE Placa='" + Placa + "'";

            try
            {
                using (SQLiteCommand comando = new SQLiteCommand(sql, con))
                {
                    con.Open();
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao atualizar os dados" + ex.Message, "Atenção");
                con.Close();
                return;
            }
            finally { con.Close(); }
        }

        public void BuscarDadosParaEditar()
        {
            string sql = "SELECT Marca, Modelo, Categoria, Placa, Cor, Ano, Diaria FROM Veiculos WHERE Placa='" + Placa + "'";

            try
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    Conectar();
                    SQLiteDataReader dr;
                    dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        Fabricante = dr["Marca"].ToString();
                        Modelo = dr["Modelo"].ToString();
                        Categoria = dr["Categoria"].ToString();
                        Cor = dr["Cor"].ToString();
                        Ano = int.Parse(dr["Ano"].ToString());
                        Diaria = double.Parse(dr["Diaria"].ToString());
                        Placa = dr["Placa"].ToString();
                    }
                    cmd.Dispose();  // se deixar este comando ativo, ele irá blokear o banco de dados
                                    // impedindo de realizar outras tarefas simultaniamente
                    Desconectar();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao buscar Placa" + ex.Message, "Atenção");
                con.Close();
            }
        }

        public void AdcionarPlacasNaCombobox(ComboBox cbo)
        {
            try
            {
                con.Open();
                string sql = "SELECT Placa FROM Veiculos";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();

                cbo.Items.Clear();

                while (dr.Read() == true)
                {
                    cbo.Items.Add(dr["Placa"].ToString());
                }

                con.Close();
                cmd.Dispose();
            }
            catch (SQLiteException ex)
            {

                MessageBox.Show("Erro ao conectar com o banco de dados" + ex.Message, "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
