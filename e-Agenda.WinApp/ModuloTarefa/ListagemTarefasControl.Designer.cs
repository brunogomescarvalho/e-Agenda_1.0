namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class ListagemTarefasControl
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
            listTarefasControl = new ListBox();
            SuspendLayout();
            // 
            // listTarefasControl
            // 
            listTarefasControl.Dock = DockStyle.Fill;
            listTarefasControl.FormattingEnabled = true;
            listTarefasControl.ItemHeight = 20;
            listTarefasControl.Location = new Point(0, 0);
            listTarefasControl.Name = "listTarefasControl";
            listTarefasControl.Size = new Size(572, 542);
            listTarefasControl.TabIndex = 0;
            // 
            // ListagemTarefasControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTarefasControl);
            Name = "ListagemTarefasControl";
            Size = new Size(572, 542);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listTarefasControl;
    }
}
