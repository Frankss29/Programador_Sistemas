namespace Alerta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esse é um Alerta simples", "Senac");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult resposta = MessageBox.Show("Vamos programar um sistema?",
                                                      "Título aqui",
                                                         MessageBoxButtons.YesNo);

            if (resposta == DialogResult.Yes)
            {
                MessageBox.Show("Respondeu que sim!");
            }
            else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Respondeu que não!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
