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
            textNome = new TextBox();
            textAnoNascimento = new TextBox();
            textAnoUltimoAniversario = new TextBox();
            textCategoria = new TextBox();
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
            // textNome
            // 
            textNome.Location = new Point(79, 24);
            textNome.Name = "textNome";
            textNome.Size = new Size(348, 23);
            textNome.TabIndex = 4;
            // 
            // textAnoNascimento
            // 
            textAnoNascimento.Location = new Point(154, 60);
            textAnoNascimento.Name = "textAnoNascimento";
            textAnoNascimento.Size = new Size(64, 23);
            textAnoNascimento.TabIndex = 5;
            // 
            // textAnoUltimoAniversario
            // 
            textAnoUltimoAniversario.Location = new Point(363, 60);
            textAnoUltimoAniversario.Name = "textAnoUltimoAniversario";
            textAnoUltimoAniversario.Size = new Size(64, 23);
            textAnoUltimoAniversario.TabIndex = 6;
            textAnoUltimoAniversario.Enter += textAnoUltimoAniversario_Enter;
            textAnoUltimoAniversario.Validating += textAnoUltimoAniversario_Validating;
            // 
            // textCategoria
            // 
            textCategoria.BackColor = Color.FromArgb(255, 255, 128);
            textCategoria.Location = new Point(294, 109);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(133, 23);
            textCategoria.TabIndex = 7;
            // 
            // btnIdentificarCategoria
            // 
            btnIdentificarCategoria.Location = new Point(35, 101);
            btnIdentificarCategoria.Name = "btnIdentificarCategoria";
            btnIdentificarCategoria.Size = new Size(155, 36);
            btnIdentificarCategoria.TabIndex = 8;
            btnIdentificarCategoria.Text = "Identificador Categoria";
            btnIdentificarCategoria.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 161);
            Controls.Add(btnIdentificarCategoria);
            Controls.Add(textCategoria);
            Controls.Add(textAnoUltimoAniversario);
            Controls.Add(textAnoNascimento);
            Controls.Add(textNome);
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
        private TextBox textNome;
        private TextBox textAnoNascimento;
        private TextBox textAnoUltimoAniversario;
        private TextBox textCategoria;
        private Button btnIdentificarCategoria;
    }
}
