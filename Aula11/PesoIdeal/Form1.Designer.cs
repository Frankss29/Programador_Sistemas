namespace PesoIdeal
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
            groupBox1 = new GroupBox();
            rbFeminino = new RadioButton();
            rbMasculino = new RadioButton();
            label1 = new Label();
            txtAltura = new TextBox();
            label2 = new Label();
            Peso = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbFeminino);
            groupBox1.Controls.Add(rbMasculino);
            groupBox1.Location = new Point(21, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(234, 74);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gênero";
            // 
            // rbFeminino
            // 
            rbFeminino.AutoSize = true;
            rbFeminino.Location = new Point(126, 30);
            rbFeminino.Name = "rbFeminino";
            rbFeminino.Size = new Size(75, 19);
            rbFeminino.TabIndex = 1;
            rbFeminino.TabStop = true;
            rbFeminino.Text = "Feminino";
            rbFeminino.UseVisualStyleBackColor = true;
            rbFeminino.CheckedChanged += rbFeminino_CheckedChanged;
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(13, 30);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            rbMasculino.CheckedChanged += rbMasculino_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 43);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Altura:";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(281, 74);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 126);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Peso Ideal";
            // 
            // Peso
            // 
            Peso.AutoSize = true;
            Peso.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Peso.ForeColor = Color.IndianRed;
            Peso.Location = new Point(180, 152);
            Peso.Name = "Peso";
            Peso.Size = new Size(72, 31);
            Peso.TabIndex = 4;
            Peso.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 197);
            Controls.Add(Peso);
            Controls.Add(label2);
            Controls.Add(txtAltura);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Peso Ideal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbFeminino;
        private RadioButton rbMasculino;
        private Label label1;
        private TextBox txtAltura;
        private Label label2;
        private Label Peso;
    }
}
