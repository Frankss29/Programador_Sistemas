namespace Temperatura
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

        private void button1_Click(object sender, EventArgs e)
        {
            double c, f;

            c = Convert.ToDouble(textCelsius.Text);
         
            f = (c * 9 / 5) + 32;

            textFahrenheit.Text = f.ToString();


        }
    }
}
