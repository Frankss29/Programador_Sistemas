using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroLogin_Click(object sender, EventArgs e)
        {


            Form1 telaLogin = new Form1();
            telaLogin.Show();
            this.Close();

        }

        private void btnCadastroSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCadastroNome.Text) ||
                string.IsNullOrWhiteSpace(txtCadastroSenha.Text))
            {
                MessageBox.Show("Por favor, preencha os campos");
                return;
            }
           //Cadastra o usuario na Classe Usuario
           Usuarios novoUsuario = new Usuarios();
           novoUsuario.Nome = txtCadastroNome.Text;
           novoUsuario.Senha = txtCadastroSenha.Text;
           
           //Guardar usuario no repositorio "Banco de dados"
           Repositorio.usuarioCadastrado.Add(novoUsuario);

           MessageBox.Show("Usuário Cadastrado com Sucesso");
        }






        //EFEITOS DO BOTÃO

        private void btnCadastroSalvar_MouseEnter(object sender, EventArgs e)
        {
            btnCadastroSalvar.BackColor = Color.SlateBlue;
        }

        private void btnCadastroSalvar_MouseLeave(object sender, EventArgs e)
        {
            btnCadastroSalvar.BackColor = Color.DarkSlateBlue;
        }

        private void btnCadastroLogin_MouseEnter(object sender, EventArgs e)
        {
            btnCadastroLogin.BackColor = Color.SlateBlue;
        }

        private void btnCadastroLogin_MouseLeave(object sender, EventArgs e)
        {
            btnCadastroLogin.BackColor = Color.DarkSlateBlue;
        }
    }
}
