using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SistemaLocacaoVeiculo
{
    internal class AlugarVeiculos
    {
        #region Campos do banco de dados
        public string Nome_cliente { get; set; }
        public string Endereco { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }
        public string Cor { get; set; }
        public string Categoria { get; set; }
        public double Valor_Diaria { get; set; }
        public int Qtd_Dias { get; set; }
        public double Valor_Total { get; set; }
        public string Data_Entrega { get; set; }
        public string Data_Locacao { get; set; }
        #endregion 

        public void Salvar_Aluguel_Veiculos()
        {
            string sql = "INSERT INTO TabelaVeiculosAlugados(NomeCliente, Endereco, PlacaVeiculo, MarcaVeiculo, Modelo, Cor, Categoria, AnoFabricacao, DataLocacao, DataEntrega, QuantidadeDias, ValorDiaria, Total)" +
              " VALUES(" +
              "@NomeCliente, @Endereco, @PlacaVeiculo, @MarcaVeiculo, @Modelo, @Cor, @Categoria, @AnoFabricacao, Date(), @DataEntrega, @QuantidadeDias, @ValorDiaria, @Total)";

            ConexaoBanco mv = new ConexaoBanco();

            try
            {
                mv.Conectar();
                using (SQLiteCommand cmd = new SQLiteCommand(sql, mv.con))
                {
                    cmd.Parameters.AddWithValue("@NomeCliente", Nome_cliente.ToString());
                    cmd.Parameters.AddWithValue("@Endereco", Endereco.ToString());
                    cmd.Parameters.AddWithValue("@PlacaVeiculo", Placa.ToString());
                    cmd.Parameters.AddWithValue("@MarcaVeiculo", Marca.ToString());
                    cmd.Parameters.AddWithValue("@Modelo", Modelo.ToString());
                    cmd.Parameters.AddWithValue("@Cor", Cor.ToString());
                    cmd.Parameters.AddWithValue("@Categoria", Categoria.ToString());
                    cmd.Parameters.AddWithValue("@AnoFabricacao", Ano.ToString());
                    //cmd.Parameters.AddWithValue("@DataLocacao", Data_Locacao.ToString());
                    cmd.Parameters.AddWithValue("@DataEntrega", Data_Entrega.ToString());
                    cmd.Parameters.AddWithValue("@QuantidadeDias", Qtd_Dias.ToString());
                    cmd.Parameters.AddWithValue("@ValorDiaria", Valor_Diaria.ToString());
                    cmd.Parameters.AddWithValue("@Total", double.Parse(Valor_Total.ToString()));
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    MessageBox.Show("Veiculo Alugado com Sucesso Para o Cliente " + Nome_cliente.ToString(), "Aviso!");
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erroa ao salvar os dados" + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally { mv.Desconectar(); }
        }

        public void Verificar_Campos()
        {
            List<string> campos = new List<string>();
            campos.Add(Marca.ToString()); campos.Add(Cor.ToString());
            campos.Add(Categoria.ToString()); campos.Add(Nome_cliente.ToString());
            campos.Add(Valor_Diaria.ToString()); campos.Add(Valor_Total.ToString());
            campos.Add(Qtd_Dias.ToString()); campos.Add(Placa.ToString());
            campos.Add(Modelo.ToString()); campos.Add(Data_Entrega.ToString());
            campos.Add(Data_Locacao.ToString()); campos.Add(Ano.ToString());
            campos.Add(Endereco.ToString());

            for (int i = 0; i < campos.Count; i++)
            {
                if (campos[i] == string.Empty)
                {
                    MessageBox.Show("O campo " + campos[i] + " Está Vazio ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

        }

        public void PopularListaVeiculosAlugados(ListView list)
        {
            // instaciei a classe de conexao com o banco de dados
            ConexaoBanco cn = new ConexaoBanco();
            ListViewItem item = new ListViewItem();
            list.Items.Clear();

            string sql = "SELECT ID, NomeCliente, Endereco, PlacaVeiculo, Modelo, DataLocacao, QuantidadeDias, DataEntrega, Total FROM TabelaVeiculosAlugados";

            try
            {
                cn.Conectar();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = cn.con; cmd.CommandText = sql;
                    SQLiteDataReader dr;
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        item = list.Items.Add(dr["ID"].ToString());
                        item.SubItems.Add(dr.GetString(1));
                        item.SubItems.Add(dr.GetString(2));
                        item.SubItems.Add(dr.GetString(3));
                        item.SubItems.Add(dr.GetString(4));
                        item.SubItems.Add(dr.GetString(5));
                        item.SubItems.Add(dr["QuantidadeDias"].ToString());
                        item.SubItems.Add(dr["DataEntrega"].ToString());
                        decimal valor = dr.GetDecimal(8); //obtendo o valor do campo Total
                        string result = String.Format("{0:C2}", valor); // convertendo o valor em moeda
                                                                        //item.SubItems.Add(dr.GetDouble(7).ToString());
                        item.SubItems.Add(result); // Adcionando o valor convertido em nossa lista 
                    }
                    cmd.Dispose();
                    cn.Desconectar();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao Buscar os dados da tabela de veiculos alugados" + ex.Message);
                cn.Desconectar();
                return;
            }
        }


        public void FiltrarVeiculosAlugados(ListView list)
        {
            string sql = "SELECT ID, NomeCliente, Endereco, PlacaVeiculo, Modelo, DataLocacao, QuantidadeDias, DataEntrega, Total FROM TabelaVeiculosAlugados WHERE NomeCliente LIKE '" + Nome_cliente + "%'";

            ConexaoBanco cn = new ConexaoBanco();
            ListViewItem item = new ListViewItem();
            list.Items.Clear();

            try
            {
                cn.Conectar();
                using (SQLiteCommand cmd = new SQLiteCommand())
                {
                    cmd.Connection = cn.con;
                    cmd.CommandText = sql;
                    SQLiteDataReader dr;
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        item = list.Items.Add(dr["ID"].ToString());
                        item.SubItems.Add(dr.GetString(1));
                        item.SubItems.Add(dr.GetString(2));
                        item.SubItems.Add(dr.GetString(3));
                        item.SubItems.Add(dr.GetString(4));
                        item.SubItems.Add(dr.GetString(5));
                        item.SubItems.Add(dr["QuantidadeDias"].ToString());
                        item.SubItems.Add(dr["DataEntrega"].ToString());
                        decimal valor = dr.GetDecimal(8); //obtendo o valor do campo Total
                        string result = String.Format("{0:C2}", valor); // convertendo o valor em moeda
                        item.SubItems.Add(result); // Adcionando o valor convertido em nossa lista
                    }
                    cmd.Dispose();
                    cn.Desconectar();
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Erro ao pesquisar valores" + ex.Message);
                cn.Desconectar();
                return;
            }
        }

        public void ConfigDataGridview(DataGridView list)
        {
            // Adcionando os nomes das colunas do DataGridView
            list.Columns[0].HeaderText = "ID";
            list.Columns[1].HeaderText = "Cliente";
            list.Columns[2].HeaderText = "Endereço";
            list.Columns[3].HeaderText = "Placa";
            list.Columns[4].HeaderText = "Data Locação";
            list.Columns[5].HeaderText = "Qtd Dias";
            list.Columns[6].HeaderText = "Data Entrega";
            list.Columns[7].HeaderText = "Valor";

            //Adcionando o tamanho das colunas
            list.Columns["ID"].Width = 50;
            list.Columns["Cliente"].Width = 160;
            list.Columns["Endereço"].Width = 125;
            list.Columns["Placa"].Width = 85;
            list.Columns["Data Locação"].Width = 90;
            list.Columns["Qtd Dias"].Width = 90;
            list.Columns["Data Entrega"].Width = 125;
            list.Columns["Valor"].Width = 100;

            // Ajustando o alinhamento
            list.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            list.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            list.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            list.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            list.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            list.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            list.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            list.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

            list.Columns["Valor"].DefaultCellStyle.Format = "{0:C2}";
        }
    }
}
