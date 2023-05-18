namespace e_Agenda.WinApp.ModuloContato
{
    partial class ListagemContatosControl
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
            listContatos = new ListBox();
            SuspendLayout();
            // 
            // listContatos
            // 
            listContatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listContatos.FormattingEnabled = true;
            listContatos.ItemHeight = 20;
            listContatos.Location = new Point(0, -1);
            listContatos.Name = "listContatos";
            listContatos.Size = new Size(505, 424);
            listContatos.TabIndex = 1;
            // 
            // ListagemContatosControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listContatos);
            Name = "ListagemContatosControl";
            Size = new Size(505, 428);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listContatos;
    }
}
