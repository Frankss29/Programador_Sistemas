namespace PrimeiroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nome = textNome.Text; //Pega o nome digitado na textBox

            if (nome == "SENAC")
            {
                Mensagem.Text = "Aprovado";
            }
            else
            {
                Mensagem.Text = "Reprovado";
            }

        }
    }
}
