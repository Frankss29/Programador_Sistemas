using MySql.Data.MySqlClient;
using System.Data;
namespace Produtos
{
    public partial class TelaProdutos : Form
    {

        string conexao = "server=localhost; user=root;password=; database = MiniLoja";
        public TelaProdutos()
        {
            InitializeComponent();
        }


        public void AtualizarGrid()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();
                string sqlMostrar = "SELECT*FROM Produtos";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvProdutos.DataSource = dt;

            }
            catch (Exception ex) { }


        }


        private void TelaProdutos_Load(object sender, EventArgs e)
        {
            AtualizarGrid();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //1. Pegar o ID  da linha selecionada no DataDridView

            int idSelecionado;
            idSelecionado = Convert.ToInt32(dgvProdutos.CurrentRow.Cells["id_produto"].Value);

            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();
                string sqlDelete = "DELETE FROM Produtos WHERE id_produto=@id";
                MySqlCommand cmd = new MySqlCommand(sqlDelete, con);
                cmd.Parameters.AddWithValue("id", idSelecionado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto Excluido com Sucesso!!");

                AtualizarGrid();
            }
            catch (Exception ex) { }



        }
    }
}
