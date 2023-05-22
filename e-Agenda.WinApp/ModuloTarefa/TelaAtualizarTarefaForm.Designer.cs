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
            btnSalvar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            textTarefa = new TextBox();
            listItens = new CheckedListBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(402, 301);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 46);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Finalizar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(536, 301);
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
            label1.Location = new Point(19, 34);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 3;
            label1.Text = "Tarefa:";
            // 
            // textTarefa
            // 
            textTarefa.Location = new Point(113, 34);
            textTarefa.Name = "textTarefa";
            textTarefa.ReadOnly = true;
            textTarefa.Size = new Size(520, 27);
            textTarefa.TabIndex = 4;
            // 
            // listItens
            // 
            listItens.CheckOnClick = true;
            listItens.FormattingEnabled = true;
            listItens.Location = new Point(29, 92);
            listItens.MaximumSize = new Size(601, 180);
            listItens.MinimumSize = new Size(601, 180);
            listItens.Name = "listItens";
            listItens.Size = new Size(601, 180);
            listItens.TabIndex = 5;
            // 
            // TelaAtualizarTarefaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 372);
            Controls.Add(listItens);
            Controls.Add(textTarefa);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(706, 419);
            Name = "TelaAtualizarTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label1;
        private TextBox textTarefa;
        private CheckedListBox listItens;
    }
}