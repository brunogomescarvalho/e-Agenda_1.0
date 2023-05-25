namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            btnSalvar = new Button();
            btnCancelar = new Button();
            comboBoxPrioridade = new ComboBox();
            labelPrioridade = new Label();
            labelTitulo = new Label();
            textDescricao = new TextBox();
            labelId = new Label();
            textId = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(272, 191);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 43);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(402, 191);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 43);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // comboBoxPrioridade
            // 
            comboBoxPrioridade.FormattingEnabled = true;
            comboBoxPrioridade.Location = new Point(125, 137);
            comboBoxPrioridade.Name = "comboBoxPrioridade";
            comboBoxPrioridade.Size = new Size(371, 28);
            comboBoxPrioridade.TabIndex = 2;
            // 
            // labelPrioridade
            // 
            labelPrioridade.AutoSize = true;
            labelPrioridade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrioridade.Location = new Point(12, 137);
            labelPrioridade.Name = "labelPrioridade";
            labelPrioridade.Size = new Size(107, 28);
            labelPrioridade.TabIndex = 3;
            labelPrioridade.Text = "Prioridade:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(12, 84);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(66, 28);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "Título:";
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(125, 84);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(372, 27);
            textDescricao.TabIndex = 5;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(12, 32);
            labelId.Name = "labelId";
            labelId.Size = new Size(88, 28);
            labelId.TabIndex = 6;
            labelId.Text = "Número:";
            // 
            // textId
            // 
            textId.Location = new Point(128, 32);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(125, 27);
            textId.TabIndex = 7;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 269);
            Controls.Add(textId);
            Controls.Add(labelId);
            Controls.Add(textDescricao);
            Controls.Add(labelTitulo);
            Controls.Add(labelPrioridade);
            Controls.Add(comboBoxPrioridade);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Button btnCancelar;
        private ComboBox comboBoxPrioridade;
        private Label labelPrioridade;
        private Label labelTitulo;
        private TextBox textDescricao;
        private Label labelId;
        private TextBox textId;
    }
}