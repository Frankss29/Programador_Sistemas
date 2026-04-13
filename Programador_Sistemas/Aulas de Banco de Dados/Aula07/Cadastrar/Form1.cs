using MySql.Data.MySqlClient;

namespace Cadastrar
{
    public partial class TelaCadastro : Form
    {
        //Criando endereço da conexao
        string conexao = "server=localhost; user=root;password=;" +
            " database = bd_EscolaParticular";
        int idGerado;

        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void btnSalvarGBaluno_Click(object sender, EventArgs e)
        {
            

            //Tornando a conexao real(instaciando)
            MySqlConnection con = new MySqlConnection(conexao);

            try
            {
                //Abrir banco
                con.Open();
                //Inserindo  valores  na Tabela do SQL
                string sql = "INSERT INTO Aluno(nome, email)" +
                    " Values (@nome, @email); SELECT LAST_INSERT_ID()";


                //Aqui o comando vai colocar/fazer algo dentro do banco
                MySqlCommand cmd = new MySqlCommand(sql, con);
                //Pega o texto digitado no formulário Coloca esses valores nos parâmetros do SQL 
                cmd.Parameters.AddWithValue("@nome", txtNomeGBaluno.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);


                //1. O banco devolve o ID
                idGerado = Convert.ToInt32(cmd.ExecuteScalar());
                txtIDAlunoFinanceiro.Text = idGerado.ToString();
                txtNomeGBfinanceiro.Text = txtNomeGBaluno.Text;

                con.Close();
                MessageBox.Show("O seu cadastro foi realizado com sucesso");
                
                

            }
            catch (Exception ex) { }

        }

        private void btnSalvarGBfinanceiro_Click(object sender, EventArgs e)
        {

            MySqlConnection con = new MySqlConnection(conexao);
            try
            {
                con.Open();
                string sql = "INSERT INTO Renda(renda_familiar, observacoes, fk_aluno) " +
                    " Values (@renda_familiar, @observacoes, @id)";
                
                MySqlCommand cmd = new MySqlCommand( sql, con);

                cmd.Parameters.AddWithValue("@renda_familiar", txtRendaFinanceiro.Text);
                cmd.Parameters.AddWithValue("@observacoes", rtxtObservacaoFinanceiro.Text);
                cmd.Parameters.AddWithValue("@id", idGerado);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro completo");
            }
            catch (Exception ex) { }
        }
    }
}
