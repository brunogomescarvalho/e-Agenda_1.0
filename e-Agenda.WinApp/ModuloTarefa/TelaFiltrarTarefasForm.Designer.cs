namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaFiltrarTarefasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelOpcoes = new TableLayoutPanel();
            btnTodasTarefas = new RadioButton();
            btnPendentes = new RadioButton();
            btnConcluidas = new RadioButton();
            btnFiltrar = new Button();
            btnCancelar = new Button();
            panelOpcoes.SuspendLayout();
            SuspendLayout();
            // 
            // panelOpcoes
            // 
            panelOpcoes.ColumnCount = 1;
            panelOpcoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            panelOpcoes.Controls.Add(btnTodasTarefas, 0, 0);
            panelOpcoes.Controls.Add(btnPendentes, 0, 1);
            panelOpcoes.Controls.Add(btnConcluidas, 0, 2);
            panelOpcoes.Location = new Point(53, 33);
            panelOpcoes.Name = "panelOpcoes";
            panelOpcoes.RowCount = 3;
            panelOpcoes.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelOpcoes.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelOpcoes.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            panelOpcoes.Size = new Size(321, 145);
            panelOpcoes.TabIndex = 0;
            // 
            // btnTodasTarefas
            // 
            btnTodasTarefas.AutoSize = true;
            btnTodasTarefas.Dock = DockStyle.Fill;
            btnTodasTarefas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTodasTarefas.Location = new Point(3, 3);
            btnTodasTarefas.Name = "btnTodasTarefas";
            btnTodasTarefas.Size = new Size(315, 42);
            btnTodasTarefas.TabIndex = 0;
            btnTodasTarefas.TabStop = true;
            btnTodasTarefas.Tag = "todas";
            btnTodasTarefas.Text = "Visualizar Todas as Tarefas";
            btnTodasTarefas.UseVisualStyleBackColor = true;
            // 
            // btnPendentes
            // 
            btnPendentes.AutoSize = true;
            btnPendentes.Dock = DockStyle.Fill;
            btnPendentes.Location = new Point(3, 51);
            btnPendentes.Name = "btnPendentes";
            btnPendentes.Size = new Size(315, 42);
            btnPendentes.TabIndex = 1;
            btnPendentes.TabStop = true;
            btnPendentes.Tag = "pendentes";
            btnPendentes.Text = "Visualizar Tarefas Pendentes";
            btnPendentes.UseVisualStyleBackColor = true;
            // 
            // btnConcluidas
            // 
            btnConcluidas.AutoSize = true;
            btnConcluidas.Dock = DockStyle.Fill;
            btnConcluidas.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnConcluidas.Location = new Point(3, 99);
            btnConcluidas.Name = "btnConcluidas";
            btnConcluidas.Size = new Size(315, 43);
            btnConcluidas.TabIndex = 2;
            btnConcluidas.TabStop = true;
            btnConcluidas.Tag = "concluidas";
            btnConcluidas.Text = "Visualizar Tarefas Concluídas";
            btnConcluidas.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(151, 206);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(94, 47);
            btnFiltrar.TabIndex = 1;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(282, 206);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 47);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltrarTarefasForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 279);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(panelOpcoes);
            MaximizeBox = false;
            MaximumSize = new Size(429, 326);
            MinimizeBox = false;
            MinimumSize = new Size(429, 326);
            Name = "TelaFiltrarTarefasForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtrar Tarefas";
            panelOpcoes.ResumeLayout(false);
            panelOpcoes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel panelOpcoes;
        private RadioButton btnTodasTarefas;
        private RadioButton btnPendentes;
        private RadioButton btnConcluidas;
        private Button btnFiltrar;
        private Button btnCancelar;
    }
}