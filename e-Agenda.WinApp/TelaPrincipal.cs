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

        private static TelaPrincipal telaPrincipal = null!;

        public static TelaPrincipal Instancia { get => telaPrincipal; }

        public TelaPrincipal()
        {
            InitializeComponent();

            telaPrincipal ??= this;
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);

            ConfigurarBotoes(controlador);
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

            ConfigurarBotoes(controlador);

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (controlador is ControladorCompromisso ctrl)
                ctrl.AbrirFormFiltro(textTipoCadastro);

            else if (controlador is ControladorTarefa ctrlTarefa)
                ctrlTarefa.AbrirFormFiltro(textTipoCadastro);
              
        }


        private void tarefasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);

            ConfigurarToolTips(controlador);

            ConfigurarListagem(controlador);

            ConfigurarBotoes(controlador);

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

        private void ConfigurarBotoes(IControler controlador)
        {
            btnFiltrar.Enabled = controlador.Configuracao.BtnFiltrarEnabled;

            btnAdicionar.Enabled = controlador.Configuracao.BtnAdicionarEnabled;

            btnEditar.Enabled = controlador.Configuracao.BtnEditarEnabled;

            btnExcluir.Enabled = controlador.Configuracao.BtnExcluirEnabled;

            btnAddItemTarefa.Enabled = controlador.Configuracao.BtnAddItemTarefaEnabled;

            btnAtualizarTarefa.Enabled = controlador.Configuracao.BtnAtualizarTarefaEnabled;

            textTipoCadastro.Text = controlador.Configuracao.StatusLabel;

            statusLabel.Text = "Menu " + controlador.Configuracao.StatusLabel;
        }

        private void ConfigurarToolTips(IControler controlador)
        {
            btnAdicionar.ToolTipText = controlador.Configuracao.ToolTipInserir;

            btnEditar.ToolTipText = controlador.Configuracao.ToolTipEditar;

            btnExcluir.ToolTipText = controlador.Configuracao.ToolTipExcluir;

            btnAddItemTarefa.ToolTipText = controlador.Configuracao.ToolTipAdicionarItemTarefa;

            btnAtualizarTarefa.ToolTipText = controlador.Configuracao.ToolTipAtualizarTarefa;

            btnFiltrar.ToolTipText = controlador.Configuracao.ToolTipoFiltrar;
        }

        public void AlterarTextRodape(string menssagem)
        {
            statusLabel.Text = menssagem;
        }
    }
}