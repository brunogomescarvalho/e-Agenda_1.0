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
            textId = new TextBox();
            labelId = new Label();
            textDescricao = new TextBox();
            labelTitulo = new Label();
            labelPrioridade = new Label();
            comboBoxPrioridade = new ComboBox();
            btnCancelar = new Button();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // textId
            // 
            textId.Location = new Point(134, 37);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(125, 27);
            textId.TabIndex = 23;
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(18, 37);
            labelId.Name = "labelId";
            labelId.Size = new Size(88, 28);
            labelId.TabIndex = 22;
            labelId.Text = "Número:";
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(131, 89);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(372, 27);
            textDescricao.TabIndex = 21;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(18, 89);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(66, 28);
            labelTitulo.TabIndex = 20;
            labelTitulo.Text = "Título:";
            // 
            // labelPrioridade
            // 
            labelPrioridade.AutoSize = true;
            labelPrioridade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrioridade.Location = new Point(18, 142);
            labelPrioridade.Name = "labelPrioridade";
            labelPrioridade.Size = new Size(107, 28);
            labelPrioridade.TabIndex = 19;
            labelPrioridade.Text = "Prioridade:";
            // 
            // comboBoxPrioridade
            // 
            comboBoxPrioridade.FormattingEnabled = true;
            comboBoxPrioridade.Location = new Point(131, 142);
            comboBoxPrioridade.Name = "comboBoxPrioridade";
            comboBoxPrioridade.Size = new Size(371, 28);
            comboBoxPrioridade.TabIndex = 18;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(408, 202);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 43);
            btnCancelar.TabIndex = 17;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(278, 202);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 43);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 299);
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

        private TextBox textId;
        private Label labelId;
        private TextBox textDescricao;
        private Label labelTitulo;
        private Label labelPrioridade;
        private ComboBox comboBoxPrioridade;
        private Button btnCancelar;
        private Button btnSalvar;
    }
}