namespace RestoDaDivisao
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dividendo, divisor, resto;

            dividendo=Convert.ToDouble(txtDividendo.Text);
            divisor = Convert.ToDouble(txtDivisor.Text);

            resto=dividendo % divisor;

             txtResto.Text = resto.ToString();

        }
    }
}
