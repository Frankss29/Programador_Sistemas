namespace Login
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            lbCadastro = new Label();
            lbCadastroNome = new Label();
            lbCadastroSenha = new Label();
            btnCadastroLogin = new Button();
            btnCadastroSalvar = new Button();
            txtCadastroNome = new TextBox();
            txtCadastroSenha = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCadastro.ForeColor = SystemColors.ControlLightLight;
            lbCadastro.Location = new Point(142, 171);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(123, 37);
            lbCadastro.TabIndex = 0;
            lbCadastro.Text = "Cadastro";
            lbCadastro.Click += label1_Click;
            // 
            // lbCadastroNome
            // 
            lbCadastroNome.AutoSize = true;
            lbCadastroNome.ForeColor = SystemColors.ControlLightLight;
            lbCadastroNome.Location = new Point(112, 222);
            lbCadastroNome.Name = "lbCadastroNome";
            lbCadastroNome.Size = new Size(40, 15);
            lbCadastroNome.TabIndex = 1;
            lbCadastroNome.Text = "Nome";
            // 
            // lbCadastroSenha
            // 
            lbCadastroSenha.AutoSize = true;
            lbCadastroSenha.ForeColor = SystemColors.ControlLightLight;
            lbCadastroSenha.Location = new Point(113, 274);
            lbCadastroSenha.Name = "lbCadastroSenha";
            lbCadastroSenha.Size = new Size(39, 15);
            lbCadastroSenha.TabIndex = 2;
            lbCadastroSenha.Text = "Senha";
            // 
            // btnCadastroLogin
            // 
            btnCadastroLogin.BackColor = Color.DarkSlateBlue;
            btnCadastroLogin.ForeColor = SystemColors.ControlLightLight;
            btnCadastroLogin.Location = new Point(134, 383);
            btnCadastroLogin.Name = "btnCadastroLogin";
            btnCadastroLogin.Size = new Size(133, 32);
            btnCadastroLogin.TabIndex = 3;
            btnCadastroLogin.Text = "Login";
            btnCadastroLogin.UseVisualStyleBackColor = false;
            btnCadastroLogin.Click += btnCadastroLogin_Click;
            btnCadastroLogin.MouseEnter += btnCadastroLogin_MouseEnter;
            btnCadastroLogin.MouseLeave += btnCadastroLogin_MouseLeave;
            // 
            // btnCadastroSalvar
            // 
            btnCadastroSalvar.BackColor = Color.DarkSlateBlue;
            btnCadastroSalvar.ForeColor = SystemColors.ControlLightLight;
            btnCadastroSalvar.Location = new Point(134, 343);
            btnCadastroSalvar.Name = "btnCadastroSalvar";
            btnCadastroSalvar.Size = new Size(133, 32);
            btnCadastroSalvar.TabIndex = 4;
            btnCadastroSalvar.Text = "Salvar";
            btnCadastroSalvar.UseVisualStyleBackColor = false;
            btnCadastroSalvar.Click += btnCadastroSalvar_Click;
            btnCadastroSalvar.MouseEnter += btnCadastroSalvar_MouseEnter;
            btnCadastroSalvar.MouseLeave += btnCadastroSalvar_MouseLeave;
            // 
            // txtCadastroNome
            // 
            txtCadastroNome.Location = new Point(112, 240);
            txtCadastroNome.Name = "txtCadastroNome";
            txtCadastroNome.Size = new Size(176, 23);
            txtCadastroNome.TabIndex = 5;
            // 
            // txtCadastroSenha
            // 
            txtCadastroSenha.Location = new Point(112, 292);
            txtCadastroSenha.Name = "txtCadastroSenha";
            txtCadastroSenha.Size = new Size(176, 23);
            txtCadastroSenha.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(406, 445);
            Controls.Add(pictureBox1);
            Controls.Add(txtCadastroSenha);
            Controls.Add(txtCadastroNome);
            Controls.Add(btnCadastroSalvar);
            Controls.Add(btnCadastroLogin);
            Controls.Add(lbCadastroSenha);
            Controls.Add(lbCadastroNome);
            Controls.Add(lbCadastro);
            Name = "Cadastro";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCadastro;
        private Label lbCadastroNome;
        private Label lbCadastroSenha;
        private Button btnCadastroLogin;
        private Button btnCadastroSalvar;
        private TextBox txtCadastroNome;
        private TextBox txtCadastroSenha;
        private PictureBox pictureBox1;
    }
}