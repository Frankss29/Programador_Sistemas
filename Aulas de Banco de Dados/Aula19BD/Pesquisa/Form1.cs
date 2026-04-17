using MySql.Data.MySqlClient;
using System.Data;
using System.Net.Http.Headers;
namespace Pesquisa
{
    public partial class Form1 : Form
    {
        string conexao = "server=localhost;user=root;password=;database = loja";

        public Form1()
        {
            InitializeComponent();
        }

        public void AtualizarGrid()
        {
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();
                string sqlMostrar = "SELECT*FROM Clientes";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvClientes.DataSource = dt;
            }
            catch (Exception ex) { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {

                con.Open();

                //MINHA VERSÃO 
                string sql;

                if (txtPesquisar.Text.Contains("@"))
                {
                    sql = "SELECT id, nome, email FROM Clientes WHERE email LIKE @valor";
                }
                else
                {
                    sql = "SELECT id, nome, email FROM Clientes WHERE nome LIKE @valor";
                }

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@valor", "%" + txtPesquisar.Text + "%");
                MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                adt.Fill(dtt);

                dgvClientes.DataSource = dtt;

                //===========================================================
                //VERSÃO PROFESSOR

                // string texto= txtPesquisar.Text.Trim(); //Adicionar no meu codigo 
                // string sql;
                /*
                if (txtPesquisar.Text.Contains("@") )
                {
                   sql = "SELECT id, nome, email FROM Clientes WHERE email LIKE @email";
                    MySqlCommand cmdd = new MySqlCommand(sql, con);
                    cmdd.Parameters.AddWithValue("@email", "%" + texto + "%");
                    MySqlDataAdapter adtt = new MySqlDataAdapter(cmdd);
                    DataTable dttt = new DataTable();
                    adtt.Fill(dttt);

                    dgvClientes.DataSource = dttt;

                }
                else 
                {

                sql = "SELECT id, nome, email FROM Clientes WHERE nome LIKE @nome";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", "%" + texto + "%");
                MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
                DataTable dtt = new DataTable();
                adt.Fill(dtt);

                dgvClientes.DataSource = dtt;

                }*/
            }
            catch (Exception ex) { }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();
                string sqlCadastrar = "INSERT INTO Clientes(nome,email) VALUES(@nome, @email)";
                MySqlCommand c = new MySqlCommand(sqlCadastrar, con);
                c.Parameters.AddWithValue("@nome", txtNome.Text);
                c.Parameters.AddWithValue("@email", txtEmail.Text);

                c.ExecuteNonQuery();
                MessageBox.Show("Usuario Cadastrado com Sucesso");
                AtualizarGrid();
            }
            catch (Exception ex) { }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int idSelecionado;
            idSelecionado= Convert.ToInt32(dgvClientes.CurrentRow.Cells["id"].Value);
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();
                string sqlDelete = "DELETE FROM Clientes WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sqlDelete, con);
                cmd.Parameters.AddWithValue("id", idSelecionado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Excluido com Sucesso!!");

                AtualizarGrid();
            }
            catch (Exception ex) { }
        }
    }
}
