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
            textBox1 = new TextBox();
            listDespesas = new ListBox();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(47, 39);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(77, 20);
            labelCategoria.TabIndex = 0;
            labelCategoria.Text = "Categoria:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 42);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(354, 27);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            // 
            // listDespesas
            // 
            listDespesas.FormattingEnabled = true;
            listDespesas.ItemHeight = 20;
            listDespesas.Location = new Point(47, 111);
            listDespesas.Name = "listDespesas";
            listDespesas.Size = new Size(444, 304);
            listDespesas.TabIndex = 2;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(397, 442);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(94, 46);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // TelaVisualizarPorCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 515);
            Controls.Add(btnFechar);
            Controls.Add(listDespesas);
            Controls.Add(textBox1);
            Controls.Add(labelCategoria);
            Name = "TelaVisualizarPorCategoria";
            Text = "Visualizar Despesas Por Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCategoria;
        private TextBox textBox1;
        private ListBox listDespesas;
        private Button btnFechar;
    }
}