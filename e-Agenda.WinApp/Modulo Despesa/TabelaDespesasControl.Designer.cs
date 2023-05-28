namespace e_Agenda.WinApp.Modulo_Despesa
{
    partial class TabelaDespesasControl
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
            gridDespesas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridDespesas).BeginInit();
            SuspendLayout();
            // 
            // gridDespesas
            // 
            gridDespesas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDespesas.Dock = DockStyle.Fill;
            gridDespesas.Location = new Point(0, 0);
            gridDespesas.Name = "gridDespesas";
            gridDespesas.RowHeadersWidth = 51;
            gridDespesas.RowTemplate.Height = 29;
            gridDespesas.Size = new Size(508, 471);
            gridDespesas.TabIndex = 0;
            // 
            // TabelaDespesasControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridDespesas);
            Name = "TabelaDespesasControl";
            Size = new Size(508, 471);
            ((System.ComponentModel.ISupportInitialize)gridDespesas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridDespesas;
    }
}
