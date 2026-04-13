namespace Hamburgueria
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnFazerPedidoHome = new Button();
            btnCadastrarClienteHome = new Button();
            btnCadastrarItensHome = new Button();
            lbMarcarCItens = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnFazerPedidoHome
            // 
            btnFazerPedidoHome.FlatStyle = FlatStyle.Flat;
            btnFazerPedidoHome.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnFazerPedidoHome.ForeColor = Color.White;
            btnFazerPedidoHome.Location = new Point(111, 217);
            btnFazerPedidoHome.Name = "btnFazerPedidoHome";
            btnFazerPedidoHome.Size = new Size(227, 44);
            btnFazerPedidoHome.TabIndex = 18;
            btnFazerPedidoHome.Text = "Fazer Pedidos";
            btnFazerPedidoHome.UseVisualStyleBackColor = true;
            btnFazerPedidoHome.Click += btnFazerPedidoHome_Click;
            // 
            // btnCadastrarClienteHome
            // 
            btnCadastrarClienteHome.FlatStyle = FlatStyle.Flat;
            btnCadastrarClienteHome.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnCadastrarClienteHome.ForeColor = Color.White;
            btnCadastrarClienteHome.Location = new Point(111, 90);
            btnCadastrarClienteHome.Name = "btnCadastrarClienteHome";
            btnCadastrarClienteHome.Size = new Size(227, 44);
            btnCadastrarClienteHome.TabIndex = 17;
            btnCadastrarClienteHome.Text = "Cadastrar Cliente";
            btnCadastrarClienteHome.UseVisualStyleBackColor = true;
            btnCadastrarClienteHome.Click += btnCadastrarClienteHome_Click;
            // 
            // btnCadastrarItensHome
            // 
            btnCadastrarItensHome.FlatStyle = FlatStyle.Flat;
            btnCadastrarItensHome.Font = new Font("Yu Gothic Medium", 9.75F, FontStyle.Bold);
            btnCadastrarItensHome.ForeColor = Color.White;
            btnCadastrarItensHome.Location = new Point(111, 151);
            btnCadastrarItensHome.Name = "btnCadastrarItensHome";
            btnCadastrarItensHome.Size = new Size(227, 44);
            btnCadastrarItensHome.TabIndex = 19;
            btnCadastrarItensHome.Text = "Cadastrar Itens";
            btnCadastrarItensHome.UseVisualStyleBackColor = true;
            btnCadastrarItensHome.Click += btnCadastrarItensHome_Click;
            // 
            // lbMarcarCItens
            // 
            lbMarcarCItens.AutoSize = true;
            lbMarcarCItens.BackColor = SystemColors.ActiveCaptionText;
            lbMarcarCItens.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMarcarCItens.ForeColor = Color.White;
            lbMarcarCItens.Location = new Point(141, 25);
            lbMarcarCItens.Name = "lbMarcarCItens";
            lbMarcarCItens.Size = new Size(166, 35);
            lbMarcarCItens.TabIndex = 21;
            lbMarcarCItens.Text = "Burger Dog";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 273);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(446, 509);
            Controls.Add(pictureBox1);
            Controls.Add(lbMarcarCItens);
            Controls.Add(btnCadastrarItensHome);
            Controls.Add(btnFazerPedidoHome);
            Controls.Add(btnCadastrarClienteHome);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFazerPedidoHome;
        private Button btnCadastrarClienteHome;
        private Button btnCadastrarItensHome;
        private Label lbMarcarCItens;
        private PictureBox pictureBox1;
    }
}