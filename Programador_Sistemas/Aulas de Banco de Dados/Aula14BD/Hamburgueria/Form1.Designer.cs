namespace Hamburgueria
{
    partial class Hamburgueria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hamburgueria));
            lbCadastro = new Label();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            btnSalvar = new Button();
            btnCadastrarItens = new Button();
            btnFazerPedido = new Button();
            dgvClientes = new DataGridView();
            pnlSeparador = new Panel();
            imgLogoCCliente = new PictureBox();
            panel1 = new Panel();
            lbMarcarCCliente = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoCCliente).BeginInit();
            SuspendLayout();
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.BackColor = SystemColors.ActiveCaptionText;
            lbCadastro.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastro.ForeColor = Color.White;
            lbCadastro.Location = new Point(182, 147);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(95, 25);
            lbCadastro.TabIndex = 0;
            lbCadastro.Text = "Cadastro";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(45, 192);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(169, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(235, 192);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF";
            txtCPF.Size = new Size(168, 23);
            txtCPF.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(47, 231);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 27);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCadastrarItens
            // 
            btnCadastrarItens.FlatAppearance.BorderSize = 0;
            btnCadastrarItens.FlatStyle = FlatStyle.Flat;
            btnCadastrarItens.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnCadastrarItens.ForeColor = Color.White;
            btnCadastrarItens.Location = new Point(2, 76);
            btnCadastrarItens.Name = "btnCadastrarItens";
            btnCadastrarItens.Size = new Size(227, 44);
            btnCadastrarItens.TabIndex = 4;
            btnCadastrarItens.Text = "Cadastrar Itens";
            btnCadastrarItens.UseVisualStyleBackColor = true;
            btnCadastrarItens.Click += btnCadastrarItens_Click;
            // 
            // btnFazerPedido
            // 
            btnFazerPedido.FlatAppearance.BorderSize = 0;
            btnFazerPedido.FlatStyle = FlatStyle.Flat;
            btnFazerPedido.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnFazerPedido.ForeColor = Color.White;
            btnFazerPedido.Location = new Point(237, 75);
            btnFazerPedido.Name = "btnFazerPedido";
            btnFazerPedido.Size = new Size(203, 44);
            btnFazerPedido.TabIndex = 5;
            btnFazerPedido.Text = "Fazer Pedidos";
            btnFazerPedido.UseVisualStyleBackColor = true;
            btnFazerPedido.Click += btnFazerPedido_Click;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.White;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeight = 40;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Location = new Point(47, 277);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(356, 191);
            dgvClientes.TabIndex = 6;
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.White;
            pnlSeparador.Location = new Point(2, 123);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(548, 2);
            pnlSeparador.TabIndex = 7;
            // 
            // imgLogoCCliente
            // 
            imgLogoCCliente.Image = (Image)resources.GetObject("imgLogoCCliente.Image");
            imgLogoCCliente.Location = new Point(2, -16);
            imgLogoCCliente.Name = "imgLogoCCliente";
            imgLogoCCliente.Size = new Size(86, 90);
            imgLogoCCliente.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoCCliente.TabIndex = 8;
            imgLogoCCliente.TabStop = false;
            imgLogoCCliente.Click += imgLogoCCliente_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(2, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 2);
            panel1.TabIndex = 9;
            // 
            // lbMarcarCCliente
            // 
            lbMarcarCCliente.AutoSize = true;
            lbMarcarCCliente.BackColor = SystemColors.ActiveCaptionText;
            lbMarcarCCliente.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMarcarCCliente.ForeColor = Color.White;
            lbMarcarCCliente.Location = new Point(162, 18);
            lbMarcarCCliente.Name = "lbMarcarCCliente";
            lbMarcarCCliente.Size = new Size(166, 35);
            lbMarcarCCliente.TabIndex = 10;
            lbMarcarCCliente.Text = "Burger Dog";
            // 
            // Hamburgueria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(446, 509);
            Controls.Add(lbMarcarCCliente);
            Controls.Add(panel1);
            Controls.Add(imgLogoCCliente);
            Controls.Add(pnlSeparador);
            Controls.Add(dgvClientes);
            Controls.Add(btnFazerPedido);
            Controls.Add(btnCadastrarItens);
            Controls.Add(btnSalvar);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(lbCadastro);
            Name = "Hamburgueria";
            Text = "Hamburgueria";
            Load += Hamburgueria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogoCCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCadastro;
        private TextBox txtNome;
        private TextBox txtCPF;
        private Button btnSalvar;
        private Button btnCadastrarItens;
        private Button btnFazerPedido;
        private DataGridView dgvClientes;
        private Panel pnlSeparador;
        private PictureBox imgLogoCCliente;
        private Panel panel1;
        private Label lbMarcarCCliente;
    }
}
