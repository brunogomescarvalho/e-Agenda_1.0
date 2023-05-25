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
            textTarefa = new TextBox();
            listItens = new CheckedListBox();
            progressoTarefa = new ProgressBar();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(354, 318);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 46);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Finalizar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(449, 318);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 46);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textTarefa
            // 
            textTarefa.Location = new Point(11, 15);
            textTarefa.Name = "textTarefa";
            textTarefa.ReadOnly = true;
            textTarefa.Size = new Size(479, 27);
            textTarefa.TabIndex = 4;
            // 
            // listItens
            // 
            listItens.CheckOnClick = true;
            listItens.FormattingEnabled = true;
            listItens.Location = new Point(12, 123);
            listItens.MaximumSize = new Size(601, 180);
            listItens.Name = "listItens";
            listItens.Size = new Size(511, 180);
            listItens.TabIndex = 5;
            // 
            // progressoTarefa
            // 
            progressoTarefa.Location = new Point(11, 60);
            progressoTarefa.Name = "progressoTarefa";
            progressoTarefa.Size = new Size(479, 22);
            progressoTarefa.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(progressoTarefa);
            panel1.Controls.Add(textTarefa);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(511, 105);
            panel1.TabIndex = 7;
            // 
            // TelaAtualizarTarefaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 394);
            Controls.Add(panel1);
            Controls.Add(listItens);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaAtualizarTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Atualizar Tarefa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSalvar;
        private Button btnCancelar;
        private TextBox textTarefa;
        private CheckedListBox listItens;
        private ProgressBar progressoTarefa;
        private Panel panel1;
    }
}