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
            textPrioridade = new ComboBox();
            labelPrioridade = new Label();
            labelTitulo = new Label();
            textDescricao = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(312, 150);
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
            btnCancelar.Location = new Point(426, 150);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 43);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textPrioridade
            // 
            textPrioridade.FormattingEnabled = true;
            textPrioridade.Items.AddRange(new object[] { "Alta", "Baixa", "Normal" });
            textPrioridade.Location = new Point(167, 92);
            textPrioridade.Name = "textPrioridade";
            textPrioridade.Size = new Size(353, 28);
            textPrioridade.TabIndex = 2;
            // 
            // labelPrioridade
            // 
            labelPrioridade.AutoSize = true;
            labelPrioridade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrioridade.Location = new Point(35, 88);
            labelPrioridade.Name = "labelPrioridade";
            labelPrioridade.Size = new Size(107, 28);
            labelPrioridade.TabIndex = 3;
            labelPrioridade.Text = "Prioridade:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(35, 35);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(66, 28);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "Título:";
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(116, 39);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(404, 27);
            textDescricao.TabIndex = 5;
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 228);
            Controls.Add(textDescricao);
            Controls.Add(labelTitulo);
            Controls.Add(labelPrioridade);
            Controls.Add(textPrioridade);
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
        private ComboBox textPrioridade;
        private Label labelPrioridade;
        private Label labelTitulo;
        private TextBox textDescricao;
    }
}