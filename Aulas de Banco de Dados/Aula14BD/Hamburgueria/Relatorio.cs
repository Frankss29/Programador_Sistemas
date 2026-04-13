using MySql.Data.MySqlClient;
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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            string sql = "SELECT " +
                "Clientes.nome, " +
                "Clientes.cpf, " +
                "Itens.nome_produto, " +
                "Compras.quantidade " +
                "FROM Compras " +
                "INNER JOIN Clientes ON Compras.id_cliente = Clientes.id_cliente " +
                "INNER JOIN Itens ON Compras.id_item=Itens.id_item ";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvRelatorio.DataSource = dt;
        }

        private void btnCadastrarClientesRelatorio_Click(object sender, EventArgs e)
        {
            Hamburgueria CadastraCliente = new Hamburgueria();
            CadastraCliente.Show();
            this.Hide();

        }

        private void btnCadastrarItens_Click(object sender, EventArgs e)
        {
            CadastroItem item = new CadastroItem();
            item.Show();
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
