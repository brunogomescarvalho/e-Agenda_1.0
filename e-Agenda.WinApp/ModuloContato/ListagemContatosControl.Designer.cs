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
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            listContatos = new DataGridView();
            IdContato = new DataGridViewTextBoxColumn();
            NomeContato = new DataGridViewTextBoxColumn();
            TeleContato = new DataGridViewTextBoxColumn();
            EmailContato = new DataGridViewTextBoxColumn();
            EmpresaContato = new DataGridViewTextBoxColumn();
            CargoContato = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)listContatos).BeginInit();
            SuspendLayout();
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Nome
            // 
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 125;
            // 
            // Telefone
            // 
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 6;
            Telefone.Name = "Telefone";
            Telefone.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Telefone";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // listContatos
            // 
            listContatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listContatos.Columns.AddRange(new DataGridViewColumn[] { IdContato, NomeContato, TeleContato, EmailContato, EmpresaContato, CargoContato });
            listContatos.Dock = DockStyle.Fill;
            listContatos.Location = new Point(0, 0);
            listContatos.MultiSelect = false;
            listContatos.Name = "listContatos";
            listContatos.RowHeadersWidth = 51;
            listContatos.RowTemplate.Height = 29;
            listContatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listContatos.Size = new Size(505, 428);
            listContatos.TabIndex = 0;
            // 
            // IdContato
            // 
            IdContato.HeaderText = "Id";
            IdContato.MinimumWidth = 6;
            IdContato.Name = "IdContato";
            IdContato.Width = 125;
            // 
            // NomeContato
            // 
            NomeContato.HeaderText = "Nome";
            NomeContato.MinimumWidth = 6;
            NomeContato.Name = "NomeContato";
            NomeContato.Width = 125;
            // 
            // TeleContato
            // 
            TeleContato.HeaderText = "Telefone";
            TeleContato.MinimumWidth = 6;
            TeleContato.Name = "TeleContato";
            TeleContato.Width = 125;
            // 
            // EmailContato
            // 
            EmailContato.HeaderText = "Email";
            EmailContato.MinimumWidth = 6;
            EmailContato.Name = "EmailContato";
            EmailContato.Width = 125;
            // 
            // EmpresaContato
            // 
            EmpresaContato.HeaderText = "Empresa";
            EmpresaContato.MinimumWidth = 6;
            EmpresaContato.Name = "EmpresaContato";
            EmpresaContato.Width = 125;
            // 
            // CargoContato
            // 
            CargoContato.HeaderText = "Cargo";
            CargoContato.MinimumWidth = 6;
            CargoContato.Name = "CargoContato";
            CargoContato.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "ID";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Nome";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Telefone";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // ListagemContatosControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listContatos);
            Name = "ListagemContatosControl";
            Size = new Size(505, 428);
            ((System.ComponentModel.ISupportInitialize)listContatos).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView listContatos;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn IdContato;
        private DataGridViewTextBoxColumn NomeContato;
        private DataGridViewTextBoxColumn TeleContato;
        private DataGridViewTextBoxColumn EmailContato;
        private DataGridViewTextBoxColumn EmpresaContato;
        private DataGridViewTextBoxColumn CargoContato;
    }
}
