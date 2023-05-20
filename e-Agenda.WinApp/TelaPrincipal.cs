using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipal : Form
    {
        private IControler? controlador;

        private readonly RepositorioContato repositorioContato = new RepositorioContato(new List<Contato>());

        private readonly RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso(new List<Compromisso>());

        private readonly RepositorioTarefa repositorioTarefa = new RepositorioTarefa(new List<Tarefa>());
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);

            btnFiltrar.Enabled = false;

            btnAdicionar.Enabled = true;

            btnEditar.Enabled = true;

            btnExcluir.Enabled = true;

            btnAddItemTarefa.Enabled = false;

            btnAtualizarTarefa.Enabled = false;

            statusLabel.Text = "Menu Contato";
        }

        private void ConfigurarToolTips(IControler controladorBase)
        {
            btnAdicionar.ToolTipText = controladorBase.ToolTipInserir;
            btnEditar.ToolTipText = controladorBase.ToolTipEditar;
            btnExcluir.ToolTipText = controladorBase.ToolTipExcluir;
        }

        private void ConfigurarListagem(IControler controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            painelRegistros.Controls.Clear();

            painelRegistros.Controls.Add(listagem);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            controlador?.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador?.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador?.Excluir();
        }

        private void compromissosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);

            statusLabel.Text = "Menu Compromisso";

            btnFiltrar.ToolTipText = "Filtrar Compromissos";

            btnFiltrar.Enabled = true;

            btnAdicionar.Enabled = true;

            btnEditar.Enabled = true;

            btnExcluir.Enabled = true;

            btnAddItemTarefa.Enabled = false;

            btnAtualizarTarefa.Enabled = false;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (controlador is ControladorCompromisso ctrl)
                ctrl.AbrirFormFiltro();
        }


        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);

            btnFiltrar.Enabled = false;

            btnAdicionar.Enabled = true;

            btnEditar.Enabled = true;

            btnExcluir.Enabled = true;

            btnAddItemTarefa.Enabled = true;

            btnAtualizarTarefa.Enabled = true;

            btnExcluir.ToolTipText = "Excluir tarefa";

            btnAddItemTarefa.ToolTipText = "Adicionar Tarefa";

            btnAtualizarTarefa.ToolTipText = "Atualizar Tarefa";

            statusLabel.Text = "Menu Tarefas";

        }

        private void btnAddItemTarefa_Click(object sender, EventArgs e)
        {
            if (controlador is ControladorTarefa ctrl)

                ctrl.CadastrarItem();
        }

        private void btnAtualizarTarefa_Click(object sender, EventArgs e)
        {
            if (controlador is ControladorTarefa ctrl)
                ctrl.AtualizarItensTarefa();
        }
    }
}