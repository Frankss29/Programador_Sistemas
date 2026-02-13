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

        private void textAnoUltimoAniversario_Enter(object sender, EventArgs e)
        {
            if (textAnoNascimento.Text.Trim().Length < 4)
            {

                MessageBox.Show("É preciso informar o Ano de Nascimento");
                textAnoNascimento.Focus();

            }

        }

        private void textAnoUltimoAniversario_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textAnoUltimoAniversario.Text != String.Empty &&
                Convert.ToInt32(textAnoUltimoAniversario.Text) <= 
                Convert.ToInt32(textAnoNascimento.Text))
            {
                MessageBox.Show("O Ano do último aniversário dever ser maior ao ano do nascimento");
            }
        }
    }
}
