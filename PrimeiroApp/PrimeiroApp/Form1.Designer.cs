namespace PrimeiroApp
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
            btnVerificar = new Button();
            textNome = new TextBox();
            Mensagem = new Label();
            SuspendLayout();
            // 
            // btnVerificar
            // 
            btnVerificar.BackColor = Color.DarkSeaGreen;
            btnVerificar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerificar.ForeColor = SystemColors.ControlLightLight;
            btnVerificar.Location = new Point(349, 292);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(104, 37);
            btnVerificar.TabIndex = 0;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = false;
            btnVerificar.Click += button1_Click;
            // 
            // textNome
            // 
            textNome.Location = new Point(283, 205);
            textNome.Name = "textNome";
            textNome.Size = new Size(238, 23);
            textNome.TabIndex = 1;
            textNome.TextChanged += textBox1_TextChanged;
            // 
            // Mensagem
            // 
            Mensagem.AutoSize = true;
            Mensagem.Location = new Point(380, 128);
            Mensagem.Name = "Mensagem";
            Mensagem.Size = new Size(38, 15);
            Mensagem.TabIndex = 2;
            Mensagem.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Mensagem);
            Controls.Add(textNome);
            Controls.Add(btnVerificar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVerificar;
        private TextBox textNome;
        private Label Mensagem;
    }
}
