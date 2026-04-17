namespace Pesquisa
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            lbNome = new Label();
            txtPesquisar = new TextBox();
            btnPesquisar = new Button();
            lbCadastro = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            btnSalvar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = SystemColors.ButtonHighlight;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(44, 210);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(418, 288);
            dgvClientes.TabIndex = 0;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(44, 127);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(140, 15);
            lbNome.TabIndex = 1;
            lbNome.Text = "Buscar por Nome e Email";
            // 
            // txtPesquisar
            // 
            txtPesquisar.Location = new Point(44, 168);
            txtPesquisar.Name = "txtPesquisar";
            txtPesquisar.Size = new Size(310, 23);
            txtPesquisar.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(372, 168);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(90, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.Location = new Point(44, 25);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(54, 15);
            lbCadastro.TabIndex = 4;
            lbCadastro.Text = "Cadastro";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(44, 57);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(135, 23);
            txtNome.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(154, 23);
            txtEmail.TabIndex = 6;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(377, 58);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 23);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(371, 516);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 584);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lbCadastro);
            Controls.Add(btnPesquisar);
            Controls.Add(txtPesquisar);
            Controls.Add(lbNome);
            Controls.Add(dgvClientes);
            Name = "Form1";
            Text = "Pesquisa";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private Label lbNome;
        private TextBox txtPesquisar;
        private Button btnPesquisar;
        private Label lbCadastro;
        private TextBox txtNome;
        private TextBox txtEmail;
        private Button btnSalvar;
        private Button btnExcluir;
    }
}
