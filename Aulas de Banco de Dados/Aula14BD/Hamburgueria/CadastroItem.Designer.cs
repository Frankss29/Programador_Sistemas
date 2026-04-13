namespace Hamburgueria
{
    partial class CadastroItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroItem));
            lbMarcarCItens = new Label();
            panel1 = new Panel();
            imgLogoCItens = new PictureBox();
            pnlSeparador = new Panel();
            btnFazerPedido = new Button();
            btnCadastrarCliente = new Button();
            btnSalvarCItens = new Button();
            txtPreco = new TextBox();
            txtNomeProduto = new TextBox();
            lbCadastroItens = new Label();
            ((System.ComponentModel.ISupportInitialize)imgLogoCItens).BeginInit();
            SuspendLayout();
            // 
            // lbMarcarCItens
            // 
            lbMarcarCItens.AutoSize = true;
            lbMarcarCItens.BackColor = SystemColors.ActiveCaptionText;
            lbMarcarCItens.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMarcarCItens.ForeColor = Color.White;
            lbMarcarCItens.Location = new Point(158, 33);
            lbMarcarCItens.Name = "lbMarcarCItens";
            lbMarcarCItens.Size = new Size(166, 35);
            lbMarcarCItens.TabIndex = 20;
            lbMarcarCItens.Text = "Burger Dog";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(-2, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 2);
            panel1.TabIndex = 19;
            // 
            // imgLogoCItens
            // 
            imgLogoCItens.Image = (Image)resources.GetObject("imgLogoCItens.Image");
            imgLogoCItens.Location = new Point(-2, -1);
            imgLogoCItens.Name = "imgLogoCItens";
            imgLogoCItens.Size = new Size(86, 90);
            imgLogoCItens.SizeMode = PictureBoxSizeMode.Zoom;
            imgLogoCItens.TabIndex = 18;
            imgLogoCItens.TabStop = false;
            imgLogoCItens.Click += imgLogoCItens_Click;
            // 
            // pnlSeparador
            // 
            pnlSeparador.BackColor = Color.White;
            pnlSeparador.Location = new Point(-2, 138);
            pnlSeparador.Name = "pnlSeparador";
            pnlSeparador.Size = new Size(548, 2);
            pnlSeparador.TabIndex = 17;
            // 
            // btnFazerPedido
            // 
            btnFazerPedido.FlatAppearance.BorderSize = 0;
            btnFazerPedido.FlatStyle = FlatStyle.Flat;
            btnFazerPedido.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnFazerPedido.ForeColor = Color.White;
            btnFazerPedido.Location = new Point(233, 91);
            btnFazerPedido.Name = "btnFazerPedido";
            btnFazerPedido.Size = new Size(203, 44);
            btnFazerPedido.TabIndex = 16;
            btnFazerPedido.Text = "Fazer Pedidos";
            btnFazerPedido.UseVisualStyleBackColor = true;
            btnFazerPedido.Click += btnFazerPedido_Click;
            // 
            // btnCadastrarCliente
            // 
            btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            btnCadastrarCliente.FlatStyle = FlatStyle.Flat;
            btnCadastrarCliente.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnCadastrarCliente.ForeColor = Color.White;
            btnCadastrarCliente.Location = new Point(-2, 91);
            btnCadastrarCliente.Name = "btnCadastrarCliente";
            btnCadastrarCliente.Size = new Size(227, 44);
            btnCadastrarCliente.TabIndex = 15;
            btnCadastrarCliente.Text = "Cadastrar Cliente";
            btnCadastrarCliente.UseVisualStyleBackColor = true;
            btnCadastrarCliente.Click += btnCadastrarCliente_Click;
            // 
            // btnSalvarCItens
            // 
            btnSalvarCItens.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvarCItens.Location = new Point(43, 297);
            btnSalvarCItens.Name = "btnSalvarCItens";
            btnSalvarCItens.Size = new Size(112, 27);
            btnSalvarCItens.TabIndex = 14;
            btnSalvarCItens.Text = "Salvar";
            btnSalvarCItens.UseVisualStyleBackColor = true;
            btnSalvarCItens.Click += btnSalvarCItens_Click;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(231, 258);
            txtPreco.Name = "txtPreco";
            txtPreco.PlaceholderText = "Preço";
            txtPreco.Size = new Size(168, 23);
            txtPreco.TabIndex = 13;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(41, 258);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.PlaceholderText = "Nome";
            txtNomeProduto.Size = new Size(169, 23);
            txtNomeProduto.TabIndex = 12;
            // 
            // lbCadastroItens
            // 
            lbCadastroItens.AutoSize = true;
            lbCadastroItens.BackColor = SystemColors.ActiveCaptionText;
            lbCadastroItens.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastroItens.ForeColor = Color.White;
            lbCadastroItens.Location = new Point(141, 211);
            lbCadastroItens.Name = "lbCadastroItens";
            lbCadastroItens.Size = new Size(174, 25);
            lbCadastroItens.TabIndex = 11;
            lbCadastroItens.Text = "Cadastro de Itens";
            // 
            // CadastroItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(446, 509);
            Controls.Add(lbMarcarCItens);
            Controls.Add(panel1);
            Controls.Add(imgLogoCItens);
            Controls.Add(pnlSeparador);
            Controls.Add(btnFazerPedido);
            Controls.Add(btnCadastrarCliente);
            Controls.Add(btnSalvarCItens);
            Controls.Add(txtPreco);
            Controls.Add(txtNomeProduto);
            Controls.Add(lbCadastroItens);
            Name = "CadastroItem";
            Text = "Itens";
            ((System.ComponentModel.ISupportInitialize)imgLogoCItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMarcarCItens;
        private Panel panel1;
        private PictureBox imgLogoCItens;
        private Panel pnlSeparador;
        private Button btnFazerPedido;
        private Button btnCadastrarCliente;
        private Button btnSalvarCItens;
        private TextBox txtPreco;
        private TextBox txtNomeProduto;
        private Label lbCadastroItens;
    }
}