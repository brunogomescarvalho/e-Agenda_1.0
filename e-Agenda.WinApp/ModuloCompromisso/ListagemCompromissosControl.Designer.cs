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
            listCompromissos = new ListBox();
            SuspendLayout();
            // 
            // listCompromissos
            // 
            listCompromissos.Dock = DockStyle.Fill;
            listCompromissos.FormattingEnabled = true;
            listCompromissos.ItemHeight = 20;
            listCompromissos.Location = new Point(0, 0);
            listCompromissos.Name = "listCompromissos";
            listCompromissos.Size = new Size(771, 628);
            listCompromissos.TabIndex = 0;
            // 
            // ListaCompromissosControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listCompromissos);
            Name = "ListaCompromissosControl";
            Size = new Size(771, 628);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listCompromissos;
    }
}
