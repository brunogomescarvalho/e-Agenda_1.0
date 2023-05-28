namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TabelaCategoriasControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gridCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridCategorias).BeginInit();
            SuspendLayout();
            // 
            // gridCategorias
            // 
            gridCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCategorias.Dock = DockStyle.Fill;
            gridCategorias.Location = new Point(0, 0);
            gridCategorias.Name = "gridCategorias";
            gridCategorias.RowHeadersWidth = 51;
            gridCategorias.RowTemplate.Height = 29;
            gridCategorias.Size = new Size(582, 516);
            gridCategorias.TabIndex = 0;
            // 
            // TabelaCategoriasControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridCategorias);
            Name = "TabelaCategoriasControl";
            Size = new Size(582, 516);
            ((System.ComponentModel.ISupportInitialize)gridCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCategorias;
    }
}
