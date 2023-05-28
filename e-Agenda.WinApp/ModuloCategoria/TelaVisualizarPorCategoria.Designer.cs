namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaVisualizarPorCategoria
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
            labelCategoria = new Label();
            textCategoria = new TextBox();
            btnFechar = new Button();
            groupDespesas = new GroupBox();
            listDespesas = new ListBox();
            groupDespesas.SuspendLayout();
            SuspendLayout();
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(22, 39);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(77, 20);
            labelCategoria.TabIndex = 0;
            labelCategoria.Text = "Categoria:";
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(112, 42);
            textCategoria.Name = "textCategoria";
            textCategoria.ReadOnly = true;
            textCategoria.Size = new Size(577, 27);
            textCategoria.TabIndex = 1;
            textCategoria.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(595, 501);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 46);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // groupDespesas
            // 
            groupDespesas.Controls.Add(listDespesas);
            groupDespesas.Location = new Point(25, 102);
            groupDespesas.Name = "groupDespesas";
            groupDespesas.Size = new Size(667, 363);
            groupDespesas.TabIndex = 4;
            groupDespesas.TabStop = false;
            groupDespesas.Text = "Despesas";
            // 
            // listDespesas
            // 
            listDespesas.Dock = DockStyle.Fill;
            listDespesas.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            listDespesas.FormattingEnabled = true;
            listDespesas.ItemHeight = 20;
            listDespesas.Location = new Point(3, 23);
            listDespesas.Name = "listDespesas";
            listDespesas.Size = new Size(661, 337);
            listDespesas.TabIndex = 3;
            // 
            // TelaVisualizarPorCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 580);
            Controls.Add(groupDespesas);
            Controls.Add(btnFechar);
            Controls.Add(textCategoria);
            Controls.Add(labelCategoria);
            Name = "TelaVisualizarPorCategoria";
            Text = "Visualização de Despesas da Categoria";
            groupDespesas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCategoria;
        private TextBox textCategoria;
        private Button btnFechar;
        private GroupBox groupDespesas;
        private ListBox listDespesas;
    }
}