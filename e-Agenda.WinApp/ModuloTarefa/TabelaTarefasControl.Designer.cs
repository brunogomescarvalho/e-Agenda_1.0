namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TabelaTarefasControl
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
            gridTarefas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridTarefas).BeginInit();
            SuspendLayout();
            // 
            // gridTarefas
            // 
            gridTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridTarefas.Dock = DockStyle.Fill;
            gridTarefas.Location = new Point(0, 0);
            gridTarefas.Name = "gridTarefas";
            gridTarefas.RowHeadersWidth = 51;
            gridTarefas.RowTemplate.Height = 29;
            gridTarefas.Size = new Size(572, 542);
            gridTarefas.TabIndex = 0;
            // 
            // TabelaTarefasControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridTarefas);
            Name = "TabelaTarefasControl";
            Size = new Size(572, 542);
            ((System.ComponentModel.ISupportInitialize)gridTarefas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridTarefas;
    }
}
