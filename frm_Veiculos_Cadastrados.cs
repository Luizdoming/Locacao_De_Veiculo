using System.Windows.Forms;

namespace SistemaLocacaoVeiculo
{
    public partial class frm_Veiculos_Cadastrados : Form
    {
        // Instanciando a Classe no escopo Global
        ConexaoBanco mv = new ConexaoBanco();
        public frm_Veiculos_Cadastrados()
        {
            InitializeComponent();
        }

        private void AdcionarDadosListview()
        {
            /*    //MovimentacaoVeiculos mv = new MovimentacaoVeiculos();
            //    try
            //    {
            //        ListViewItem item = new ListViewItem();
            //        string sql = "SELECT Marca, Modelo, Categoria, Placa, Cor, Ano, Diaria FROM Veiculos";
            //        mv.Conectar();
            //        SQLiteCommand cmd = new SQLiteCommand(sql, mv.con);
            //        SQLiteDataReader dr;
            //        dr = cmd.ExecuteReader();

            //        // Vamos limpar os dados da nossa lista
            //        this.list_veiculosCadastrados.Items.Clear();

            //        // Agora vamos percorrer todo o data read
            //        while (dr.Read() == true)
            //        {
            //            item = this.list_veiculosCadastrados.Items.Add(dr.GetString(0));
            //            item.SubItems.Add(dr.GetString(0));
            //            item.SubItems.Add(dr.GetString(1));
            //            item.SubItems.Add(dr.GetString(2));
            //            item.SubItems.Add(dr.GetString(3));
            //            item.SubItems.Add(dr.GetString(4));
            //            item.SubItems.Add(dr["Ano"].ToString());
            //            item.SubItems.Add(dr["Diaria"].ToString());
            //        }
            //        cmd.Dispose();
            //    }
            //    catch (SQLiteException ex)
            //    {
            //        MessageBox.Show("Erro ao carregar os dados para listview " + "\n" + ex.Message);
            //        return;
            //    }
            //    finally
            //    {
            //        mv.Desconectar();
            */
        }

        private void frm_Veiculos_Cadastrados_Load(object sender, System.EventArgs e)
        {
            mv.AdListview(this.list_veiculosCadastrados);
            this.txt_totalVeiculos_Cadastrados.Text = this.list_veiculosCadastrados.Items.Count.ToString() + " Veiculos Cadastrados.";
        }

        private void list_veiculosCadastrados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ConexaoBanco mv = new ConexaoBanco();
            mv.ObterDadosListaVeiculosCadastrados(this.list_veiculosCadastrados);

            using (frmAlugarVeiculos frm = new frmAlugarVeiculos())
            {
                frm.txt_MarcaLocacao.Text = mv.Fabricante.ToString();
                frm.txt_AnoLocacao.Text = mv.Ano.ToString();
                frm.txt_CategoriaLocaca.Text = mv.Categoria.ToString();
                frm.txt_CorLocacao.Text = mv.Cor.ToString();
                frm.txt_DiariaLocacao.Text = mv.Diaria.ToString();
                frm.txt_ModeloLocacao.Text = mv.Modelo.ToString();
                frm.txt_PlacaLocacao.Text = mv.Placa.ToString();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();
            }
        }
    }
}
