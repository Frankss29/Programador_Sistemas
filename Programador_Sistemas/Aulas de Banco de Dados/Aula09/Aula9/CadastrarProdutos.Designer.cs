namespace Aula9
{
    partial class CadastrarProdutos
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
            txtNome = new TextBox();
            lbNome = new Label();
            lbCategoria = new Label();
            txtCategoria = new TextBox();
            lbPreco = new Label();
            txtPreco = new TextBox();
            lbEstoque = new Label();
            txtEstoque = new TextBox();
            btnSalvar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(95, 28);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 0;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(20, 36);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(43, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Nome:";
            // 
            // lbCategoria
            // 
            lbCategoria.AutoSize = true;
            lbCategoria.Location = new Point(20, 73);
            lbCategoria.Name = "lbCategoria";
            lbCategoria.Size = new Size(61, 15);
            lbCategoria.TabIndex = 3;
            lbCategoria.Text = "Categoria:";
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(95, 65);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 2;
            // 
            // lbPreco
            // 
            lbPreco.AutoSize = true;
            lbPreco.Location = new Point(23, 113);
            lbPreco.Name = "lbPreco";
            lbPreco.Size = new Size(40, 15);
            lbPreco.TabIndex = 5;
            lbPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(95, 105);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 4;
            // 
            // lbEstoque
            // 
            lbEstoque.AutoSize = true;
            lbEstoque.Location = new Point(23, 151);
            lbEstoque.Name = "lbEstoque";
            lbEstoque.Size = new Size(52, 15);
            lbEstoque.TabIndex = 7;
            lbEstoque.Text = "Estoque:";
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(95, 143);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(100, 23);
            txtEstoque.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(95, 189);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(100, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(99, 222);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 9;
            button1.Text = "Ir Tabela";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastrarProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 277);
            Controls.Add(button1);
            Controls.Add(btnSalvar);
            Controls.Add(lbEstoque);
            Controls.Add(txtEstoque);
            Controls.Add(lbPreco);
            Controls.Add(txtPreco);
            Controls.Add(lbCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(lbNome);
            Controls.Add(txtNome);
            Name = "CadastrarProdutos";
            Text = "CadastrarProdutos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label lbNome;
        private Label lbCategoria;
        private TextBox txtCategoria;
        private Label lbPreco;
        private TextBox txtPreco;
        private Label lbEstoque;
        private TextBox txtEstoque;
        private Button btnSalvar;
        private Button button1;
    }
}