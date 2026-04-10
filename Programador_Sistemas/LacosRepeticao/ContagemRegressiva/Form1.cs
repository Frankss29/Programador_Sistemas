namespace ContagemRegressiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 10; i > -1; i--)
            {
                listBox1.Items.Add(i);
            }

            listBox1.Items.Add("Fogos");
        }
    }
}
