namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroCompromisso
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
            tableLayoutPanel1 = new TableLayoutPanel();
            radioButtonTodos = new RadioButton();
            radioButtonHoje = new RadioButton();
            radioButtonProximos = new RadioButton();
            buttonFiltrar = new Button();
            buttonCancelar = new Button();
            radioButtonPassados = new RadioButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(radioButtonTodos, 0, 0);
            tableLayoutPanel1.Controls.Add(radioButtonHoje, 0, 1);
            tableLayoutPanel1.Controls.Add(radioButtonProximos, 0, 2);
            tableLayoutPanel1.Controls.Add(radioButtonPassados, 0, 3);
            tableLayoutPanel1.Location = new Point(55, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(692, 184);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonTodos
            // 
            radioButtonTodos.AutoSize = true;
            radioButtonTodos.Checked = true;
            radioButtonTodos.Dock = DockStyle.Fill;
            radioButtonTodos.Location = new Point(3, 3);
            radioButtonTodos.Name = "radioButtonTodos";
            radioButtonTodos.Size = new Size(686, 40);
            radioButtonTodos.TabIndex = 0;
            radioButtonTodos.TabStop = true;
            radioButtonTodos.Text = "Todos";
            radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonHoje
            // 
            radioButtonHoje.AutoSize = true;
            radioButtonHoje.Dock = DockStyle.Fill;
            radioButtonHoje.Location = new Point(3, 49);
            radioButtonHoje.Name = "radioButtonHoje";
            radioButtonHoje.Size = new Size(686, 40);
            radioButtonHoje.TabIndex = 1;
            radioButtonHoje.Text = "Hoje";
            radioButtonHoje.UseVisualStyleBackColor = true;
            // 
            // radioButtonProximos
            // 
            radioButtonProximos.AutoSize = true;
            radioButtonProximos.Dock = DockStyle.Fill;
            radioButtonProximos.Location = new Point(3, 95);
            radioButtonProximos.Name = "radioButtonProximos";
            radioButtonProximos.Size = new Size(686, 40);
            radioButtonProximos.TabIndex = 2;
            radioButtonProximos.Text = "Próximos";
            radioButtonProximos.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.DialogResult = DialogResult.OK;
            buttonFiltrar.Location = new Point(521, 337);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(92, 57);
            buttonFiltrar.TabIndex = 1;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(653, 337);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(91, 57);
            buttonCancelar.TabIndex = 2;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // radioButtonPassados
            // 
            radioButtonPassados.AutoSize = true;
            radioButtonPassados.Dock = DockStyle.Fill;
            radioButtonPassados.Location = new Point(3, 141);
            radioButtonPassados.Name = "radioButtonPassados";
            radioButtonPassados.Size = new Size(686, 40);
            radioButtonPassados.TabIndex = 3;
            radioButtonPassados.TabStop = true;
            radioButtonPassados.Text = "Passados";
            radioButtonPassados.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroCompromisso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonFiltrar);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromisso";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtrar Compromissos";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton radioButtonTodos;
        private RadioButton radioButtonHoje;
        private RadioButton radioButtonProximos;
        private RadioButton radioButtonPassados;
        private Button buttonFiltrar;
        private Button buttonCancelar;
    }
}