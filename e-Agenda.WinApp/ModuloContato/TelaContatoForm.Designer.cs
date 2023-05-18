namespace e_Agenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            textCargo = new TextBox();
            label_Cargo = new Label();
            textEmpresa = new TextBox();
            label_Empresa = new Label();
            textTelefone = new MaskedTextBox();
            label_Telefone = new Label();
            textEmail = new MaskedTextBox();
            label_Email = new Label();
            textId = new TextBox();
            label_Id = new Label();
            textNome = new TextBox();
            labelNome = new Label();
            btnSalvar = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // textCargo
            // 
            textCargo.Anchor = AnchorStyles.None;
            textCargo.Location = new Point(46, 361);
            textCargo.Name = "textCargo";
            textCargo.Size = new Size(227, 27);
            textCargo.TabIndex = 4;
            // 
            // label_Cargo
            // 
            label_Cargo.Anchor = AnchorStyles.None;
            label_Cargo.AutoSize = true;
            label_Cargo.CausesValidation = false;
            label_Cargo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Cargo.Location = new Point(46, 330);
            label_Cargo.Name = "label_Cargo";
            label_Cargo.Size = new Size(69, 28);
            label_Cargo.TabIndex = 24;
            label_Cargo.Text = "Cargo:";
            // 
            // textEmpresa
            // 
            textEmpresa.Anchor = AnchorStyles.None;
            textEmpresa.Location = new Point(44, 292);
            textEmpresa.Name = "textEmpresa";
            textEmpresa.Size = new Size(518, 27);
            textEmpresa.TabIndex = 3;
            // 
            // label_Empresa
            // 
            label_Empresa.Anchor = AnchorStyles.None;
            label_Empresa.AutoSize = true;
            label_Empresa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Empresa.Location = new Point(44, 264);
            label_Empresa.Name = "label_Empresa";
            label_Empresa.Size = new Size(90, 28);
            label_Empresa.TabIndex = 22;
            label_Empresa.Text = "Empresa:";
            // 
            // textTelefone
            // 
            textTelefone.Anchor = AnchorStyles.None;
            textTelefone.Location = new Point(46, 226);
            textTelefone.Mask = "00000-9999";
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(227, 27);
            textTelefone.TabIndex = 2;
            // 
            // label_Telefone
            // 
            label_Telefone.Anchor = AnchorStyles.None;
            label_Telefone.AutoSize = true;
            label_Telefone.CausesValidation = false;
            label_Telefone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Telefone.Location = new Point(46, 198);
            label_Telefone.Name = "label_Telefone";
            label_Telefone.Size = new Size(88, 28);
            label_Telefone.TabIndex = 20;
            label_Telefone.Text = "Telefone:";
            // 
            // textEmail
            // 
            textEmail.Anchor = AnchorStyles.None;
            textEmail.Location = new Point(46, 159);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(517, 27);
            textEmail.TabIndex = 1;
            // 
            // label_Email
            // 
            label_Email.Anchor = AnchorStyles.None;
            label_Email.AutoSize = true;
            label_Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Email.Location = new Point(46, 131);
            label_Email.Name = "label_Email";
            label_Email.Size = new Size(71, 28);
            label_Email.TabIndex = 18;
            label_Email.Text = "E-mail:";
            // 
            // textId
            // 
            textId.Anchor = AnchorStyles.None;
            textId.Location = new Point(46, 43);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(121, 27);
            textId.TabIndex = 17;
            textId.TabStop = false;
            // 
            // label_Id
            // 
            label_Id.Anchor = AnchorStyles.None;
            label_Id.AutoSize = true;
            label_Id.CausesValidation = false;
            label_Id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Id.Location = new Point(46, 12);
            label_Id.Name = "label_Id";
            label_Id.Size = new Size(33, 28);
            label_Id.TabIndex = 16;
            label_Id.Text = "Id:";
            // 
            // textNome
            // 
            textNome.Anchor = AnchorStyles.None;
            textNome.Location = new Point(46, 101);
            textNome.Name = "textNome";
            textNome.Size = new Size(518, 27);
            textNome.TabIndex = 0;
            // 
            // labelNome
            // 
            labelNome.Anchor = AnchorStyles.None;
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelNome.Location = new Point(46, 73);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(70, 28);
            labelNome.TabIndex = 14;
            labelNome.Text = "Nome:";
            labelNome.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSalvar
            // 
            btnSalvar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalvar.DialogResult = DialogResult.OK;
            btnSalvar.Location = new Point(363, 361);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(85, 56);
            btnSalvar.TabIndex = 5;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(466, 361);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 56);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ContatoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(682, 453);
            Controls.Add(btnCancel);
            Controls.Add(btnSalvar);
            Controls.Add(textCargo);
            Controls.Add(label_Cargo);
            Controls.Add(textEmpresa);
            Controls.Add(label_Empresa);
            Controls.Add(textTelefone);
            Controls.Add(label_Telefone);
            Controls.Add(textEmail);
            Controls.Add(label_Email);
            Controls.Add(textId);
            Controls.Add(label_Id);
            Controls.Add(textNome);
            Controls.Add(labelNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ContatoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Contato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textCargo;
        private Label label_Cargo;
        private TextBox textEmpresa;
        private Label label_Empresa;
        private MaskedTextBox textTelefone;
        private Label label_Telefone;
        private MaskedTextBox textEmail;
        private Label label_Email;
        private TextBox textId;
        private Label label_Id;
        private TextBox textNome;
        private Label labelNome;
        private Button btnSalvar;
        private Button btnCancel;
    }
}