﻿namespace e_Agenda.WinApp
{
    partial class TelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            menuStrip = new MenuStrip();
            cadastroItem = new ToolStripMenuItem();
            contatosMenuItem = new ToolStripMenuItem();
            compromissosMenuItem = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            btnAdicionar = new ToolStripMenuItem();
            btnEditar = new ToolStripMenuItem();
            btnExcluir = new ToolStripMenuItem();
            btnFiltrar = new ToolStripButton();
            painelRegistros = new Panel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.ActiveCaption;
            menuStrip.BackgroundImageLayout = ImageLayout.Stretch;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { cadastroItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1090, 48);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // cadastroItem
            // 
            cadastroItem.BackColor = SystemColors.ActiveCaption;
            cadastroItem.BackgroundImageLayout = ImageLayout.None;
            cadastroItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem });
            cadastroItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cadastroItem.Image = Properties.Resources.menu_FILL0_wght200_GRAD0_opsz40;
            cadastroItem.ImageScaling = ToolStripItemImageScaling.None;
            cadastroItem.Name = "cadastroItem";
            cadastroItem.Size = new Size(144, 44);
            cadastroItem.Text = "Cadastro";
            // 
            // contatosMenuItem
            // 
            contatosMenuItem.Image = (Image)resources.GetObject("contatosMenuItem.Image");
            contatosMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            contatosMenuItem.Name = "contatosMenuItem";
            contatosMenuItem.Size = new Size(248, 46);
            contatosMenuItem.Text = "Contatos";
            contatosMenuItem.Click += contatosMenuItem_Click;
            // 
            // compromissosMenuItem
            // 
            compromissosMenuItem.Image = (Image)resources.GetObject("compromissosMenuItem.Image");
            compromissosMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            compromissosMenuItem.Name = "compromissosMenuItem";
            compromissosMenuItem.Size = new Size(248, 46);
            compromissosMenuItem.Text = "Compromissos";
            compromissosMenuItem.Click += compromissosMenuItem_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 647);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1090, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "Bem Vindo!";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(86, 20);
            statusLabel.Text = "Bem Vindo!";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = SystemColors.GradientInactiveCaption;
            toolStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, btnFiltrar });
            toolStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            toolStrip1.Location = new Point(0, 48);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 5, 1, 0);
            toolStrip1.Size = new Size(1090, 54);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoToolTip = true;
            btnAdicionar.BackgroundImageLayout = ImageLayout.Stretch;
            btnAdicionar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionar.Enabled = false;
            btnAdicionar.Image = (Image)resources.GetObject("btnAdicionar.Image");
            btnAdicionar.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(54, 44);
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoToolTip = true;
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Enabled = false;
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(54, 44);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoToolTip = true;
            btnExcluir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnExcluir.Enabled = false;
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageScaling = ToolStripItemImageScaling.None;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(54, 44);
            btnExcluir.Text = "Excluir";
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Enabled = false;
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(44, 44);
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // painelRegistros
            // 
            painelRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            painelRegistros.Location = new Point(0, 100);
            painelRegistros.Margin = new Padding(3, 10, 3, 3);
            painelRegistros.Name = "painelRegistros";
            painelRegistros.Size = new Size(1090, 573);
            painelRegistros.TabIndex = 3;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 673);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Controls.Add(painelRegistros);
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(1000, 400);
            Name = "TelaPrincipal";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "e-Agenda 1.0";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem cadastroItem;
        private ToolStripMenuItem contatosMenuItem;
        private ToolStripMenuItem compromissosMenuItem;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel statusLabel;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem btnAdicionar;
        private ToolStripMenuItem btnEditar;
        private ToolStripMenuItem btnExcluir;
        private Panel painelRegistros;
        private ToolStripButton btnFiltrar;
    }
}