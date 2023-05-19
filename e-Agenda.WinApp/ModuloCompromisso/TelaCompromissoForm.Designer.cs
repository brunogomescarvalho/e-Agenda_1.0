﻿namespace e_Agenda.WinApp.ModuloCompromisso
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
            labelId = new Label();
            textId = new TextBox();
            textData = new DateTimePicker();
            textHoraInicial = new DateTimePicker();
            textHorarioFinal = new DateTimePicker();
            checkIncluirContato = new CheckBox();
            SuspendLayout();
            // 
            // comboBoxContatos
            // 
            comboBoxContatos.Enabled = false;
            comboBoxContatos.FlatStyle = FlatStyle.Flat;
            comboBoxContatos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxContatos.FormattingEnabled = true;
            comboBoxContatos.IntegralHeight = false;
            comboBoxContatos.Location = new Point(100, 84);
            comboBoxContatos.Name = "comboBoxContatos";
            comboBoxContatos.Size = new Size(578, 28);
            comboBoxContatos.TabIndex = 2;
            // 
            // labelContato
            // 
            labelContato.AutoSize = true;
            labelContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelContato.Location = new Point(12, 84);
            labelContato.Name = "labelContato";
            labelContato.Size = new Size(87, 28);
            labelContato.TabIndex = 1;
            labelContato.Text = "Contato:";
            // 
            // bntSalvar
            // 
            bntSalvar.DialogResult = DialogResult.OK;
            bntSalvar.Location = new Point(505, 335);
            bntSalvar.Name = "bntSalvar";
            bntSalvar.Size = new Size(76, 54);
            bntSalvar.TabIndex = 8;
            bntSalvar.Text = "Salvar";
            bntSalvar.UseVisualStyleBackColor = true;
            bntSalvar.Click += bntSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(608, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 54);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancel";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // labelAssunto
            // 
            labelAssunto.AutoSize = true;
            labelAssunto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAssunto.Location = new Point(12, 147);
            labelAssunto.Name = "labelAssunto";
            labelAssunto.Size = new Size(86, 28);
            labelAssunto.TabIndex = 4;
            labelAssunto.Text = "Assunto:";
            // 
            // textBoxAssunto
            // 
            textBoxAssunto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxAssunto.Location = new Point(100, 141);
            textBoxAssunto.Name = "textBoxAssunto";
            textBoxAssunto.Size = new Size(582, 34);
            textBoxAssunto.TabIndex = 3;
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelData.Location = new Point(30, 211);
            labelData.Name = "labelData";
            labelData.Size = new Size(57, 28);
            labelData.TabIndex = 6;
            labelData.Text = "Data:";
            // 
            // labelLocal
            // 
            labelLocal.AutoSize = true;
            labelLocal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLocal.Location = new Point(255, 212);
            labelLocal.Name = "labelLocal";
            labelLocal.Size = new Size(61, 28);
            labelLocal.TabIndex = 8;
            labelLocal.Text = "Local:";
            // 
            // textBoxLocal
            // 
            textBoxLocal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLocal.Location = new Point(327, 205);
            textBoxLocal.Name = "textBoxLocal";
            textBoxLocal.Size = new Size(356, 34);
            textBoxLocal.TabIndex = 5;
            // 
            // labelHoraInicial
            // 
            labelHoraInicial.AutoSize = true;
            labelHoraInicial.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraInicial.Location = new Point(30, 270);
            labelHoraInicial.Name = "labelHoraInicial";
            labelHoraInicial.Size = new Size(63, 28);
            labelHoraInicial.TabIndex = 10;
            labelHoraInicial.Text = "Início:";
            // 
            // labelHoraFinal
            // 
            labelHoraFinal.AutoSize = true;
            labelHoraFinal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelHoraFinal.Location = new Point(327, 268);
            labelHoraFinal.Name = "labelHoraFinal";
            labelHoraFinal.Size = new Size(86, 28);
            labelHoraFinal.TabIndex = 11;
            labelHoraFinal.Text = "Término:";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelId.Location = new Point(50, 36);
            labelId.Name = "labelId";
            labelId.Size = new Size(33, 28);
            labelId.TabIndex = 14;
            labelId.Text = "Id:";
            // 
            // textId
            // 
            textId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(96, 30);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(74, 34);
            textId.TabIndex = 0;
            textId.TabStop = false;
            // 
            // textData
            // 
            textData.CustomFormat = "dd/MM/yyyy";
            textData.Format = DateTimePickerFormat.Short;
            textData.Location = new Point(100, 212);
            textData.Name = "textData";
            textData.Size = new Size(131, 27);
            textData.TabIndex = 4;
            textData.Value = new DateTime(2023, 5, 18, 0, 0, 0, 0);
            // 
            // textHoraInicial
            // 
            textHoraInicial.CustomFormat = "HH:mm";
            textHoraInicial.Format = DateTimePickerFormat.Custom;
            textHoraInicial.Location = new Point(96, 271);
            textHoraInicial.Name = "textHoraInicial";
            textHoraInicial.ShowUpDown = true;
            textHoraInicial.Size = new Size(220, 27);
            textHoraInicial.TabIndex = 6;
            textHoraInicial.Value = new DateTime(2023, 5, 19, 12, 0, 0, 0);
            // 
            // textHorarioFinal
            // 
            textHorarioFinal.CustomFormat = "HH:mm";
            textHorarioFinal.Format = DateTimePickerFormat.Custom;
            textHorarioFinal.Location = new Point(428, 269);
            textHorarioFinal.Name = "textHorarioFinal";
            textHorarioFinal.ShowUpDown = true;
            textHorarioFinal.Size = new Size(250, 27);
            textHorarioFinal.TabIndex = 7;
            textHorarioFinal.Value = new DateTime(2023, 5, 19, 13, 0, 0, 0);
            // 
            // checkIncluirContato
            // 
            checkIncluirContato.AutoSize = true;
            checkIncluirContato.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkIncluirContato.Location = new Point(206, 35);
            checkIncluirContato.Name = "checkIncluirContato";
            checkIncluirContato.Size = new Size(172, 32);
            checkIncluirContato.TabIndex = 1;
            checkIncluirContato.Text = "Incluir Contato?";
            checkIncluirContato.UseVisualStyleBackColor = true;
            checkIncluirContato.CheckedChanged += checkIncluirContato_CheckedChanged;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 419);
            Controls.Add(checkIncluirContato);
            Controls.Add(textHorarioFinal);
            Controls.Add(textHoraInicial);
            Controls.Add(textData);
            Controls.Add(textId);
            Controls.Add(labelId);
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
        private Label labelId;
        private TextBox textId;
        private DateTimePicker textData;
        private DateTimePicker textHoraInicial;
        private DateTimePicker textHorarioFinal;
        private CheckBox checkIncluirContato;
    }
}