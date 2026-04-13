using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Contar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            { 
                listBox1.Items.Add(i);
            }
        }
    }
}
