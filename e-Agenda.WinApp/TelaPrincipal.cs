using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipal : Form
    {
        IControler? controlador;

        RepositorioContato repositorioContato = new RepositorioContato(new List<Contato>());
        RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso(new List<Compromisso>());

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void contatosMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);

            ConfigurarToolTips(controlador);
            ConfigurarListagem(controlador);
            btnFiltrar.Visible = false;

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

            btnFiltrar.Visible = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (controlador is ControladorCompromisso ctrl)
                ctrl.AbrirFormFiltro();
        }
    }
}