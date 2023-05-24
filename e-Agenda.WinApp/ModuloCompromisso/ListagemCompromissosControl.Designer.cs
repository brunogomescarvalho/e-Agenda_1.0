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
            listCompromissos = new DataGridView();
            idCompromisso = new DataGridViewTextBoxColumn();
            AssuntoCompromisso = new DataGridViewTextBoxColumn();
            localCompromisso = new DataGridViewTextBoxColumn();
            dataCompromisso = new DataGridViewTextBoxColumn();
            horaInicio = new DataGridViewTextBoxColumn();
            terminoCompromisso = new DataGridViewTextBoxColumn();
            contato = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listCompromissos).BeginInit();
            SuspendLayout();
            // 
            // listCompromissos
            // 
            listCompromissos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listCompromissos.Columns.AddRange(new DataGridViewColumn[] { idCompromisso, AssuntoCompromisso, localCompromisso, dataCompromisso, horaInicio, terminoCompromisso, contato });
            listCompromissos.Dock = DockStyle.Fill;
            listCompromissos.Location = new Point(0, 0);
            listCompromissos.MultiSelect = false;
            listCompromissos.Name = "listCompromissos";
            listCompromissos.RowHeadersVisible = false;
            listCompromissos.RowHeadersWidth = 51;
            listCompromissos.RowTemplate.Height = 29;
            listCompromissos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listCompromissos.Size = new Size(771, 628);
            listCompromissos.TabIndex = 0;
            // 
            // idCompromisso
            // 
            idCompromisso.HeaderText = "Id";
            idCompromisso.MinimumWidth = 6;
            idCompromisso.Name = "idCompromisso";
            idCompromisso.ReadOnly = true;
            idCompromisso.Width = 125;
            // 
            // AssuntoCompromisso
            // 
            AssuntoCompromisso.HeaderText = "Assunto";
            AssuntoCompromisso.MinimumWidth = 6;
            AssuntoCompromisso.Name = "AssuntoCompromisso";
            AssuntoCompromisso.ReadOnly = true;
            AssuntoCompromisso.Width = 125;
            // 
            // localCompromisso
            // 
            localCompromisso.HeaderText = "Local";
            localCompromisso.MinimumWidth = 6;
            localCompromisso.Name = "localCompromisso";
            localCompromisso.ReadOnly = true;
            localCompromisso.Width = 125;
            // 
            // dataCompromisso
            // 
            dataCompromisso.HeaderText = "Data";
            dataCompromisso.MinimumWidth = 6;
            dataCompromisso.Name = "dataCompromisso";
            dataCompromisso.ReadOnly = true;
            dataCompromisso.Width = 125;
            // 
            // horaInicio
            // 
            horaInicio.HeaderText = "Início";
            horaInicio.MinimumWidth = 6;
            horaInicio.Name = "horaInicio";
            horaInicio.ReadOnly = true;
            horaInicio.Width = 125;
            // 
            // terminoCompromisso
            // 
            terminoCompromisso.HeaderText = "Término";
            terminoCompromisso.MinimumWidth = 6;
            terminoCompromisso.Name = "terminoCompromisso";
            terminoCompromisso.ReadOnly = true;
            terminoCompromisso.Width = 125;
            // 
            // contato
            // 
            contato.HeaderText = "Contato";
            contato.MinimumWidth = 6;
            contato.Name = "contato";
            contato.ReadOnly = true;
            contato.Width = 125;
            // 
            // ListaCompromissosControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listCompromissos);
            Name = "ListaCompromissosControl";
            Size = new Size(771, 628);
            ((System.ComponentModel.ISupportInitialize)listCompromissos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listCompromissos;
        private DataGridViewTextBoxColumn idCompromisso;
        private DataGridViewTextBoxColumn AssuntoCompromisso;
        private DataGridViewTextBoxColumn localCompromisso;
        private DataGridViewTextBoxColumn dataCompromisso;
        private DataGridViewTextBoxColumn horaInicio;
        private DataGridViewTextBoxColumn terminoCompromisso;
        private DataGridViewTextBoxColumn contato;
    }
}
