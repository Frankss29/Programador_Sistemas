namespace Temperatura
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
            textCelsius = new TextBox();
            textFahrenheit = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 39);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Temperatura em °C:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 83);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Temperatura em °F:";
            // 
            // textCelsius
            // 
            textCelsius.Location = new Point(258, 31);
            textCelsius.Name = "textCelsius";
            textCelsius.Size = new Size(100, 23);
            textCelsius.TabIndex = 2;
            // 
            // textFahrenheit
            // 
            textFahrenheit.Location = new Point(258, 80);
            textFahrenheit.Name = "textFahrenheit";
            textFahrenheit.Size = new Size(100, 23);
            textFahrenheit.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(155, 132);
            button1.Name = "button1";
            button1.Size = new Size(129, 23);
            button1.TabIndex = 4;
            button1.Text = "Converter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.temperatura;
            pictureBox1.Image = Properties.Resources.temperatura;
            pictureBox1.Location = new Point(31, 18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 177);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textFahrenheit);
            Controls.Add(textCelsius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Conversor de Temperatura";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textCelsius;
        private TextBox textFahrenheit;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
