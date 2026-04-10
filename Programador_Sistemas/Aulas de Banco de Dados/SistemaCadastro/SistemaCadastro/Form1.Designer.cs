namespace SistemaCadastro
{
    partial class TelaCadastro
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
            txtNomeCadastro = new TextBox();
            txtSenhaCadastro = new TextBox();
            btnCadastrar = new Button();
            lbCadastro = new Label();
            lbEsqueciSenhaCadastro = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtNomeCadastro
            // 
            txtNomeCadastro.Location = new Point(76, 132);
            txtNomeCadastro.Name = "txtNomeCadastro";
            txtNomeCadastro.PlaceholderText = "Nome";
            txtNomeCadastro.Size = new Size(151, 23);
            txtNomeCadastro.TabIndex = 0;
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Location = new Point(76, 176);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PasswordChar = '*';
            txtSenhaCadastro.PlaceholderText = "Senha";
            txtSenhaCadastro.Size = new Size(151, 23);
            txtSenhaCadastro.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(100, 237);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(96, 32);
            btnCadastrar.TabIndex = 2;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastro.Location = new Point(86, 55);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(132, 37);
            lbCadastro.TabIndex = 3;
            lbCadastro.Text = "Cadastro";
            // 
            // lbEsqueciSenhaCadastro
            // 
            lbEsqueciSenhaCadastro.AutoSize = true;
            lbEsqueciSenhaCadastro.BackColor = SystemColors.Control;
            lbEsqueciSenhaCadastro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbEsqueciSenhaCadastro.ForeColor = Color.RoyalBlue;
            lbEsqueciSenhaCadastro.Location = new Point(100, 206);
            lbEsqueciSenhaCadastro.Name = "lbEsqueciSenhaCadastro";
            lbEsqueciSenhaCadastro.Size = new Size(105, 17);
            lbEsqueciSenhaCadastro.TabIndex = 4;
            lbEsqueciSenhaCadastro.Text = "Esqueci a senha";
            lbEsqueciSenhaCadastro.Click += label1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(100, 275);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 32);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 344);
            Controls.Add(btnLogin);
            Controls.Add(lbEsqueciSenhaCadastro);
            Controls.Add(lbCadastro);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(txtNomeCadastro);
            Name = "TelaCadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeCadastro;
        private TextBox txtSenhaCadastro;
        private Button btnCadastrar;
        private Label lbCadastro;
        private Label lbEsqueciSenhaCadastro;
        private Button btnLogin;
    }
}
