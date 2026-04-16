namespace Produtos
{
    partial class TelaProdutos
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
            dgvProdutos = new DataGridView();
            btnExcluir = new Button();
            lbTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // dgvProdutos
            // 
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.BackgroundColor = SystemColors.ButtonHighlight;
            dgvProdutos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(33, 148);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(709, 234);
            dgvProdutos.TabIndex = 0;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(331, 404);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(102, 34);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.Location = new Point(183, 70);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(391, 32);
            lbTitulo.TabIndex = 2;
            lbTitulo.Text = "Excluindo Informações da Tabela";
            // 
            // TelaProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 450);
            Controls.Add(lbTitulo);
            Controls.Add(btnExcluir);
            Controls.Add(dgvProdutos);
            Name = "TelaProdutos";
            Text = "Produtos";
            Load += TelaProdutos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProdutos;
        private Button btnExcluir;
        private Label lbTitulo;
    }
}
