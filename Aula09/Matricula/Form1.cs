namespace Matricula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAniversario_Enter(object sender, EventArgs e)
        {
            if (txtNascimento.Text.Trim().Length < 4) //String.Empty é para vazio sem caracteres
            {
                MessageBox.Show("É preciso informar o ano");
                txtNascimento.Focus();
            }

        }

        private void txtAniversario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Convert.ToInt32(txtAniversario.Text) <=
                 Convert.ToInt32(txtNascimento.Text))
            {
                MessageBox.Show("O ano do Aniversário dever ser superior");
            }


        }

        private void btnIdentificarCategoria_Click(object sender, EventArgs e)
        {

            if(txtNome.Text == String.Empty || txtNascimento.Text == String.Empty || txtAniversario.Text == String.Empty)
            {
                MessageBox.Show("Preencha todos os campos");

            }
            else
            {
                int idade = Convert.ToInt32(txtAniversario.Text) -
                            Convert.ToInt32(txtNascimento.Text);

                if(idade > 17)
                {
                    txtCategoria.Text = "Adulto";
                }
                else if(idade >13)
                {
                    txtCategoria.Text = "Juvenil B";
                }
                else if (idade > 10)
                {
                    txtCategoria.Text = "Juvenil A";
                }
                else if (idade > 7)
                {
                    txtCategoria.Text = "Infantil B";
                }
                else if (idade >= 5 )
                {
                    txtCategoria.Text = "Infantil A";
                }
                else
                {
                    txtCategoria.Text = "Não Existe Categoria";
                }

            }




        }
    }
}
