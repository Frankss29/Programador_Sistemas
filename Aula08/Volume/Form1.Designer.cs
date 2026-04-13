namespace Volume
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
            txtComprimento = new TextBox();
            txtLargura = new TextBox();
            txtAltura = new TextBox();
            txtVolume = new TextBox();
            label4 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 48);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 0;
            label1.Text = "Comprimento:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(215, 87);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Largura:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 128);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Altura:";
            // 
            // txtComprimento
            // 
            txtComprimento.Location = new Point(271, 40);
            txtComprimento.Name = "txtComprimento";
            txtComprimento.Size = new Size(100, 23);
            txtComprimento.TabIndex = 3;
            // 
            // txtLargura
            // 
            txtLargura.Location = new Point(271, 79);
            txtLargura.Name = "txtLargura";
            txtLargura.Size = new Size(100, 23);
            txtLargura.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(271, 120);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 5;
            // 
            // txtVolume
            // 
            txtVolume.Location = new Point(271, 164);
            txtVolume.Name = "txtVolume";
            txtVolume.Size = new Size(100, 23);
            txtVolume.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(215, 172);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 7;
            label4.Text = "Volume:";
            // 
            // button1
            // 
            button1.BackColor = Color.SkyBlue;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(38, 161);
            button1.Name = "button1";
            button1.Size = new Size(131, 32);
            button1.TabIndex = 8;
            button1.Text = "Calcular Volume";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.volume;
            pictureBox1.Location = new Point(38, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(420, 221);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(txtVolume);
            Controls.Add(txtAltura);
            Controls.Add(txtLargura);
            Controls.Add(txtComprimento);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cálculo de Volume";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtComprimento;
        private TextBox txtLargura;
        private TextBox txtAltura;
        private TextBox txtVolume;
        private Label label4;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
