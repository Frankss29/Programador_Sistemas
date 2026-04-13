namespace RadioButton02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void rbAmarelo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmarelo.Checked)
            {
                NomeCor.Text = rbAmarelo.Text;
                NomeCor.BackColor = Color.Yellow;// Mudar cor de fundo da label
                //NomeCor.ForeColor = Color.Yellow;// Mudar cor do texto
            }


        }

        private void rbAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAzul.Checked)
            {
                NomeCor.Text = rbAzul.Text;
                NomeCor.BackColor = Color.DodgerBlue;// Mudar cor de fundo da label
               //NomeCor.ForeColor = Color.Blue;// Mudar cor do tex
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
