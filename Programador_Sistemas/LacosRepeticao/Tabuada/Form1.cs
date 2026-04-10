namespace Tabuada
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
            
            for (int i = 0; i <= 10; i++)
            {
                int resultado = numero * i;
                listBox1.Items.Add(numero + " x " + i + " = " + resultado);
                textBox1.Clear();
                textBox1.Focus();

            }

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
