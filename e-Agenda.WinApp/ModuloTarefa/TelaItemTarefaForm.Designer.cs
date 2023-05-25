namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaItemTarefaForm
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
            btnIncluir = new Button();
            labelDescricao = new Label();
            textDescricao = new TextBox();
            listItens = new DataGridView();
            descricao = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            labelPrioridade = new Label();
            labelProgresso = new Label();
            labelTitulo = new Label();
            labelId = new Label();
            textPrioridade = new TextBox();
            textProgresso = new TextBox();
            textTitulo = new TextBox();
            textNumero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)listItens).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(305, 531);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 45);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(421, 531);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(420, 173);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(76, 36);
            btnIncluir.TabIndex = 12;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // labelDescricao
            // 
            labelDescricao.AutoSize = true;
            labelDescricao.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelDescricao.Location = new Point(18, 183);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(87, 23);
            labelDescricao.TabIndex = 10;
            labelDescricao.Text = "Descrição:";
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(113, 179);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(301, 27);
            textDescricao.TabIndex = 11;
            // 
            // listItens
            // 
            listItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listItens.Columns.AddRange(new DataGridViewColumn[] { descricao, status });
            listItens.Location = new Point(29, 240);
            listItens.MultiSelect = false;
            listItens.Name = "listItens";
            listItens.ReadOnly = true;
            listItens.RowHeadersVisible = false;
            listItens.RowHeadersWidth = 51;
            listItens.RowTemplate.Height = 29;
            listItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listItens.Size = new Size(467, 276);
            listItens.TabIndex = 16;
            // 
            // descricao
            // 
            descricao.HeaderText = "Descrição";
            descricao.MinimumWidth = 6;
            descricao.Name = "descricao";
            descricao.ReadOnly = true;
            descricao.Width = 125;
            // 
            // status
            // 
            status.HeaderText = "Status";
            status.MinimumWidth = 6;
            status.Name = "status";
            status.ReadOnly = true;
            status.Width = 125;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelPrioridade);
            panel1.Controls.Add(labelProgresso);
            panel1.Controls.Add(labelTitulo);
            panel1.Controls.Add(labelId);
            panel1.Controls.Add(textPrioridade);
            panel1.Controls.Add(textProgresso);
            panel1.Controls.Add(textTitulo);
            panel1.Controls.Add(textNumero);
            panel1.Location = new Point(29, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 130);
            panel1.TabIndex = 17;
            // 
            // labelPrioridade
            // 
            labelPrioridade.AutoSize = true;
            labelPrioridade.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrioridade.Location = new Point(8, 89);
            labelPrioridade.Name = "labelPrioridade";
            labelPrioridade.Size = new Size(92, 23);
            labelPrioridade.TabIndex = 14;
            labelPrioridade.Text = "Prioridade:";
            // 
            // labelProgresso
            // 
            labelProgresso.AutoSize = true;
            labelProgresso.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelProgresso.Location = new Point(234, 13);
            labelProgresso.Name = "labelProgresso";
            labelProgresso.Size = new Size(89, 23);
            labelProgresso.TabIndex = 13;
            labelProgresso.Text = "Progresso:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(18, 55);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(57, 23);
            labelTitulo.TabIndex = 12;
            labelTitulo.Text = "Título:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(12, 17);
            labelId.Name = "labelId";
            labelId.Size = new Size(77, 23);
            labelId.TabIndex = 11;
            labelId.Text = "Número:";
            // 
            // textPrioridade
            // 
            textPrioridade.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textPrioridade.Location = new Point(111, 88);
            textPrioridade.Name = "textPrioridade";
            textPrioridade.ReadOnly = true;
            textPrioridade.Size = new Size(148, 30);
            textPrioridade.TabIndex = 3;
            // 
            // textProgresso
            // 
            textProgresso.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textProgresso.Location = new Point(329, 13);
            textProgresso.Name = "textProgresso";
            textProgresso.ReadOnly = true;
            textProgresso.Size = new Size(125, 30);
            textProgresso.TabIndex = 2;
            // 
            // textTitulo
            // 
            textTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textTitulo.Location = new Point(111, 51);
            textTitulo.Name = "textTitulo";
            textTitulo.ReadOnly = true;
            textTitulo.Size = new Size(343, 30);
            textTitulo.TabIndex = 1;
            // 
            // textNumero
            // 
            textNumero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textNumero.Location = new Point(111, 9);
            textNumero.Name = "textNumero";
            textNumero.ReadOnly = true;
            textNumero.Size = new Size(86, 30);
            textNumero.TabIndex = 0;
            // 
            // TelaItemTarefaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 598);
            Controls.Add(panel1);
            Controls.Add(listItens);
            Controls.Add(labelDescricao);
            Controls.Add(btnIncluir);
            Controls.Add(textDescricao);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Item Tarefa";
            ((System.ComponentModel.ISupportInitialize)listItens).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnIncluir;
        private Label labelDescricao;
        private TextBox textDescricao;
        private DataGridView listItens;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn status;
        private Panel panel1;
        private TextBox textPrioridade;
        private TextBox textProgresso;
        private TextBox textTitulo;
        private TextBox textNumero;
        private Label labelPrioridade;
        private Label labelProgresso;
        private Label labelTitulo;
        private Label labelId;
    }
}