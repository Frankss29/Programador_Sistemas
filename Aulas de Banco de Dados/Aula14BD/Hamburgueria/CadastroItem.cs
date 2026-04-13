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
    public partial class CadastroItem : Form
    {
        public CadastroItem()
        {
            InitializeComponent();
        }

        private void btnSalvarCItens_Click(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {

                con.Open();
                string sql = "INSERT INTO Itens(nome_produto,preco_unitario)VALUES(@nome,@preco)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNomeProduto.Text);
                cmd.Parameters.AddWithValue("@preco", Convert.ToInt32(txtPreco.Text));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto Cadastro com Sucesso!!");

            }
            catch (Exception ex) { }

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Hamburgueria form = new Hamburgueria();
            form.Show();
            this.Hide();
        }

        private void imgLogoCItens_Click(object sender, EventArgs e)
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
    }
}
