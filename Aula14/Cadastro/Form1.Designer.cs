namespace Cadastro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            txtNome = new TextBox();
            txtProfissao = new TextBox();
            txtCPF = new TextBox();
            txtPesquisa = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 40);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 40);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Profissão:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 40);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 2;
            label3.Text = "CPF:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 92);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Nome:";
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.Location = new Point(51, 80);
            button1.Name = "button1";
            button1.Size = new Size(97, 27);
            button1.TabIndex = 4;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SkyBlue;
            button2.Location = new Point(645, 82);
            button2.Name = "button2";
            button2.Size = new Size(97, 26);
            button2.TabIndex = 5;
            button2.Text = "Pesquisar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(97, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(170, 23);
            txtNome.TabIndex = 6;
            // 
            // txtProfissao
            // 
            txtProfissao.Location = new Point(351, 34);
            txtProfissao.Name = "txtProfissao";
            txtProfissao.Size = new Size(155, 23);
            txtProfissao.TabIndex = 7;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(560, 34);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(182, 23);
            txtCPF.TabIndex = 8;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(454, 84);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(173, 23);
            txtPesquisa.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(691, 291);
            dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(txtPesquisa);
            Controls.Add(txtCPF);
            Controls.Add(txtProfissao);
            Controls.Add(txtNome);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cadastro";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private TextBox txtNome;
        private TextBox txtProfissao;
        private TextBox txtCPF;
        private TextBox txtPesquisa;
        private DataGridView dataGridView1;
    }
}
