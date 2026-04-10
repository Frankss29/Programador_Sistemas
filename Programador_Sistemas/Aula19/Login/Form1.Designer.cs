namespace Login
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbLogin = new Label();
            txtLoginUsuario = new TextBox();
            txtLoginSenha = new TextBox();
            btnLoginEntrar = new Button();
            lbLoginUsuario = new Label();
            lbLoginSenha = new Label();
            btnLoginCadastrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLogin.ForeColor = SystemColors.ButtonHighlight;
            lbLogin.Location = new Point(160, 168);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(84, 37);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Login";
            // 
            // txtLoginUsuario
            // 
            txtLoginUsuario.Location = new Point(113, 237);
            txtLoginUsuario.Name = "txtLoginUsuario";
            txtLoginUsuario.Size = new Size(176, 23);
            txtLoginUsuario.TabIndex = 1;
            // 
            // txtLoginSenha
            // 
            txtLoginSenha.Location = new Point(113, 295);
            txtLoginSenha.Name = "txtLoginSenha";
            txtLoginSenha.Size = new Size(176, 23);
            txtLoginSenha.TabIndex = 2;
            // 
            // btnLoginEntrar
            // 
            btnLoginEntrar.BackColor = Color.DarkSlateBlue;
            btnLoginEntrar.ForeColor = SystemColors.ControlLightLight;
            btnLoginEntrar.Location = new Point(134, 344);
            btnLoginEntrar.Name = "btnLoginEntrar";
            btnLoginEntrar.Size = new Size(133, 32);
            btnLoginEntrar.TabIndex = 3;
            btnLoginEntrar.Text = "Entrar";
            btnLoginEntrar.UseVisualStyleBackColor = false;
            btnLoginEntrar.Click += btnLoginEntrar_Click;
            btnLoginEntrar.MouseEnter += btnLoginEntrar_MouseEnter;
            btnLoginEntrar.MouseLeave += btnLoginEntrar_MouseLeave;
            // 
            // lbLoginUsuario
            // 
            lbLoginUsuario.AutoSize = true;
            lbLoginUsuario.ForeColor = SystemColors.ControlLightLight;
            lbLoginUsuario.Location = new Point(113, 219);
            lbLoginUsuario.Name = "lbLoginUsuario";
            lbLoginUsuario.Size = new Size(47, 15);
            lbLoginUsuario.TabIndex = 4;
            lbLoginUsuario.Text = "Usuário";
            // 
            // lbLoginSenha
            // 
            lbLoginSenha.AutoSize = true;
            lbLoginSenha.ForeColor = SystemColors.ControlLightLight;
            lbLoginSenha.Location = new Point(113, 277);
            lbLoginSenha.Name = "lbLoginSenha";
            lbLoginSenha.Size = new Size(39, 15);
            lbLoginSenha.TabIndex = 5;
            lbLoginSenha.Text = "Senha";
            // 
            // btnLoginCadastrar
            // 
            btnLoginCadastrar.BackColor = Color.DarkSlateBlue;
            btnLoginCadastrar.ForeColor = SystemColors.ControlLightLight;
            btnLoginCadastrar.Location = new Point(134, 382);
            btnLoginCadastrar.Name = "btnLoginCadastrar";
            btnLoginCadastrar.Size = new Size(133, 32);
            btnLoginCadastrar.TabIndex = 6;
            btnLoginCadastrar.Text = "Cadastrar Usuário";
            btnLoginCadastrar.UseVisualStyleBackColor = false;
            btnLoginCadastrar.Click += btnLoginCadastrar_Click;
            btnLoginCadastrar.MouseEnter += btnLoginCadastrar_MouseEnter;
            btnLoginCadastrar.MouseLeave += btnLoginCadastrar_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(134, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 148);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(406, 445);
            Controls.Add(pictureBox1);
            Controls.Add(btnLoginCadastrar);
            Controls.Add(lbLoginSenha);
            Controls.Add(lbLoginUsuario);
            Controls.Add(btnLoginEntrar);
            Controls.Add(txtLoginSenha);
            Controls.Add(txtLoginUsuario);
            Controls.Add(lbLogin);
            Name = "Form1";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private TextBox txtLoginUsuario;
        private TextBox txtLoginSenha;
        private Button btnLoginEntrar;
        private Label lbLoginUsuario;
        private Label lbLoginSenha;
        private Button btnLoginCadastrar;
        private PictureBox pictureBox1;
    }
}
