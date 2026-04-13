namespace Hamburgueria
{
    partial class Relatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relatorio));
            dgvRelatorio = new DataGridView();
            lbMarcarCCliente = new Label();
            panel1 = new Panel();
            imgLogoCCliente = new PictureBox();
            pnlSeparador = new Panel();
            btnFazerPedido = new Button();
            btnCadastrarItens = new Button();
            lbCadastro = new Label();
            btnCadastrarClientesRelatorio = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoCCliente).BeginInit();
            SuspendLayout();
            // 
            // dgvRelatorio
            // 
            dgvRelatorio.BackgroundColor = Color.White;
            dgvRelatorio.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRelatorio.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRelatorio.ColumnHeadersHeight = 40;
            dgvRelatorio.EnableHeadersVisualStyles = false;
            dgvRelatorio.Location = new Point(26, 203);
            dgvRelatorio.Name = "dgvRelatorio";
            dgvRelatorio.RowHeadersVisible = false;
            dgvRelatorio.Size = new Size(393, 278);
            dgvRelatorio.TabIndex = 0;
            // 
            // lbMarcarCCliente
            // 
            lbMarcarCCliente.AutoSize = true;
            lbMarcarCCliente.BackColor = SystemColors.ActiveCaptionText;
            lbMarcarCCliente.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMarcarCCliente.ForeColor = Color.White;
            lbMarcarCCliente.Location = new Point(156, 21);
            lbMarcarCCliente.Name = "lbMarcarCCliente";
            lbMarcarCCliente.Size = new Size(166, 35);
            lbMarcarCCliente.TabIndex = 17;
            lbMarcarCCliente.Text = "Burger Dog";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(-4, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 2);
            panel1.TabIndex = 16;
            // 
            // imgLogoCCliente
            // 
            imgLogoCCliente.Image = (Image)resources.GetObject("imgLogoCCliente.Image");
            imgLogoCCliente.Location = new Point(-4, -13);
            imgLogoCCliente.Name = "imgLogoCCliente";
            imgLogoCCliente.Size = new Size(86, 90);
            imgLogoCCliente.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoCCliente.TabIndex = 15;
            imgLogoCCliente.TabStop = false;
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.White;
            pnlSeparador.Location = new Point(-4, 126);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(548, 2);
            pnlSeparador.TabIndex = 14;
            // 
            // btnFazerPedido
            // 
            btnFazerPedido.FlatAppearance.BorderSize = 0;
            btnFazerPedido.FlatStyle = FlatStyle.Flat;
            btnFazerPedido.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnFazerPedido.ForeColor = Color.White;
            btnFazerPedido.Location = new Point(305, 79);
            btnFazerPedido.Name = "btnFazerPedido";
            btnFazerPedido.Size = new Size(139, 44);
            btnFazerPedido.TabIndex = 13;
            btnFazerPedido.Text = "Fazer Pedidos";
            btnFazerPedido.UseVisualStyleBackColor = true;
            btnFazerPedido.Click += btnFazerPedido_Click;
            // 
            // btnCadastrarItens
            // 
            btnCadastrarItens.FlatAppearance.BorderSize = 0;
            btnCadastrarItens.FlatStyle = FlatStyle.Flat;
            btnCadastrarItens.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnCadastrarItens.ForeColor = Color.White;
            btnCadastrarItens.Location = new Point(156, 79);
            btnCadastrarItens.Name = "btnCadastrarItens";
            btnCadastrarItens.Size = new Size(143, 44);
            btnCadastrarItens.TabIndex = 12;
            btnCadastrarItens.Text = "Cadastrar Itens";
            btnCadastrarItens.UseVisualStyleBackColor = true;
            btnCadastrarItens.Click += btnCadastrarItens_Click;
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.BackColor = SystemColors.ActiveCaptionText;
            lbCadastro.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastro.ForeColor = Color.White;
            lbCadastro.Location = new Point(176, 150);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(103, 25);
            lbCadastro.TabIndex = 11;
            lbCadastro.Text = "Relatórios";
            // 
            // btnCadastrarClientesRelatorio
            // 
            btnCadastrarClientesRelatorio.FlatAppearance.BorderSize = 0;
            btnCadastrarClientesRelatorio.FlatStyle = FlatStyle.Flat;
            btnCadastrarClientesRelatorio.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnCadastrarClientesRelatorio.ForeColor = Color.White;
            btnCadastrarClientesRelatorio.Location = new Point(3, 79);
            btnCadastrarClientesRelatorio.Name = "btnCadastrarClientesRelatorio";
            btnCadastrarClientesRelatorio.Size = new Size(147, 44);
            btnCadastrarClientesRelatorio.TabIndex = 18;
            btnCadastrarClientesRelatorio.Text = "Cadastrar Clientes";
            btnCadastrarClientesRelatorio.UseVisualStyleBackColor = true;
            btnCadastrarClientesRelatorio.Click += btnCadastrarClientesRelatorio_Click;
            // 
            // Relatorio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(446, 509);
            Controls.Add(btnCadastrarClientesRelatorio);
            Controls.Add(lbMarcarCCliente);
            Controls.Add(panel1);
            Controls.Add(imgLogoCCliente);
            Controls.Add(pnlSeparador);
            Controls.Add(btnFazerPedido);
            Controls.Add(btnCadastrarItens);
            Controls.Add(lbCadastro);
            Controls.Add(dgvRelatorio);
            Name = "Relatorio";
            Text = "Relatorio";
            Load += Relatorio_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRelatorio).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoCCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRelatorio;
        private Label lbMarcarCCliente;
        private Panel panel1;
        private PictureBox imgLogoCCliente;
        private Panel pnlSeparador;
        private Button btnFazerPedido;
        private Button btnCadastrarItens;
        private Label lbCadastro;
        private Button btnCadastrarClientesRelatorio;
    }
}