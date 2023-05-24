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
            listTarefasControl = new DataGridView();
            idTarefa = new DataGridViewTextBoxColumn();
            TituloTarefa = new DataGridViewTextBoxColumn();
            PrioridadeTarefa = new DataGridViewTextBoxColumn();
            DataAberturaTarefa = new DataGridViewTextBoxColumn();
            DataConclusaoTarefa = new DataGridViewTextBoxColumn();
            PorcentagemTarefa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listTarefasControl).BeginInit();
            SuspendLayout();
            // 
            // listTarefasControl
            // 
            listTarefasControl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listTarefasControl.Columns.AddRange(new DataGridViewColumn[] { idTarefa, TituloTarefa, PrioridadeTarefa, DataAberturaTarefa, DataConclusaoTarefa, PorcentagemTarefa });
            listTarefasControl.Dock = DockStyle.Fill;
            listTarefasControl.Location = new Point(0, 0);
            listTarefasControl.MultiSelect = false;
            listTarefasControl.Name = "listTarefasControl";
            listTarefasControl.RowHeadersWidth = 51;
            listTarefasControl.RowTemplate.Height = 29;
            listTarefasControl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listTarefasControl.Size = new Size(572, 542);
            listTarefasControl.TabIndex = 0;
            // 
            // idTarefa
            // 
            idTarefa.HeaderText = "Id";
            idTarefa.MinimumWidth = 6;
            idTarefa.Name = "idTarefa";
            idTarefa.ReadOnly = true;
            idTarefa.Width = 125;
            // 
            // TituloTarefa
            // 
            TituloTarefa.HeaderText = "Título";
            TituloTarefa.MinimumWidth = 6;
            TituloTarefa.Name = "TituloTarefa";
            TituloTarefa.ReadOnly = true;
            TituloTarefa.Width = 125;
            // 
            // PrioridadeTarefa
            // 
            PrioridadeTarefa.HeaderText = "Prioridade";
            PrioridadeTarefa.MinimumWidth = 6;
            PrioridadeTarefa.Name = "PrioridadeTarefa";
            PrioridadeTarefa.ReadOnly = true;
            PrioridadeTarefa.Width = 125;
            // 
            // DataAberturaTarefa
            // 
            DataAberturaTarefa.HeaderText = "Data Abertura";
            DataAberturaTarefa.MinimumWidth = 6;
            DataAberturaTarefa.Name = "DataAberturaTarefa";
            DataAberturaTarefa.ReadOnly = true;
            DataAberturaTarefa.Width = 125;
            // 
            // DataConclusaoTarefa
            // 
            DataConclusaoTarefa.HeaderText = "Data Conclusão";
            DataConclusaoTarefa.MinimumWidth = 6;
            DataConclusaoTarefa.Name = "DataConclusaoTarefa";
            DataConclusaoTarefa.ReadOnly = true;
            DataConclusaoTarefa.Width = 125;
            // 
            // PorcentagemTarefa
            // 
            PorcentagemTarefa.HeaderText = "Porcentagem";
            PorcentagemTarefa.MinimumWidth = 6;
            PorcentagemTarefa.Name = "PorcentagemTarefa";
            PorcentagemTarefa.ReadOnly = true;
            PorcentagemTarefa.Width = 125;
            // 
            // ListagemTarefasControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listTarefasControl);
            Name = "ListagemTarefasControl";
            Size = new Size(572, 542);
            ((System.ComponentModel.ISupportInitialize)listTarefasControl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView listTarefasControl;
        private DataGridViewTextBoxColumn idTarefa;
        private DataGridViewTextBoxColumn TituloTarefa;
        private DataGridViewTextBoxColumn PrioridadeTarefa;
        private DataGridViewTextBoxColumn DataAberturaTarefa;
        private DataGridViewTextBoxColumn DataConclusaoTarefa;
        private DataGridViewTextBoxColumn PorcentagemTarefa;
    }
}
