using MySql.Data.MySqlClient;// SEM ELE NÃO CONSEGUIREMOS UTILIZAR AS FERRAMENTAS DO MYSQL E NEM SEUS COMANDOS COM CREATE E INSERT
namespace Cadastro
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Criando o endereço da conexão 
            string conexao = "server=localhost; user=root;password=; database = bd_escola";

            // Instaciamento o endereço
            MySqlConnection con= new MySqlConnection(conexao);


            //
            string sql = "INSERT INTO tb_alunos (nomes, idade)  Values (@nomes, @idade)";

            //Como se fosse um mensageiro uma especie de carteiro ele recebeu a informação
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nomes", txtNome.Text);
            cmd.Parameters.AddWithValue("@idade", txtIdade.Text);

            con.Open(); //Abrir o banco
            cmd.ExecuteNonQuery(); //executar o codigo
            con.Close(); //fechar o banco

            MessageBox.Show("Cadastro realizado com sucesso");


        }
    }
}
