using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;
namespace Hamburgueria
{
    public partial class Hamburgueria : Form
    {
        public Hamburgueria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlInserir = "INSERT INTO Clientes(nome,cpf) VALUES (@nome,@cpf)";
                MySqlCommand cmd = new MySqlCommand(sqlInserir, con);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@cpf", txtCPF.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente Cadastrado com Sucesso !!");

                string sqlMostrar = "SELECT*FROM Clientes";
                MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                dgvClientes.DataSource = dt;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        private void btnCadastrarItens_Click(object sender, EventArgs e)
        {
            CadastroItem item = new CadastroItem();
            item.Show();
            this.Hide();

        }

        private void imgLogoCCliente_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }

        private void Hamburgueria_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            con.Open();
            string sqlMostrar = "SELECT*FROM Clientes";
            MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, con);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            dgvClientes.DataSource = dt;
        }
    }
}
