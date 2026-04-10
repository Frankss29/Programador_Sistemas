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

namespace SistemaCadastro
{
    public partial class Login : Form
    {
        string conexao = "server=localhost; user=root;password=; database = sistema_aluno";
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrarLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM usuarios WHERE nome=@nome AND senha=@senha";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtUsuarioLogin.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenhaLogin.Text);

                //ExecuteScalar retorna a primeira coluna da primeira linha (o resultado do COUNT)
                int resultado = Convert.ToInt32(cmd.ExecuteScalar());

                if (resultado > 0)
                {
                    MessageBox.Show("Acesso Autorizado");
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos");
                }


            }
            catch (Exception ex) { }

        }

        private void lbCadastrarSeLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
