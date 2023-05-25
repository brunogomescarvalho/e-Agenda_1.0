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
            radioButtonPassados = new RadioButton();
            radioButtonDatas = new RadioButton();
            buttonFiltrar = new Button();
            buttonCancelar = new Button();
            panelDatas = new Panel();
            labelDataFinal = new Label();
            labelDataInicial = new Label();
            dateTimeFinal = new DateTimePicker();
            dateTimeInicial = new DateTimePicker();
            tableLayoutPanel1.SuspendLayout();
            panelDatas.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(radioButtonDatas, 0, 4);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(500, 184);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonTodos
            // 
            radioButtonTodos.AutoSize = true;
            radioButtonTodos.Checked = true;
            radioButtonTodos.Dock = DockStyle.Fill;
            radioButtonTodos.Location = new Point(3, 3);
            radioButtonTodos.Name = "radioButtonTodos";
            radioButtonTodos.Size = new Size(494, 30);
            radioButtonTodos.TabIndex = 0;
            radioButtonTodos.TabStop = true;
            radioButtonTodos.Tag = "Todos";
            radioButtonTodos.Text = "Visualizar todos os compromissos ";
            radioButtonTodos.UseVisualStyleBackColor = true;
            // 
            // radioButtonHoje
            // 
            radioButtonHoje.AutoSize = true;
            radioButtonHoje.Dock = DockStyle.Fill;
            radioButtonHoje.Location = new Point(3, 39);
            radioButtonHoje.Name = "radioButtonHoje";
            radioButtonHoje.Size = new Size(494, 30);
            radioButtonHoje.TabIndex = 1;
            radioButtonHoje.Tag = "Hoje";
            radioButtonHoje.Text = "Visualizar compromissos para hoje";
            radioButtonHoje.UseVisualStyleBackColor = true;
            // 
            // radioButtonProximos
            // 
            radioButtonProximos.AutoSize = true;
            radioButtonProximos.Dock = DockStyle.Fill;
            radioButtonProximos.Location = new Point(3, 75);
            radioButtonProximos.Name = "radioButtonProximos";
            radioButtonProximos.Size = new Size(494, 30);
            radioButtonProximos.TabIndex = 2;
            radioButtonProximos.Tag = "Próximos";
            radioButtonProximos.Text = "Visualizar próximos compromissos";
            radioButtonProximos.UseVisualStyleBackColor = true;
            // 
            // radioButtonPassados
            // 
            radioButtonPassados.AutoSize = true;
            radioButtonPassados.Dock = DockStyle.Fill;
            radioButtonPassados.Location = new Point(3, 111);
            radioButtonPassados.Name = "radioButtonPassados";
            radioButtonPassados.Size = new Size(494, 30);
            radioButtonPassados.TabIndex = 3;
            radioButtonPassados.TabStop = true;
            radioButtonPassados.Tag = "Passados";
            radioButtonPassados.Text = "Visualizar compromissos passados";
            radioButtonPassados.UseVisualStyleBackColor = true;
            // 
            // radioButtonDatas
            // 
            radioButtonDatas.AutoSize = true;
            radioButtonDatas.Dock = DockStyle.Fill;
            radioButtonDatas.Location = new Point(3, 147);
            radioButtonDatas.Name = "radioButtonDatas";
            radioButtonDatas.Size = new Size(494, 34);
            radioButtonDatas.TabIndex = 4;
            radioButtonDatas.TabStop = true;
            radioButtonDatas.Tag = "Datas";
            radioButtonDatas.Text = "Visualizar Por Datas";
            radioButtonDatas.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.DialogResult = DialogResult.OK;
            buttonFiltrar.Location = new Point(361, 345);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(88, 44);
            buttonFiltrar.TabIndex = 1;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            buttonFiltrar.Click += buttonFiltrar_Click;
            // 
            // buttonCancelar
            // 
            buttonCancelar.DialogResult = DialogResult.Cancel;
            buttonCancelar.Location = new Point(455, 345);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(87, 44);
            buttonCancelar.TabIndex = 2;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // panelDatas
            // 
            panelDatas.Controls.Add(labelDataFinal);
            panelDatas.Controls.Add(labelDataInicial);
            panelDatas.Controls.Add(dateTimeFinal);
            panelDatas.Controls.Add(dateTimeInicial);
            panelDatas.Location = new Point(11, 213);
            panelDatas.Name = "panelDatas";
            panelDatas.Size = new Size(498, 113);
            panelDatas.TabIndex = 3;
            // 
            // labelDataFinal
            // 
            labelDataFinal.AutoSize = true;
            labelDataFinal.Location = new Point(241, 25);
            labelDataFinal.Name = "labelDataFinal";
            labelDataFinal.Size = new Size(76, 20);
            labelDataFinal.TabIndex = 3;
            labelDataFinal.Text = "Data Final";
            // 
            // labelDataInicial
            // 
            labelDataInicial.AutoSize = true;
            labelDataInicial.Location = new Point(24, 25);
            labelDataInicial.Name = "labelDataInicial";
            labelDataInicial.Size = new Size(84, 20);
            labelDataInicial.TabIndex = 2;
            labelDataInicial.Text = "Data Inicial";
            // 
            // dateTimeFinal
            // 
            dateTimeFinal.Format = DateTimePickerFormat.Custom;
            dateTimeFinal.Location = new Point(241, 67);
            dateTimeFinal.Name = "dateTimeFinal";
            dateTimeFinal.Size = new Size(197, 27);
            dateTimeFinal.TabIndex = 1;
            // 
            // dateTimeInicial
            // 
            dateTimeInicial.CalendarMonthBackground = SystemColors.HighlightText;
            dateTimeInicial.Format = DateTimePickerFormat.Short;
            dateTimeInicial.Location = new Point(15, 67);
            dateTimeInicial.Name = "dateTimeInicial";
            dateTimeInicial.Size = new Size(189, 27);
            dateTimeInicial.TabIndex = 0;
            // 
            // TelaFiltroCompromisso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 417);
            Controls.Add(panelDatas);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonFiltrar);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaFiltroCompromisso";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtrar Compromissos";
            TransparencyKey = Color.Gray;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panelDatas.ResumeLayout(false);
            panelDatas.PerformLayout();
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
        private RadioButton radioButtonDatas;
        private Panel panelDatas;
        private Label labelDataFinal;
        private Label labelDataInicial;
        private DateTimePicker dateTimeFinal;
        private DateTimePicker dateTimeInicial;
    }
}