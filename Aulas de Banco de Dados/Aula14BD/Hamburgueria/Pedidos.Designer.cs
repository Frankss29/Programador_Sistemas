namespace Hamburgueria
{
    partial class Pedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            lbMarcarCCliente = new Label();
            panel1 = new Panel();
            imgLogoCCliente = new PictureBox();
            pnlSeparador = new Panel();
            btnCadastarItensPedido = new Button();
            btnCadastrarClientePedido = new Button();
            cbClientes = new ComboBox();
            cbItens = new ComboBox();
            numQuantidade = new NumericUpDown();
            btnSalvarPedidos = new Button();
            btnRelatorio = new Button();
            lbFazerPedidos = new Label();
            ((System.ComponentModel.ISupportInitialize)imgLogoCCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // lbMarcarCCliente
            // 
            lbMarcarCCliente.AutoSize = true;
            lbMarcarCCliente.BackColor = SystemColors.ActiveCaptionText;
            lbMarcarCCliente.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMarcarCCliente.ForeColor = Color.White;
            lbMarcarCCliente.Location = new Point(162, 21);
            lbMarcarCCliente.Name = "lbMarcarCCliente";
            lbMarcarCCliente.Size = new Size(166, 35);
            lbMarcarCCliente.TabIndex = 16;
            lbMarcarCCliente.Text = "Burger Dog";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(2, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 2);
            panel1.TabIndex = 15;
            // 
            // imgLogoCCliente
            // 
            imgLogoCCliente.Image = (Image)resources.GetObject("imgLogoCCliente.Image");
            imgLogoCCliente.Location = new Point(2, -13);
            imgLogoCCliente.Name = "imgLogoCCliente";
            imgLogoCCliente.Size = new Size(86, 90);
            imgLogoCCliente.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoCCliente.TabIndex = 14;
            imgLogoCCliente.TabStop = false;
            imgLogoCCliente.Click += imgLogoCCliente_Click;
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.White;
            pnlSeparador.Location = new Point(2, 126);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(548, 2);
            pnlSeparador.TabIndex = 13;
            // 
            // btnCadastarItensPedido
            // 
            btnCadastarItensPedido.FlatAppearance.BorderSize = 0;
            btnCadastarItensPedido.FlatStyle = FlatStyle.Flat;
            btnCadastarItensPedido.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnCadastarItensPedido.ForeColor = Color.White;
            btnCadastarItensPedido.Location = new Point(235, 79);
            btnCadastarItensPedido.Name = "btnCadastarItensPedido";
            btnCadastarItensPedido.Size = new Size(203, 44);
            btnCadastarItensPedido.TabIndex = 12;
            btnCadastarItensPedido.Text = "Cadastrar Itens";
            btnCadastarItensPedido.UseVisualStyleBackColor = true;
            btnCadastarItensPedido.Click += btnCadastarItensPedido_Click;
            // 
            // btnCadastrarClientePedido
            // 
            btnCadastrarClientePedido.FlatAppearance.BorderSize = 0;
            btnCadastrarClientePedido.FlatStyle = FlatStyle.Flat;
            btnCadastrarClientePedido.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnCadastrarClientePedido.ForeColor = Color.White;
            btnCadastrarClientePedido.Location = new Point(2, 79);
            btnCadastrarClientePedido.Name = "btnCadastrarClientePedido";
            btnCadastrarClientePedido.Size = new Size(227, 44);
            btnCadastrarClientePedido.TabIndex = 11;
            btnCadastrarClientePedido.Text = "Cadastrar Clientes";
            btnCadastrarClientePedido.UseVisualStyleBackColor = true;
            btnCadastrarClientePedido.Click += btnCadastrarClientePedido_Click;
            // 
            // cbClientes
            // 
            cbClientes.FormattingEnabled = true;
            cbClientes.Location = new Point(43, 223);
            cbClientes.Name = "cbClientes";
            cbClientes.Size = new Size(167, 23);
            cbClientes.TabIndex = 17;
            // 
            // cbItens
            // 
            cbItens.FormattingEnabled = true;
            cbItens.Location = new Point(237, 223);
            cbItens.Name = "cbItens";
            cbItens.Size = new Size(167, 23);
            cbItens.TabIndex = 18;
            // 
            // numQuantidade
            // 
            numQuantidade.Location = new Point(43, 281);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(120, 23);
            numQuantidade.TabIndex = 19;
            // 
            // btnSalvarPedidos
            // 
            btnSalvarPedidos.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarPedidos.Location = new Point(43, 340);
            btnSalvarPedidos.Name = "btnSalvarPedidos";
            btnSalvarPedidos.Size = new Size(167, 27);
            btnSalvarPedidos.TabIndex = 20;
            btnSalvarPedidos.Text = "Salvar";
            btnSalvarPedidos.UseVisualStyleBackColor = true;
            btnSalvarPedidos.Click += btnSalvarPedidos_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRelatorio.Location = new Point(237, 340);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(167, 27);
            btnRelatorio.TabIndex = 21;
            btnRelatorio.Text = "Relatórios";
            btnRelatorio.UseVisualStyleBackColor = true;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // lbFazerPedidos
            // 
            lbFazerPedidos.AutoSize = true;
            lbFazerPedidos.BackColor = SystemColors.ActiveCaptionText;
            lbFazerPedidos.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFazerPedidos.ForeColor = Color.White;
            lbFazerPedidos.Location = new Point(162, 162);
            lbFazerPedidos.Name = "lbFazerPedidos";
            lbFazerPedidos.Size = new Size(140, 25);
            lbFazerPedidos.TabIndex = 22;
            lbFazerPedidos.Text = "Fazer Pedidos";
            // 
            // Pedidos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(446, 509);
            Controls.Add(lbFazerPedidos);
            Controls.Add(btnRelatorio);
            Controls.Add(btnSalvarPedidos);
            Controls.Add(numQuantidade);
            Controls.Add(cbItens);
            Controls.Add(cbClientes);
            Controls.Add(lbMarcarCCliente);
            Controls.Add(panel1);
            Controls.Add(imgLogoCCliente);
            Controls.Add(pnlSeparador);
            Controls.Add(btnCadastarItensPedido);
            Controls.Add(btnCadastrarClientePedido);
            Name = "Pedidos";
            Text = "Pedidos";
            Load += Pedidos_Load;
            ((System.ComponentModel.ISupportInitialize)imgLogoCCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMarcarCCliente;
        private Panel panel1;
        private PictureBox imgLogoCCliente;
        private Panel pnlSeparador;
        private Button btnCadastarItensPedido;
        private Button btnCadastrarClientePedido;
        private ComboBox cbClientes;
        private ComboBox cbItens;
        private NumericUpDown numQuantidade;
        private Button btnSalvarPedidos;
        private Button btnRelatorio;
        private Label lbFazerPedidos;
    }
}