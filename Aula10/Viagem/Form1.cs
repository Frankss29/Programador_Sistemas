namespace Viagem
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

        private void button1_Click(object sender, EventArgs e)
        {
            double D1, Calc;

            D1 = Convert.ToDouble(textDistancia.Text);

            if (D1 <= 200)
            {
                Calc = D1 * 0.50;
                
            }
            else
            {
                Calc = D1 * 0.45;
                
            }

            textPreco.Text = Calc.ToString();

        }

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            btn1.BackColor = Color.SkyBlue;
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            btn1.BackColor= SystemColors.Window;
        }
    }
}
