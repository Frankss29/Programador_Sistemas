namespace Aula_Curso
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            lbCadastro = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            cbCurso = new ComboBox();
            btnSalvar = new Button();
            dgvAlunos = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbCadastro
            // 
            lbCadastro.AutoSize = true;
            lbCadastro.BackColor = Color.Transparent;
            lbCadastro.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCadastro.ForeColor = SystemColors.ControlLightLight;
            lbCadastro.Location = new Point(178, 45);
            lbCadastro.Name = "lbCadastro";
            lbCadastro.Size = new Size(95, 25);
            lbCadastro.TabIndex = 0;
            lbCadastro.Text = "Cadastro";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(34, 102);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome ";
            txtNome.Size = new Size(180, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(244, 102);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(171, 23);
            txtEmail.TabIndex = 2;
            // 
            // cbCurso
            // 
            cbCurso.FormattingEnabled = true;
            cbCurso.Location = new Point(34, 150);
            cbCurso.Name = "cbCurso";
            cbCurso.Size = new Size(180, 23);
            cbCurso.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Font = new Font("Yu Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(244, 144);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(171, 30);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvAlunos
            // 
            dgvAlunos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlunos.BackgroundColor = SystemColors.HighlightText;
            dgvAlunos.BorderStyle = BorderStyle.None;
            dgvAlunos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlunos.Location = new Point(34, 204);
            dgvAlunos.Name = "dgvAlunos";
            dgvAlunos.RowHeadersVisible = false;
            dgvAlunos.Size = new Size(381, 195);
            dgvAlunos.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Indigo;
            ClientSize = new Size(456, 439);
            Controls.Add(dgvAlunos);
            Controls.Add(btnSalvar);
            Controls.Add(cbCurso);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lbCadastro);
            Controls.Add(pictureBox1);
            Name = "TelaCadastro";
            Text = "Sistema de Cadastro -Instituição";
            Load += TelaCadastro_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCadastro;
        private TextBox txtNome;
        private TextBox txtEmail;
        private ComboBox cbCurso;
        private Button btnSalvar;
        private DataGridView dgvAlunos;
        private PictureBox pictureBox1;
    }
}
