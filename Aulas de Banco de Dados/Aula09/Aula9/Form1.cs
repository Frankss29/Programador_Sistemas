using MySql.Data.MySqlClient;
using System.Data;

namespace Aula9
{
    public partial class Form1 : Form
    {
        //Criando  o endereço da conexão
        string conexao = "server=localhost;user=root;password=;database=LojaInformatica";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //Instanciando a conexão 
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "SELECT * FROM Produtos;";
                MySqlDataAdapter cmd = new MySqlDataAdapter(sql, con); //MySqlDataAdapter
                //A tabela virtual (DataTable)
                DataTable dt = new DataTable();
                cmd.Fill(dt);

                dgvProdutos.DataSource = dt;

            }
            catch 
            {

            }



        }
    }
}
