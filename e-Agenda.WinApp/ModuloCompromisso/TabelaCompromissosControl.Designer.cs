namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class ListaCompromissosControl
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
            gridCompromissos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)gridCompromissos).BeginInit();
            SuspendLayout();
            // 
            // gridCompromissos
            // 
            gridCompromissos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridCompromissos.Dock = DockStyle.Fill;
            gridCompromissos.Location = new Point(0, 0);
            gridCompromissos.Name = "gridCompromissos";
            gridCompromissos.RowHeadersWidth = 51;
            gridCompromissos.RowTemplate.Height = 29;
            gridCompromissos.Size = new Size(771, 628);
            gridCompromissos.TabIndex = 0;
            // 
            // ListaCompromissosControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridCompromissos);
            Name = "ListaCompromissosControl";
            Size = new Size(771, 628);
            ((System.ComponentModel.ISupportInitialize)gridCompromissos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView gridCompromissos;
    }
}
