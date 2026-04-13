namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoginCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro telaCadastro = new Cadastro();
            telaCadastro.Show();
            this.Hide();

        }



        //EFEITOS DO BOTÃO

        private void btnLoginCadastrar_MouseEnter(object sender, EventArgs e)
        {
            btnLoginCadastrar.BackColor = Color.SlateBlue;
        }

        private void btnLoginCadastrar_MouseLeave(object sender, EventArgs e)
        {
            btnLoginCadastrar.BackColor = Color.DarkSlateBlue;
        }

        private void btnLoginEntrar_MouseEnter(object sender, EventArgs e)
        {
            btnLoginEntrar.BackColor = Color.SlateBlue;
        }

        private void btnLoginEntrar_MouseLeave(object sender, EventArgs e)
        {
            btnLoginEntrar.BackColor = Color.DarkSlateBlue;

        }

        private void btnLoginEntrar_Click(object sender, EventArgs e)
        {
            int i;
            bool encontrado = false;
            
            for (i = 0; i < Repositorio.usuarioCadastrado.Count; i++)
            {

                Usuarios u = Repositorio.usuarioCadastrado[i];

                if (u.Nome == txtLoginUsuario.Text && u.Senha == txtLoginSenha.Text)
                {
                    encontrado = true;
                }
            }

            if (encontrado == true) 
            {
                MessageBox.Show("Login Efetuado com Sucesso");
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado");
            }

        }
    }
}
