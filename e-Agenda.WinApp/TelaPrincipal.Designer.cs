namespace e_Agenda.WinApp
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
            tarefasMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            controleMenu = new ToolStripMenuItem();
            categoriasMenu = new ToolStripMenuItem();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            barraFerramentas = new ToolStrip();
            btnAdicionar = new ToolStripMenuItem();
            btnEditar = new ToolStripMenuItem();
            btnExcluir = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnAddItemTarefa = new ToolStripButton();
            btnAtualizarTarefa = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnVisualizar = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            textTipoCadastro = new ToolStripLabel();
            painelRegistros = new Panel();
            menuStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            barraFerramentas.SuspendLayout();
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
            menuStrip.Size = new Size(982, 48);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // cadastroItem
            // 
            cadastroItem.BackColor = SystemColors.ActiveCaption;
            cadastroItem.BackgroundImageLayout = ImageLayout.None;
            cadastroItem.DropDownItems.AddRange(new ToolStripItem[] { contatosMenuItem, compromissosMenuItem, tarefasMenuItem, despesasToolStripMenuItem });
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
            // tarefasMenuItem
            // 
            tarefasMenuItem.Image = Properties.Resources.list_alt_FILL0_wght300_GRAD0_opsz40;
            tarefasMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            tarefasMenuItem.Name = "tarefasMenuItem";
            tarefasMenuItem.Size = new Size(248, 46);
            tarefasMenuItem.Text = "Tarefas";
            tarefasMenuItem.Click += tarefasMenuItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { controleMenu, categoriasMenu });
            despesasToolStripMenuItem.Image = Properties.Resources.payments_FILL0_wght200_GRAD0_opsz40;
            despesasToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(248, 46);
            despesasToolStripMenuItem.Text = "Despesas";
            // 
            // controleMenu
            // 
            controleMenu.Image = Properties.Resources.price_check_FILL0_wght200_GRAD0_opsz40;
            controleMenu.ImageScaling = ToolStripItemImageScaling.None;
            controleMenu.Name = "controleMenu";
            controleMenu.Size = new Size(244, 46);
            controleMenu.Text = "Controle";
            controleMenu.Click += controleDespesaMenu_Click;
            // 
            // categoriasMenu
            // 
            categoriasMenu.Image = Properties.Resources.category_FILL0_wght200_GRAD0_opsz40;
            categoriasMenu.ImageScaling = ToolStripItemImageScaling.None;
            categoriasMenu.Name = "categoriasMenu";
            categoriasMenu.Size = new Size(244, 46);
            categoriasMenu.Text = "Categorias";
            categoriasMenu.Click += categoriasMenu_Click;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 545);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(982, 26);
            statusStrip.TabIndex = 1;
            statusStrip.Text = "Bem Vindo!";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(86, 20);
            statusLabel.Text = "Bem Vindo!";
            // 
            // barraFerramentas
            // 
            barraFerramentas.AutoSize = false;
            barraFerramentas.BackColor = SystemColors.GradientInactiveCaption;
            barraFerramentas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            barraFerramentas.ImageScalingSize = new Size(24, 24);
            barraFerramentas.Items.AddRange(new ToolStripItem[] { btnAdicionar, btnEditar, btnExcluir, toolStripSeparator1, btnFiltrar, toolStripSeparator2, btnAddItemTarefa, btnAtualizarTarefa, toolStripSeparator3, btnVisualizar, toolStripSeparator4, textTipoCadastro });
            barraFerramentas.LayoutStyle = ToolStripLayoutStyle.Flow;
            barraFerramentas.Location = new Point(0, 48);
            barraFerramentas.Name = "barraFerramentas";
            barraFerramentas.Padding = new Padding(0, 5, 1, 0);
            barraFerramentas.Size = new Size(982, 54);
            barraFerramentas.Stretch = true;
            barraFerramentas.TabIndex = 2;
            barraFerramentas.Text = "toolStrip1";
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
            btnExcluir.Click += btnExcluir_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 23);
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 23);
            // 
            // btnAddItemTarefa
            // 
            btnAddItemTarefa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAddItemTarefa.Enabled = false;
            btnAddItemTarefa.Image = Properties.Resources.list_alt_FILL0_wght200_GRAD0_opsz40;
            btnAddItemTarefa.ImageScaling = ToolStripItemImageScaling.None;
            btnAddItemTarefa.ImageTransparentColor = Color.Magenta;
            btnAddItemTarefa.Name = "btnAddItemTarefa";
            btnAddItemTarefa.Size = new Size(44, 44);
            btnAddItemTarefa.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAddItemTarefa.Click += btnAddItemTarefa_Click;
            // 
            // btnAtualizarTarefa
            // 
            btnAtualizarTarefa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAtualizarTarefa.Enabled = false;
            btnAtualizarTarefa.Image = Properties.Resources.fact_check_FILL0_wght200_GRAD0_opsz40;
            btnAtualizarTarefa.ImageScaling = ToolStripItemImageScaling.None;
            btnAtualizarTarefa.ImageTransparentColor = Color.Magenta;
            btnAtualizarTarefa.Name = "btnAtualizarTarefa";
            btnAtualizarTarefa.Size = new Size(44, 44);
            btnAtualizarTarefa.Click += btnAtualizarTarefa_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 23);
            // 
            // btnVisualizar
            // 
            btnVisualizar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnVisualizar.Enabled = false;
            btnVisualizar.Image = Properties.Resources.pageview_FILL0_wght200_GRAD0_opsz40;
            btnVisualizar.ImageScaling = ToolStripItemImageScaling.None;
            btnVisualizar.ImageTransparentColor = Color.Magenta;
            btnVisualizar.Name = "btnVisualizar";
            btnVisualizar.Size = new Size(44, 44);
            btnVisualizar.Click += btnVisualizar_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 23);
            // 
            // textTipoCadastro
            // 
            textTipoCadastro.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textTipoCadastro.Margin = new Padding(10, 5, 0, 1);
            textTipoCadastro.Name = "textTipoCadastro";
            textTipoCadastro.Padding = new Padding(0, 6, 0, 0);
            textTipoCadastro.Size = new Size(94, 30);
            textTipoCadastro.Text = "e-Agenda";
            // 
            // painelRegistros
            // 
            painelRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            painelRegistros.Location = new Point(0, 100);
            painelRegistros.Margin = new Padding(3, 10, 3, 3);
            painelRegistros.Name = "painelRegistros";
            painelRegistros.Size = new Size(982, 471);
            painelRegistros.TabIndex = 3;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 571);
            Controls.Add(barraFerramentas);
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
            barraFerramentas.ResumeLayout(false);
            barraFerramentas.PerformLayout();
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
        private ToolStrip barraFerramentas;
        private ToolStripMenuItem btnAdicionar;
        private ToolStripMenuItem btnEditar;
        private ToolStripMenuItem btnExcluir;
        private Panel painelRegistros;
        private ToolStripButton btnFiltrar;
        private ToolStripMenuItem tarefasMenuItem;
        private ToolStripButton btnAddItemTarefa;
        private ToolStripButton btnAtualizarTarefa;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripLabel textTipoCadastro;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem controleMenu;
        private ToolStripMenuItem categoriasMenu;
        private ToolStripButton btnVisualizar;
        private ToolStripSeparator toolStripSeparator4;
    }
}