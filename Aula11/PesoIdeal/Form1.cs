namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a, altura, peso;


        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            //MINHA VERSÃO 

            //if (rbMasculino.Checked && txtAltura.Text != "")
            //{
            //    a = Convert.ToDouble(txtAltura.Text);
            //    a = (72.7 * a) - 58;
            //    Peso.Text = a.ToString();
            //}

            //VERSÃO DO PROFESSOR
            PesoIdeal();

        }

        private void rbFeminino_CheckedChanged(object sender, EventArgs e)
        {
            //MINHA VERSÃO 

            //if (rbFeminino.Checked && txtAltura.Text !="")
            //{
            //    a = Convert.ToDouble(txtAltura.Text);
            //    a = (62.1 * a) - 44.7;
            //    Peso.Text = a.ToString();
            //}

            //VERSÃO DO PROFESSOR
            PesoIdeal();
        }


        //Opção Fazer Usando Método - VERSÃO DO PROFESSOR
        public void PesoIdeal()
        {
            if(string.IsNullOrWhiteSpace(txtAltura.Text))
            {
                Peso.Text = "";
                return;
            }

            //Entrada
            altura=Convert.ToDouble(txtAltura.Text);    

            //Processamento
            if(rbMasculino.Checked == false)
            {
                peso = (62.1 * altura) - 44.7;
            }
            else if(rbFeminino.Checked == false)
            {
                peso = (72.7 * altura) - 58;
            }
            
            Peso.Text = peso.ToString();

        }
    }
}
