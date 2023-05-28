namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaCategoriaForm
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
            labelNumero = new Label();
            textId = new TextBox();
            labelCategoria = new Label();
            textCategoria = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(25, 38);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(66, 20);
            labelNumero.TabIndex = 0;
            labelNumero.Text = "Número:";
            // 
            // textId
            // 
            textId.Location = new Point(106, 31);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(125, 27);
            textId.TabIndex = 1;
            textId.TabStop = false;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(14, 88);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(77, 20);
            labelCategoria.TabIndex = 2;
            labelCategoria.Text = "Categoria:";
            // 
            // textCategoria
            // 
            textCategoria.Location = new Point(106, 85);
            textCategoria.Name = "textCategoria";
            textCategoria.Size = new Size(243, 27);
            textCategoria.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(178, 156);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(74, 44);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(275, 156);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(74, 44);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 243);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(textCategoria);
            Controls.Add(labelCategoria);
            Controls.Add(textId);
            Controls.Add(labelNumero);
            Name = "TelaCategoriaForm";
            Text = "Cadastro Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNumero;
        private TextBox textId;
        private Label labelCategoria;
        private TextBox textCategoria;
        private Button btnSalvar;
        private Button btnCancelar;
    }
}