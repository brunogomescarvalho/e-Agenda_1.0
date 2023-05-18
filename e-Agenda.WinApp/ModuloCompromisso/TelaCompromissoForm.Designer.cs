namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            comboBoxContatos = new ComboBox();
            labelContato = new Label();
            bntSalvar = new Button();
            btnCancelar = new Button();
            labelAssunto = new Label();
            textBoxAssunto = new TextBox();
            labelData = new Label();
            labelLocal = new Label();
            textBoxLocal = new TextBox();
            labelHoraInicial = new Label();
            labelHoraFinal = new Label();
            textHoraFinal = new MaskedTextBox();
            labelId = new Label();
            textId = new TextBox();
            textData = new DateTimePicker();
            textHoraInicial = new MaskedTextBox();
            SuspendLayout();
            // 
            // comboBoxContatos
            // 
            comboBoxContatos.FlatStyle = FlatStyle.Flat;
            comboBoxContatos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxContatos.FormattingEnabled = true;
            comboBoxContatos.IntegralHeight = false;
            comboBoxContatos.Location = new Point(65, 70);
            comboBoxContatos.Name = "comboBoxContatos";
            comboBoxContatos.Size = new Size(674, 28);
            comboBoxContatos.TabIndex = 0;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelContato.Location = new Point(65, 36);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(83, 28);
            labelContato.TabIndex = 1;
            labelContato.Text = "Contato";
            // 
            // bntSalvar
            // 
            bntSalvar.DialogResult = DialogResult.OK;
            bntSalvar.Location = new Point(578, 391);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(70, 44);
            bntSalvar.TabIndex = 7;
            bntSalvar.Text = "Salvar";
            bntSalvar.UseVisualStyleBackColor = true;
            bntSalvar.Click += bntSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(671, 391);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(70, 44);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelAssunto
            // 
            labelAssunto.AutoSize = true;
            labelAssunto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAssunto.Location = new Point(65, 117);
            labelAssunto.Name = "labelAssunto";
            labelAssunto.Size = new Size(82, 28);
            labelAssunto.TabIndex = 4;
            labelAssunto.Text = "Assunto";
            // 
            // textBoxAssunto
            // 
            textBoxAssunto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAssunto.Location = new Point(65, 148);
            textBoxAssunto.Name = "textBoxAssunto";
            textBoxAssunto.Size = new Size(669, 34);
            textBoxAssunto.TabIndex = 1;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.Location = new Point(71, 208);
            labelData.Name = "labelData";
            labelData.Size = new Size(53, 28);
            labelData.TabIndex = 6;
            labelData.Text = "Data";
            // 
            // labelLocal
            // 
            labelLocal.AutoSize = true;
            labelLocal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLocal.Location = new Point(245, 208);
            labelLocal.Name = "labelLocal";
            labelLocal.Size = new Size(57, 28);
            labelLocal.TabIndex = 8;
            labelLocal.Text = "Local";
            // 
            // textBoxLocal
            // 
            textBoxLocal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLocal.Location = new Point(245, 239);
            textBoxLocal.Name = "textBoxLocal";
            textBoxLocal.Size = new Size(489, 34);
            textBoxLocal.TabIndex = 3;
            // 
            // labelHoraInicial
            // 
            labelHoraInicial.AutoSize = true;
            labelHoraInicial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraInicial.Location = new Point(65, 317);
            labelHoraInicial.Name = "labelHoraInicial";
            labelHoraInicial.Size = new Size(134, 28);
            labelHoraInicial.TabIndex = 10;
            labelHoraInicial.Text = "Horário Inicial";
            // 
            // labelHoraFinal
            // 
            labelHoraFinal.AutoSize = true;
            labelHoraFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraFinal.Location = new Point(438, 317);
            labelHoraFinal.Name = "labelHoraFinal";
            labelHoraFinal.Size = new Size(125, 28);
            labelHoraFinal.TabIndex = 11;
            labelHoraFinal.Text = "Horário Final";
            // 
            // textHoraFinal
            // 
            textHoraFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textHoraFinal.Location = new Point(569, 311);
            textHoraFinal.Mask = "00:00";
            textHoraFinal.Name = "textHoraFinal";
            textHoraFinal.Size = new Size(165, 34);
            textHoraFinal.TabIndex = 6;
            textHoraFinal.TextAlign = HorizontalAlignment.Center;
            textHoraFinal.ValidatingType = typeof(DateTime);
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(71, 391);
            labelId.Name = "labelId";
            labelId.Size = new Size(29, 28);
            labelId.TabIndex = 14;
            labelId.Text = "Id";
            // 
            // textId
            // 
            textId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(125, 385);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(74, 34);
            textId.TabIndex = 15;
            // 
            // textData
            // 
            textData.CustomFormat = "dd/MM/yyyy";
            textData.Location = new Point(65, 246);
            textData.Name = "textData";
            textData.Size = new Size(151, 27);
            textData.TabIndex = 2;
            // 
            // textHoraInicial
            // 
            textHoraInicial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textHoraInicial.Location = new Point(223, 317);
            textHoraInicial.Mask = "00:00";
            textHoraInicial.Name = "textHoraInicial";
            textHoraInicial.Size = new Size(165, 34);
            textHoraInicial.TabIndex = 5;
            textHoraInicial.TextAlign = HorizontalAlignment.Center;
            textHoraInicial.ValidatingType = typeof(DateTime);
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 457);
            Controls.Add(textHoraInicial);
            Controls.Add(textData);
            Controls.Add(textId);
            Controls.Add(labelId);
            Controls.Add(textHoraFinal);
            Controls.Add(labelHoraFinal);
            Controls.Add(labelHoraInicial);
            Controls.Add(textBoxLocal);
            Controls.Add(labelLocal);
            Controls.Add(labelData);
            Controls.Add(textBoxAssunto);
            Controls.Add(labelAssunto);
            Controls.Add(btnCancelar);
            Controls.Add(bntSalvar);
            Controls.Add(labelContato);
            Controls.Add(comboBoxContatos);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(651, 479);
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Compromisso";
            Load += TelaCompromissoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxContatos;
        private Label labelContato;
        private Button bntSalvar;
        private Button btnCancelar;
        private Label labelAssunto;
        private TextBox textBoxAssunto;
        private Label labelData;
        private Label labelLocal;
        private TextBox textBoxLocal;
        private Label labelHoraInicial;
        private Label labelHoraFinal;
        private MaskedTextBox textHoraFinal;
        private Label labelId;
        private TextBox textId;
        private DateTimePicker textData;
        private MaskedTextBox textHoraInicial;
    }
}