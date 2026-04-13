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

namespace Aula9
{
    public partial class CadastrarProdutos : Form
    {
        string conexao = "server=localhost;user=root;password=;database=LojaInformatica";
        public CadastrarProdutos()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();
                string sql = "INSERT INTO Produtos(Nome, Categoria, Preco,Estoque) VALUES(@nome, @categoria,@preco,@estoque)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
                cmd.Parameters.AddWithValue("@preco", txtPreco.Text);
                cmd.Parameters.AddWithValue("@estoque", txtEstoque.Text);

                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("O seu cadastro foi realizado com sucesso");

            }
            catch (Exception ex) {/*MessageBox.Show(ex.Message);*/ }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();

        }
    }
}
