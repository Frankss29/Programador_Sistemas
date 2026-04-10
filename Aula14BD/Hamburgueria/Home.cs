using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburgueria
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnCadastrarClienteHome_Click(object sender, EventArgs e)
        {
            Hamburgueria CadastraCliente = new Hamburgueria();
            CadastraCliente.Show();
            this.Hide();
        }

        private void btnCadastrarItensHome_Click(object sender, EventArgs e)
        {
            CadastroItem CadastraItens = new CadastroItem();
            CadastraItens.Show();
            this.Hide();
        }

        private void btnFazerPedidoHome_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
            this.Hide();
        }
    }
}
