using MySql.Data.MySqlClient;
using System.Data;
namespace Aula_Curso
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {
            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();
            try
            {
                con.Open();
                string sqlSelecionar = "SELECT*FROM Cursos";
                MySqlDataAdapter adp = new MySqlDataAdapter(sqlSelecionar, con);

                DataTable dt = new DataTable();
                adp.Fill(dt);
                cbCurso.DataSource = dt;
                cbCurso.DisplayMember = "nome";
                cbCurso.ValueMember = "id_curso";

            }
            catch (Exception ex) { }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id_curso = Convert.ToInt32(cbCurso.SelectedValue);

            Conexao conexao = new Conexao();
            MySqlConnection con = conexao.Conectar();

            try
            {
                con.Open();
                string sqlInserir = "INSERT INTO Alunos(nomeAluno,email,id_curso) VALUES (@nome,@email,@id_curso)";
                MySqlCommand cmd = new MySqlCommand(sqlInserir, con);
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id_curso",id_curso);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Aluno Cadastrado com Sucesso !!");

                string sqlMostrar = "SELECT*FROM Alunos";
                MySqlDataAdapter adp = new MySqlDataAdapter(sqlMostrar, con);
                DataTable dtt = new DataTable();
                adp.Fill(dtt);

                dgvAlunos.DataSource = dtt;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
