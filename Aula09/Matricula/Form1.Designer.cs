namespace Matricula
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
            txtNome = new TextBox();
            txtNascimento = new TextBox();
            txtAniversario = new TextBox();
            txtCategoria = new TextBox();
            btnIdentificarCategoria = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 68);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Ano de nascimento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 68);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 2;
            label3.Text = "Ano último aniversário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 117);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(79, 24);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(348, 23);
            txtNome.TabIndex = 4;
            // 
            // txtNascimento
            // 
            txtNascimento.Location = new Point(154, 60);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(64, 23);
            txtNascimento.TabIndex = 5;
            // 
            // txtAniversario
            // 
            txtAniversario.Location = new Point(363, 60);
            txtAniversario.Name = "txtAniversario";
            txtAniversario.Size = new Size(64, 23);
            txtAniversario.TabIndex = 6;
            txtAniversario.Enter += txtAniversario_Enter;
            txtAniversario.Validating += txtAniversario_Validating;
            // 
            // txtCategoria
            // 
            txtCategoria.BackColor = Color.FromArgb(255, 255, 128);
            txtCategoria.Location = new Point(294, 109);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(133, 23);
            txtCategoria.TabIndex = 7;
            // 
            // btnIdentificarCategoria
            // 
            btnIdentificarCategoria.Location = new Point(35, 101);
            btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            btnIdentificarCategoria.Size = new Size(155, 36);
            btnIdentificarCategoria.TabIndex = 8;
            btnIdentificarCategoria.Text = "Identificador Categoria";
            btnIdentificarCategoria.UseVisualStyleBackColor = true;
            btnIdentificarCategoria.Click += btnIdentificarCategoria_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 161);
            Controls.Add(btnIdentificarCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(txtAniversario);
            Controls.Add(txtNascimento);
            Controls.Add(txtNome);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Matrícula de aluno ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNome;
        private TextBox txtNascimento;
        private TextBox txtAniversario;
        private TextBox txtCategoria;
        private Button btnIdentificarCategoria;
    }
}
