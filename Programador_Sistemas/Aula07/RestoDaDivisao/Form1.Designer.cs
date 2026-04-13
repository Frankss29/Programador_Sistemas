namespace RestoDaDivisao
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
            txtDividendo = new TextBox();
            txtResto = new TextBox();
            txtDivisor = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Dividendo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 30);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Divisor:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 71);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Resto:";
            label3.Click += label3_Click;
            // 
            // txtDividendo
            // 
            txtDividendo.Location = new Point(76, 23);
            txtDividendo.Name = "txtDividendo";
            txtDividendo.Size = new Size(100, 23);
            txtDividendo.TabIndex = 3;
            // 
            // txtResto
            // 
            txtResto.Location = new Point(259, 65);
            txtResto.Name = "txtResto";
            txtResto.Size = new Size(100, 23);
            txtResto.TabIndex = 4;
            txtResto.TextChanged += textBox2_TextChanged;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(259, 21);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(100, 23);
            txtDivisor.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(46, 66);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 6;
            button1.Text = "Realizar divisão";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 110);
            Controls.Add(button1);
            Controls.Add(txtDivisor);
            Controls.Add(txtResto);
            Controls.Add(txtDividendo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Resto de uma divisão";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDividendo;
        private TextBox txtResto;
        private TextBox txtDivisor;
        private Button button1;
    }
}
