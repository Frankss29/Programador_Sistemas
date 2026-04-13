namespace SistemaCadastro
{
    partial class Login
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
            lbLogin = new Label();
            btnEntrarLogin = new Button();
            txtSenhaLogin = new TextBox();
            txtUsuarioLogin = new TextBox();
            lbCadastrarSeLogin = new Label();
            SuspendLayout();
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLogin.Location = new Point(121, 88);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(89, 37);
            lbLogin.TabIndex = 10;
            lbLogin.Text = "Login";
            // 
            // btnEntrarLogin
            // 
            btnEntrarLogin.Location = new Point(121, 285);
            btnEntrarLogin.Name = "btnEntrarLogin";
            btnEntrarLogin.Size = new Size(96, 32);
            btnEntrarLogin.TabIndex = 9;
            btnEntrarLogin.Text = "Entrar";
            btnEntrarLogin.UseVisualStyleBackColor = true;
            btnEntrarLogin.Click += btnEntrarLogin_Click;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Location = new Point(97, 207);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PasswordChar = '*';
            txtSenhaLogin.PlaceholderText = "Senha";
            txtSenhaLogin.Size = new Size(151, 23);
            txtSenhaLogin.TabIndex = 8;
            // 
            // txtUsuarioLogin
            // 
            txtUsuarioLogin.Location = new Point(97, 159);
            txtUsuarioLogin.Name = "txtUsuarioLogin";
            txtUsuarioLogin.PlaceholderText = "Usuário";
            txtUsuarioLogin.Size = new Size(151, 23);
            txtUsuarioLogin.TabIndex = 7;
            // 
            // lbCadastrarSeLogin
            // 
            lbCadastrarSeLogin.AutoSize = true;
            lbCadastrarSeLogin.BackColor = SystemColors.Control;
            lbCadastrarSeLogin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbCadastrarSeLogin.ForeColor = Color.RoyalBlue;
            lbCadastrarSeLogin.Location = new Point(127, 246);
            lbCadastrarSeLogin.Name = "lbCadastrarSeLogin";
            lbCadastrarSeLogin.Size = new Size(83, 17);
            lbCadastrarSeLogin.TabIndex = 11;
            lbCadastrarSeLogin.Text = "Cadastrar-se";
            lbCadastrarSeLogin.Click += lbCadastrarSeLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 387);
            Controls.Add(lbCadastrarSeLogin);
            Controls.Add(lbLogin);
            Controls.Add(btnEntrarLogin);
            Controls.Add(txtSenhaLogin);
            Controls.Add(txtUsuarioLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbLogin;
        private Button btnEntrarLogin;
        private TextBox txtSenhaLogin;
        private TextBox txtUsuarioLogin;
        private Label lbCadastrarSeLogin;
    }
}