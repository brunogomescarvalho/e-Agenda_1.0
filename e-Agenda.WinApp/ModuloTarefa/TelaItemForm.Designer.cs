namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaItemForm
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
            btnIncluir = new Button();
            labelDescricao = new Label();
            textDescricao = new TextBox();
            listItens = new ListBox();
            textTarefa = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(403, 451);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 48);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(519, 451);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 48);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(72, 27);
            label1.Name = "label1";
            label1.Size = new Size(67, 28);
            label1.TabIndex = 6;
            label1.Text = "Tarefa:";
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(514, 61);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(99, 40);
            btnIncluir.TabIndex = 12;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescricao.Location = new Point(52, 78);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(87, 23);
            labelDescricao.TabIndex = 10;
            labelDescricao.Text = "Descrição:";
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(145, 74);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(338, 27);
            textDescricao.TabIndex = 11;
            // 
            // listItens
            // 
            listItens.FormattingEnabled = true;
            listItens.ItemHeight = 20;
            listItens.Location = new Point(35, 137);
            listItens.Name = "listItens";
            listItens.Size = new Size(578, 284);
            listItens.TabIndex = 14;
            // 
            // textTarefa
            // 
            textTarefa.Location = new Point(145, 31);
            textTarefa.Name = "textTarefa";
            textTarefa.ReadOnly = true;
            textTarefa.Size = new Size(338, 27);
            textTarefa.TabIndex = 15;
            // 
            // TelaItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 535);
            Controls.Add(textTarefa);
            Controls.Add(labelDescricao);
            Controls.Add(btnIncluir);
            Controls.Add(listItens);
            Controls.Add(textDescricao);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Item Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalvar;
        private Button btnCancelar;
        private Label label1;
        private Button btnIncluir;
        private Label labelDescricao;
        private TextBox textDescricao;
        private ListBox listItens;
        private TextBox textTarefa;
    }
}