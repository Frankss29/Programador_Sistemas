using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hamburgueria
{
    public partial class Pedidos : Form
    {

        public Pedidos()
        {
            InitializeComponent();
        }

        private void btnCadastrarClientePedido_Click(object sender, EventArgs e)
        {
            Hamburgueria form = new Hamburgueria();
            form.Show();
            this.Hide();
        }

        private void btnCadastarItensPedido_Click(object sender, EventArgs e)
        {
            CadastroItem CadastraItens = new CadastroItem();
            CadastraItens.Show();
            this.Hide();

        }

        private void imgLogoCCliente_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }



        private void Pedidos_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sql = "SELECT*FROM Clientes";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cbClientes.DataSource = dt;
                cbClientes.DisplayMember = "nome";
                cbClientes.ValueMember = "Id_cliente";

                string sqlItens = "SELECT*FROM Itens";

                MySqlDataAdapter adp = new MySqlDataAdapter(sqlItens, con);

                DataTable dtt = new DataTable();
                adp.Fill(dtt);

                cbItens.DataSource = dtt;
                cbItens.DisplayMember = "nome_produto";
                cbItens.ValueMember = "Id_item";

            }
            catch (Exception ex) { }
        }

        private void btnSalvarPedidos_Click(object sender, EventArgs e)
        {

            int idCliente = Convert.ToInt32(cbClientes.SelectedValue);
            int iditem = Convert.ToInt32(cbItens.SelectedValue);
            int quantidade = Convert.ToInt32(numQuantidade.Value);

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sql = "INSERT INTO Compras(id_cliente,id_item, quantidade)" +
                    "VALUES (@cliente, @item, @qtd)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@cliente", idCliente);
                cmd.Parameters.AddWithValue("@item", iditem);
                cmd.Parameters.AddWithValue("@qtd", quantidade);

                MessageBox.Show("Compra salva com sucesso");

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.Show();
            this.Hide();
        }
    }
}
