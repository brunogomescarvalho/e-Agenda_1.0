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
            radiosPanel = new TableLayoutPanel();
            radioBtnTodos = new RadioButton();
            radioBtnProximos = new RadioButton();
            panel1 = new Panel();
            radiosPanel.SuspendLayout();
            panel1.SuspendLayout();
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
            // radiosPanel
            // 
            radiosPanel.ColumnCount = 1;
            radiosPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            radiosPanel.Controls.Add(radioBtnTodos, 0, 0);
            radiosPanel.Controls.Add(radioBtnProximos, 0, 1);
            radiosPanel.Dock = DockStyle.Top;
            radiosPanel.Location = new Point(0, 0);
            radiosPanel.Name = "radiosPanel";
            radiosPanel.RowCount = 2;
            radiosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            radiosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            radiosPanel.Size = new Size(176, 125);
            radiosPanel.TabIndex = 1;
            // 
            // radioBtnTodos
            // 
            radioBtnTodos.AutoSize = true;
            radioBtnTodos.Checked = true;
            radioBtnTodos.Dock = DockStyle.Fill;
            radioBtnTodos.Location = new Point(3, 3);
            radioBtnTodos.Name = "radioBtnTodos";
            radioBtnTodos.Size = new Size(170, 56);
            radioBtnTodos.TabIndex = 0;
            radioBtnTodos.TabStop = true;
            radioBtnTodos.Text = "Todos";
            radioBtnTodos.UseVisualStyleBackColor = true;
            // 
            // radioBtnProximos
            // 
            radioBtnProximos.AutoSize = true;
            radioBtnProximos.Dock = DockStyle.Fill;
            radioBtnProximos.Location = new Point(3, 65);
            radioBtnProximos.Name = "radioBtnProximos";
            radioBtnProximos.Size = new Size(170, 57);
            radioBtnProximos.TabIndex = 1;
            radioBtnProximos.TabStop = true;
            radioBtnProximos.Text = "Próximos";
            radioBtnProximos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radiosPanel);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(595, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(176, 628);
            panel1.TabIndex = 2;
            // 
            // ListaCompromissosControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(listCompromissos);
            Name = "ListaCompromissosControl";
            Size = new Size(771, 628);
            radiosPanel.ResumeLayout(false);
            radiosPanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listCompromissos;
        private TableLayoutPanel radiosPanel;
        private RadioButton radioBtnTodos;
        private RadioButton radioBtnProximos;
        private Panel panel1;
    }
}
