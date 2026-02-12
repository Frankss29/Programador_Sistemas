namespace Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double c, l, a, v;

            c = Convert.ToDouble(txtComprimento.Text);
            l = Convert.ToDouble(txtLargura.Text);
            a = Convert.ToDouble(txtAltura.Text);

            v = c * l * a;

            txtVolume.Text = v.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
