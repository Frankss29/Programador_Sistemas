namespace Contagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 50; i <= 100; i++)
            {
                listBox1.Items.Add(i);
            }
        }
    }
}
