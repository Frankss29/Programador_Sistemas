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
    public partial class RedefinirSenha : Form
    {
        string conexao = "server=localhost; user=root;password=; database = sistema_aluno";
        public RedefinirSenha()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "UPDATE usuarios SET senha =@senha WHERE nome=@nome";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@senha",txtSenhaRedefinir.Text);
                cmd.Parameters.AddWithValue("@nome",txtUsuarioRedefinirSenha.Text);

                //Retorna um número inteiro (int) que indica:
                //QUANTAS LINHAS FORAM AFETADAS pelo comando SQL
                int linhas = cmd.ExecuteNonQuery();


                if (linhas > 0)
                {
                    MessageBox.Show("Senha redefinida com sucesso");
                }
                else
                {
                    MessageBox.Show("Usuario não encontrado");
                }
                
                

            }
            catch (Exception ex) { }
           
        }
    }
}
