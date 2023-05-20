namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaAtualizarTarefaForm
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
            listItens = new CheckedListBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            textTarefa = new TextBox();
            SuspendLayout();
            // 
            // listItens
            // 
            listItens.CheckOnClick = true;
            listItens.FormattingEnabled = true;
            listItens.Location = new Point(36, 101);
            listItens.Name = "listItens";
            listItens.Size = new Size(583, 290);
            listItens.TabIndex = 0;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(391, 418);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 46);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(525, 418);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 46);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 43);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 3;
            label1.Text = "Tarefa:";
            // 
            // textTarefa
            // 
            textTarefa.Location = new Point(130, 43);
            textTarefa.Name = "textTarefa";
            textTarefa.ReadOnly = true;
            textTarefa.Size = new Size(489, 27);
            textTarefa.TabIndex = 4;
            // 
            // TelaAtualizarTarefaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 500);
            Controls.Add(textTarefa);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(listItens);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAtualizarTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox listItens;
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label1;
        private TextBox textTarefa;
    }
}