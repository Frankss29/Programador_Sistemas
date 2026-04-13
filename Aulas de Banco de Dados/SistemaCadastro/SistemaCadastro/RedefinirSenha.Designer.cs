namespace SistemaCadastro
{
    partial class RedefinirSenha
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
            btnCadastrar = new Button();
            txtSenhaRedefinir = new TextBox();
            txtUsuarioRedefinirSenha = new TextBox();
            lbRedefinir = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(109, 207);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(96, 32);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Redefinir";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // txtSenhaRedefinir
            // 
            txtSenhaRedefinir.Location = new Point(85, 150);
            txtSenhaRedefinir.Name = "txtSenhaRedefinir";
            txtSenhaRedefinir.PasswordChar = '*';
            txtSenhaRedefinir.PlaceholderText = "Senha";
            txtSenhaRedefinir.Size = new Size(151, 23);
            txtSenhaRedefinir.TabIndex = 4;
            // 
            // txtUsuarioRedefinirSenha
            // 
            txtUsuarioRedefinirSenha.Location = new Point(85, 102);
            txtUsuarioRedefinirSenha.Name = "txtUsuarioRedefinirSenha";
            txtUsuarioRedefinirSenha.PlaceholderText = "Usuário";
            txtUsuarioRedefinirSenha.Size = new Size(151, 23);
            txtUsuarioRedefinirSenha.TabIndex = 3;
            // 
            // lbRedefinir
            // 
            lbRedefinir.AutoSize = true;
            lbRedefinir.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRedefinir.Location = new Point(50, 34);
            lbRedefinir.Name = "lbRedefinir";
            lbRedefinir.Size = new Size(218, 37);
            lbRedefinir.TabIndex = 6;
            lbRedefinir.Text = "Redefinir Senha";
            // 
            // RedefinirSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(321, 340);
            Controls.Add(lbRedefinir);
            Controls.Add(btnCadastrar);
            Controls.Add(txtSenhaRedefinir);
            Controls.Add(txtUsuarioRedefinirSenha);
            Name = "RedefinirSenha";
            Text = "RedefinirSenha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrar;
        private TextBox txtSenhaRedefinir;
        private TextBox txtUsuarioRedefinirSenha;
        private Label lbRedefinir;
    }
}