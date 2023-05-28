namespace e_Agenda.WinApp.Modulo_Despesa
{
    partial class TelaDespesaForm
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
            labelId = new Label();
            labelDescricao = new Label();
            labelValor = new Label();
            labelData = new Label();
            labelPgto = new Label();
            groupCategorias = new GroupBox();
            listCategorias = new CheckedListBox();
            textId = new TextBox();
            textDescricao = new TextBox();
            textValor = new NumericUpDown();
            textData = new DateTimePicker();
            comboFormaPgto = new ComboBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            groupCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textValor).BeginInit();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(66, 50);
            labelId.Name = "labelId";
            labelId.Size = new Size(66, 20);
            labelId.TabIndex = 0;
            labelId.Text = "Número:";
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Location = new Point(55, 90);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(77, 20);
            labelDescricao.TabIndex = 1;
            labelDescricao.Text = "Descrição:";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(86, 135);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(46, 20);
            labelValor.TabIndex = 2;
            labelValor.Text = "Valor:";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(88, 180);
            labelData.Name = "labelData";
            labelData.Size = new Size(44, 20);
            labelData.TabIndex = 3;
            labelData.Text = "Data:";
            // 
            // labelPgto
            // 
            labelPgto.AutoSize = true;
            labelPgto.Location = new Point(23, 225);
            labelPgto.Name = "labelPgto";
            labelPgto.Size = new Size(109, 20);
            labelPgto.TabIndex = 4;
            labelPgto.Text = "Forma de Pgto:";
            // 
            // groupCategorias
            // 
            groupCategorias.Controls.Add(listCategorias);
            groupCategorias.Location = new Point(23, 285);
            groupCategorias.Name = "groupCategorias";
            groupCategorias.Size = new Size(566, 352);
            groupCategorias.TabIndex = 5;
            groupCategorias.TabStop = false;
            groupCategorias.Text = "Categorias";
            // 
            // listCategorias
            // 
            listCategorias.Dock = DockStyle.Fill;
            listCategorias.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listCategorias.FormattingEnabled = true;
            listCategorias.Location = new Point(3, 23);
            listCategorias.Name = "listCategorias";
            listCategorias.Size = new Size(560, 326);
            listCategorias.TabIndex = 0;
            // 
            // textId
            // 
            textId.Location = new Point(142, 43);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(125, 27);
            textId.TabIndex = 6;
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(142, 83);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(444, 27);
            textDescricao.TabIndex = 7;
            // 
            // textValor
            // 
            textValor.Location = new Point(142, 128);
            textValor.Name = "textValor";
            textValor.Size = new Size(150, 27);
            textValor.TabIndex = 8;
            // 
            // textData
            // 
            textData.Format = DateTimePickerFormat.Short;
            textData.Location = new Point(138, 173);
            textData.Name = "textData";
            textData.Size = new Size(154, 27);
            textData.TabIndex = 9;
            // 
            // comboFormaPgto
            // 
            comboFormaPgto.FormattingEnabled = true;
            comboFormaPgto.Location = new Point(138, 217);
            comboFormaPgto.Name = "comboFormaPgto";
            comboFormaPgto.Size = new Size(226, 28);
            comboFormaPgto.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(395, 668);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(86, 43);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(497, 668);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 43);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 732);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(comboFormaPgto);
            Controls.Add(textData);
            Controls.Add(textValor);
            Controls.Add(textDescricao);
            Controls.Add(textId);
            Controls.Add(groupCategorias);
            Controls.Add(labelPgto);
            Controls.Add(labelData);
            Controls.Add(labelValor);
            Controls.Add(labelDescricao);
            Controls.Add(labelId);
            Name = "TelaDespesaForm";
            Text = "Controle de Despesas";
            groupCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Label labelDescricao;
        private Label labelValor;
        private Label labelData;
        private Label labelPgto;
        private GroupBox groupCategorias;
        private CheckedListBox listCategorias;
        private TextBox textId;
        private TextBox textDescricao;
        private NumericUpDown textValor;
        private DateTimePicker textData;
        private ComboBox comboFormaPgto;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}