namespace TrocarValores
{
    partial class frmTrocaDeValores
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
            txtSegundoValor = new TextBox();
            label2 = new Label();
            txtPrimeiroValor = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 27);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            label1.Click += label1_Click;
            // 
            // txtSegundoValor
            // 
            txtSegundoValor.Location = new Point(173, 24);
            txtSegundoValor.Name = "txtSegundoValor";
            txtSegundoValor.Size = new Size(70, 23);
            txtSegundoValor.TabIndex = 1;
            txtSegundoValor.TextChanged += txtSegundoValor_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(131, 27);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "Valor 2:";
            // 
            // txtPrimeiroValor
            // 
            txtPrimeiroValor.Location = new Point(54, 24);
            txtPrimeiroValor.Name = "txtPrimeiroValor";
            txtPrimeiroValor.Size = new Size(71, 23);
            txtPrimeiroValor.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(102, 56);
            button1.Name = "button1";
            button1.Size = new Size(61, 22);
            button1.TabIndex = 4;
            button1.Text = "Trocar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmTrocaDeValores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 85);
            Controls.Add(button1);
            Controls.Add(txtPrimeiroValor);
            Controls.Add(label2);
            Controls.Add(txtSegundoValor);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmTrocaDeValores";
            Text = "Troca de valores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSegundoValor;
        private Label label2;
        private TextBox txtPrimeiroValor;
        private Button button1;
    }
}
