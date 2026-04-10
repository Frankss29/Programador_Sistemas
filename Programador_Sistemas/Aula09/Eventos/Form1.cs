namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Olá Mundo!");
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {

        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            btn2.BackColor = Color.Red;
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            btn2.BackColor = SystemColors.Window;
        }
    }
}
