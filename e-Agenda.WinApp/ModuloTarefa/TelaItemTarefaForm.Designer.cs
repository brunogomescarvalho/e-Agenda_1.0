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
            tabelaItens = new DataGridView();
            panelTarefa = new Panel();
            labelPrioridade = new Label();
            labelProgresso = new Label();
            labelTitulo = new Label();
            labelId = new Label();
            textPrioridade = new TextBox();
            textProgresso = new TextBox();
            textTitulo = new TextBox();
            textNumero = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tabelaItens).BeginInit();
            panelTarefa.SuspendLayout();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(391, 463);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 45);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(507, 463);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 45);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(462, 162);
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
            labelDescricao.Location = new Point(60, 172);
            labelDescricao.Name = "labelDescricao";
            labelDescricao.Size = new Size(87, 23);
            labelDescricao.TabIndex = 10;
            labelDescricao.Text = "Descrição:";
            // 
            // textDescricao
            // 
            textDescricao.Location = new Point(155, 168);
            textDescricao.Name = "textDescricao";
            textDescricao.Size = new Size(301, 27);
            textDescricao.TabIndex = 11;
            // 
            // tabelaItens
            // 
            tabelaItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabelaItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaItens.Location = new Point(33, 223);
            tabelaItens.MultiSelect = false;
            tabelaItens.Name = "tabelaItens";
            tabelaItens.ReadOnly = true;
            tabelaItens.RowHeadersVisible = false;
            tabelaItens.RowHeadersWidth = 51;
            tabelaItens.RowTemplate.Height = 29;
            tabelaItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tabelaItens.Size = new Size(537, 218);
            tabelaItens.TabIndex = 16;
            // 
            // panelTarefa
            // 
            panelTarefa.BackColor = Color.LightGray;
            panelTarefa.BorderStyle = BorderStyle.FixedSingle;
            panelTarefa.Controls.Add(labelPrioridade);
            panelTarefa.Controls.Add(labelProgresso);
            panelTarefa.Controls.Add(labelTitulo);
            panelTarefa.Controls.Add(labelId);
            panelTarefa.Controls.Add(textPrioridade);
            panelTarefa.Controls.Add(textProgresso);
            panelTarefa.Controls.Add(textTitulo);
            panelTarefa.Controls.Add(textNumero);
            panelTarefa.Location = new Point(22, 27);
            panelTarefa.Name = "panelTarefa";
            panelTarefa.Size = new Size(560, 110);
            panelTarefa.TabIndex = 17;
            // 
            // labelPrioridade
            // 
            labelPrioridade.AutoSize = true;
            labelPrioridade.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrioridade.Location = new Point(352, 25);
            labelPrioridade.Name = "labelPrioridade";
            labelPrioridade.Size = new Size(81, 20);
            labelPrioridade.TabIndex = 14;
            labelPrioridade.Text = "Prioridade:";
            // 
            // labelProgresso
            // 
            labelProgresso.AutoSize = true;
            labelProgresso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelProgresso.Location = new Point(176, 25);
            labelProgresso.Name = "labelProgresso";
            labelProgresso.Size = new Size(77, 20);
            labelProgresso.TabIndex = 13;
            labelProgresso.Text = "Progresso:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitulo.Location = new Point(26, 63);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(50, 20);
            labelTitulo.TabIndex = 12;
            labelTitulo.Text = "Título:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(10, 20);
            labelId.Name = "labelId";
            labelId.Size = new Size(66, 20);
            labelId.TabIndex = 11;
            labelId.Text = "Número:";
            // 
            // textPrioridade
            // 
            textPrioridade.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textPrioridade.Location = new Point(439, 20);
            textPrioridade.Name = "textPrioridade";
            textPrioridade.ReadOnly = true;
            textPrioridade.Size = new Size(97, 30);
            textPrioridade.TabIndex = 3;
            // 
            // textProgresso
            // 
            textProgresso.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textProgresso.Location = new Point(259, 17);
            textProgresso.Name = "textProgresso";
            textProgresso.ReadOnly = true;
            textProgresso.Size = new Size(87, 30);
            textProgresso.TabIndex = 2;
            // 
            // textTitulo
            // 
            textTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textTitulo.Location = new Point(84, 58);
            textTitulo.Name = "textTitulo";
            textTitulo.ReadOnly = true;
            textTitulo.Size = new Size(452, 30);
            textTitulo.TabIndex = 1;
            // 
            // textNumero
            // 
            textNumero.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textNumero.Location = new Point(84, 17);
            textNumero.Name = "textNumero";
            textNumero.ReadOnly = true;
            textNumero.Size = new Size(86, 30);
            textNumero.TabIndex = 0;
            // 
            // TelaItemTarefaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 533);
            Controls.Add(panelTarefa);
            Controls.Add(tabelaItens);
            Controls.Add(labelDescricao);
            Controls.Add(btnIncluir);
            Controls.Add(textDescricao);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaItemTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Item Tarefa";
            ((System.ComponentModel.ISupportInitialize)tabelaItens).EndInit();
            panelTarefa.ResumeLayout(false);
            panelTarefa.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnIncluir;
        private Label labelDescricao;
        private TextBox textDescricao;
        private DataGridView tabelaItens;
        private Panel panelTarefa;
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