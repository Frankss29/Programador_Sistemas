using MySql.Data.MySqlClient;

namespace SistemaCadastro
{
    public partial class TelaCadastro : Form
    {
        string conexao = "server=localhost; user=root;password=; database = sistema_aluno";
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                con.Open();
                string sql = "INSERT INTO usuarios(nome, senha) VALUES (@nome, @senha);";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", txtNomeCadastro.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenhaCadastro.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado");
                con.Close();


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            RedefinirSenha redefinirSenha = new RedefinirSenha();
            redefinirSenha.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           Login logar = new Login();
            logar.Show();
        }
    }
}
