namespace TrocarValores
{
    public partial class frmTrocaDeValores : Form
    {
        public frmTrocaDeValores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            (txtPrimeiroValor.Text, txtSegundoValor.Text) =
            (txtSegundoValor.Text, txtPrimeiroValor.Text);

            MessageBox.Show("Troca de Valores Concluída",
                            "Informação", MessageBoxButtons.OK,
                             MessageBoxIcon.Information );

        }

        private void txtSegundoValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
