namespace RadioButton01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(rbMasculino.Checked)
            {
                MessageBox.Show("Masculino foi selecionado");
            }

            else if (rbFeminino.Checked)
            {
                MessageBox.Show("Feminino foi selecionado");
            }
            else 
            {
                MessageBox.Show("Outros foi selecionado");
            }
        }
    }
}
