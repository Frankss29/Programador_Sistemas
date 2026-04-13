namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Nome";
            dataGridView1.Columns[1].Name = "Profissão";
            dataGridView1.Columns[2].Name = "CPF";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] cadastro = { txtNome.Text, txtProfissao.Text, txtCPF.Text }; //Pega o que esta escrito nas text box 
            dataGridView1.Rows.Add(cadastro); // Adiciona as informarções na tabela que criamos dentro do grid view

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomeProcurado = txtPesquisa.Text.Trim(); 
            bool encontrado = false;
            

            for(int i=0; i < dataGridView1.Rows.Count; i++)// contando as linhas "length" a pesquisa vai começar do ponto zero e vai até o quanto usuario cadastrou
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null )// Se valor da linha for  diferente de nulo/Vazio ele executa o segundo if
                { 

                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == nomeProcurado)
                {
                    dataGridView1.Rows[i].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    encontrado = true;
                }

                
                }

            }
        }
    }
}
