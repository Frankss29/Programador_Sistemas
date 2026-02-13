namespace Viagem
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
            textDistancia = new TextBox();
            textPreco = new TextBox();
            btn1 = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 77);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Distância em KMs:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 118);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 1;
            label2.Text = "Preço da Passagem:";
            label2.Click += label2_Click;
            // 
            // textDistancia
            // 
            textDistancia.Location = new Point(181, 69);
            textDistancia.Name = "textDistancia";
            textDistancia.Size = new Size(100, 23);
            textDistancia.TabIndex = 2;
            // 
            // textPreco
            // 
            textPreco.Location = new Point(188, 110);
            textPreco.Name = "textPreco";
            textPreco.Size = new Size(92, 23);
            textPreco.TabIndex = 3;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(159, 167);
            btn1.Name = "btn1";
            btn1.Size = new Size(93, 33);
            btn1.TabIndex = 4;
            btn1.Text = "Calcular";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            btn1.MouseEnter += btn1_MouseEnter;
            btn1.MouseLeave += btn1_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Typewriter", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(155, 20);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 5;
            label3.Text = "PassPay";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.carro;
            pictureBox1.Location = new Point(291, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 250);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btn1);
            Controls.Add(textPreco);
            Controls.Add(textDistancia);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calculadora de Passagens";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textDistancia;
        private TextBox textPreco;
        private Button btn1;
        private Label label3;
        private PictureBox pictureBox1;
    }
}
