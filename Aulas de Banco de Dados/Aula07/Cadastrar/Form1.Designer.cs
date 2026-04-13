namespace Cadastrar
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
            gbAluno = new GroupBox();
            lbEmailAluno = new Label();
            lbNomeGBaluno = new Label();
            txtEmail = new TextBox();
            txtNomeGBaluno = new TextBox();
            btnSalvarGBaluno = new Button();
            gbFinanceiro = new GroupBox();
            rtxtObservacaoFinanceiro = new RichTextBox();
            txtRendaFinanceiro = new TextBox();
            lbObservacaoFinanceiro = new Label();
            lbRenda = new Label();
            lbNomeGBfinanceiro = new Label();
            btnSalvarGBfinanceiro = new Button();
            lbID = new Label();
            txtNomeGBfinanceiro = new TextBox();
            txtIDAlunoFinanceiro = new TextBox();
            gbAluno.SuspendLayout();
            gbFinanceiro.SuspendLayout();
            SuspendLayout();
            // 
            // gbAluno
            // 
            gbAluno.BackColor = Color.LightGray;
            gbAluno.Controls.Add(lbEmailAluno);
            gbAluno.Controls.Add(lbNomeGBaluno);
            gbAluno.Controls.Add(txtEmail);
            gbAluno.Controls.Add(txtNomeGBaluno);
            gbAluno.Controls.Add(btnSalvarGBaluno);
            gbAluno.Location = new Point(12, 12);
            gbAluno.Name = "gbAluno";
            gbAluno.Size = new Size(343, 133);
            gbAluno.TabIndex = 0;
            gbAluno.TabStop = false;
            gbAluno.Text = "Grupo Aluno";
            // 
            // lbEmailAluno
            // 
            lbEmailAluno.AutoSize = true;
            lbEmailAluno.Location = new Point(31, 81);
            lbEmailAluno.Name = "lbEmailAluno";
            lbEmailAluno.Size = new Size(39, 15);
            lbEmailAluno.TabIndex = 4;
            lbEmailAluno.Text = "Email:";
            // 
            // lbNomeGBaluno
            // 
            lbNomeGBaluno.AutoSize = true;
            lbNomeGBaluno.Location = new Point(31, 42);
            lbNomeGBaluno.Name = "lbNomeGBaluno";
            lbNomeGBaluno.Size = new Size(43, 15);
            lbNomeGBaluno.TabIndex = 3;
            lbNomeGBaluno.Text = "Nome:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(83, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtNomeGBaluno
            // 
            txtNomeGBaluno.Location = new Point(83, 39);
            txtNomeGBaluno.Name = "txtNomeGBaluno";
            txtNomeGBaluno.Size = new Size(100, 23);
            txtNomeGBaluno.TabIndex = 1;
            // 
            // btnSalvarGBaluno
            // 
            btnSalvarGBaluno.Location = new Point(262, 103);
            btnSalvarGBaluno.Name = "btnSalvarGBaluno";
            btnSalvarGBaluno.Size = new Size(75, 23);
            btnSalvarGBaluno.TabIndex = 0;
            btnSalvarGBaluno.Text = "Salvar";
            btnSalvarGBaluno.UseVisualStyleBackColor = true;
            btnSalvarGBaluno.Click += btnSalvarGBaluno_Click;
            // 
            // gbFinanceiro
            // 
            gbFinanceiro.BackColor = Color.LightGray;
            gbFinanceiro.Controls.Add(rtxtObservacaoFinanceiro);
            gbFinanceiro.Controls.Add(txtRendaFinanceiro);
            gbFinanceiro.Controls.Add(lbObservacaoFinanceiro);
            gbFinanceiro.Controls.Add(lbRenda);
            gbFinanceiro.Controls.Add(lbNomeGBfinanceiro);
            gbFinanceiro.Controls.Add(btnSalvarGBfinanceiro);
            gbFinanceiro.Controls.Add(lbID);
            gbFinanceiro.Controls.Add(txtNomeGBfinanceiro);
            gbFinanceiro.Controls.Add(txtIDAlunoFinanceiro);
            gbFinanceiro.Location = new Point(12, 166);
            gbFinanceiro.Name = "gbFinanceiro";
            gbFinanceiro.Size = new Size(343, 258);
            gbFinanceiro.TabIndex = 1;
            gbFinanceiro.TabStop = false;
            gbFinanceiro.Text = "Grupo Financeiro";
            // 
            // rtxtObservacaoFinanceiro
            // 
            rtxtObservacaoFinanceiro.Location = new Point(121, 138);
            rtxtObservacaoFinanceiro.Name = "rtxtObservacaoFinanceiro";
            rtxtObservacaoFinanceiro.Size = new Size(167, 68);
            rtxtObservacaoFinanceiro.TabIndex = 14;
            rtxtObservacaoFinanceiro.Text = "";
            // 
            // txtRendaFinanceiro
            // 
            txtRendaFinanceiro.Location = new Point(121, 95);
            txtRendaFinanceiro.Name = "txtRendaFinanceiro";
            txtRendaFinanceiro.Size = new Size(167, 23);
            txtRendaFinanceiro.TabIndex = 12;
            // 
            // lbObservacaoFinanceiro
            // 
            lbObservacaoFinanceiro.AutoSize = true;
            lbObservacaoFinanceiro.Location = new Point(41, 138);
            lbObservacaoFinanceiro.Name = "lbObservacaoFinanceiro";
            lbObservacaoFinanceiro.Size = new Size(77, 15);
            lbObservacaoFinanceiro.TabIndex = 10;
            lbObservacaoFinanceiro.Text = "Observações:";
            // 
            // lbRenda
            // 
            lbRenda.AutoSize = true;
            lbRenda.Location = new Point(43, 98);
            lbRenda.Name = "lbRenda";
            lbRenda.Size = new Size(43, 15);
            lbRenda.TabIndex = 9;
            lbRenda.Text = "Renda:";
            // 
            // lbNomeGBfinanceiro
            // 
            lbNomeGBfinanceiro.AutoSize = true;
            lbNomeGBfinanceiro.Location = new Point(185, 32);
            lbNomeGBfinanceiro.Name = "lbNomeGBfinanceiro";
            lbNomeGBfinanceiro.Size = new Size(40, 15);
            lbNomeGBfinanceiro.TabIndex = 8;
            lbNomeGBfinanceiro.Text = "Nome";
            // 
            // btnSalvarGBfinanceiro
            // 
            btnSalvarGBfinanceiro.Location = new Point(262, 229);
            btnSalvarGBfinanceiro.Name = "btnSalvarGBfinanceiro";
            btnSalvarGBfinanceiro.Size = new Size(75, 23);
            btnSalvarGBfinanceiro.TabIndex = 1;
            btnSalvarGBfinanceiro.Text = "Salvar";
            btnSalvarGBfinanceiro.UseVisualStyleBackColor = true;
            btnSalvarGBfinanceiro.Click += btnSalvarGBfinanceiro_Click;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(44, 32);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 7;
            lbID.Text = "ID";
            // 
            // txtNomeGBfinanceiro
            // 
            txtNomeGBfinanceiro.Location = new Point(185, 50);
            txtNomeGBfinanceiro.Name = "txtNomeGBfinanceiro";
            txtNomeGBfinanceiro.Size = new Size(100, 23);
            txtNomeGBfinanceiro.TabIndex = 6;
            // 
            // txtIDAlunoFinanceiro
            // 
            txtIDAlunoFinanceiro.Location = new Point(44, 50);
            txtIDAlunoFinanceiro.Name = "txtIDAlunoFinanceiro";
            txtIDAlunoFinanceiro.Size = new Size(100, 23);
            txtIDAlunoFinanceiro.TabIndex = 5;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(367, 444);
            Controls.Add(gbFinanceiro);
            Controls.Add(gbAluno);
            Name = "TelaCadastro";
            Text = "Cadastro";
            gbAluno.ResumeLayout(false);
            gbAluno.PerformLayout();
            gbFinanceiro.ResumeLayout(false);
            gbFinanceiro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAluno;
        private Button btnSalvarGBaluno;
        private GroupBox gbFinanceiro;
        private Button btnSalvarGBfinanceiro;
        private Label lbEmailAluno;
        private Label lbNomeGBaluno;
        private TextBox txtEmail;
        private TextBox txtNomeGBaluno;
        private Label lbNomeGBfinanceiro;
        private Label lbID;
        private TextBox txtNomeGBfinanceiro;
        private TextBox txtIDAlunoFinanceiro;
        private RichTextBox rtxtObservacaoFinanceiro;
        private TextBox txtRendaFinanceiro;
        private Label lbObservacaoFinanceiro;
        private Label lbRenda;
    }
}
