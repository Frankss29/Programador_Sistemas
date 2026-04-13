namespace RadioButton02
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
            rbAzul = new RadioButton();
            rbAmarelo = new RadioButton();
            NomeCor = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbAzul);
            groupBox1.Controls.Add(rbAmarelo);
            groupBox1.Location = new Point(50, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(122, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cores";
            // 
            // rbAzul
            // 
            rbAzul.AutoSize = true;
            rbAzul.Location = new Point(21, 59);
            rbAzul.Name = "rbAzul";
            rbAzul.Size = new Size(48, 19);
            rbAzul.TabIndex = 1;
            rbAzul.TabStop = true;
            rbAzul.Text = "Azul";
            rbAzul.UseVisualStyleBackColor = true;
            rbAzul.CheckedChanged += rbAzul_CheckedChanged;
            // 
            // rbAmarelo
            // 
            rbAmarelo.AutoSize = true;
            rbAmarelo.Location = new Point(21, 31);
            rbAmarelo.Name = "rbAmarelo";
            rbAmarelo.Size = new Size(70, 19);
            rbAmarelo.TabIndex = 0;
            rbAmarelo.TabStop = true;
            rbAmarelo.Text = "Amarelo";
            rbAmarelo.UseVisualStyleBackColor = true;
            rbAmarelo.CheckedChanged += rbAmarelo_CheckedChanged;
            // 
            // NomeCor
            // 
            NomeCor.AutoSize = true;
            NomeCor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NomeCor.Location = new Point(221, 84);
            NomeCor.Name = "NomeCor";
            NomeCor.Size = new Size(63, 25);
            NomeCor.TabIndex = 1;
            NomeCor.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(344, 203);
            Controls.Add(NomeCor);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Escolhendo a Cor";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rbAzul;
        private RadioButton rbAmarelo;
        private Label NomeCor;
    }
}
