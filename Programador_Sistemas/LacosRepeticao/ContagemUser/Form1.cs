namespace ContagemUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);

            for (int i = 1; i <= numero; i++)
            {
               
                listBox1.Items.Add(i);
                textBox1.Clear();
                textBox1.Focus();

            }


        }
    }
}
