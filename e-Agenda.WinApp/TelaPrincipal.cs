using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp;

public partial class TelaPrincipal : Form
{
    private ControladorBase controlador = null!;

    private static TelaPrincipal telaPrincipal = null!;

    public static TelaPrincipal Instancia { get => telaPrincipal; }

    public TelaPrincipal()
    {
        InitializeComponent();

        telaPrincipal ??= this;
    }

    public void AlterarTextRodape(string menssagem)
    {
        statusLabel.Text = menssagem;
    }

    public void AlterarTextCadastro(string menssagem)
    {
        textTipoCadastro.Text = menssagem;
    }


    private void ConfigurarListagem(ControladorBase controladorBase)
    {
        UserControl listagem = controladorBase.ObterListagem();

        listagem.Dock = DockStyle.Fill;

        painelRegistros.Controls.Clear();

        painelRegistros.Controls.Add(listagem);
    }

    private void BtnAdicionar_Click(object sender, EventArgs e)
    {
        controlador.Inserir();
    }

    private void BtnEditar_Click(object sender, EventArgs e)
    {
        controlador.Editar();
    }

    private void BtnExcluir_Click(object sender, EventArgs e)
    {
        controlador.Excluir();
    }

    private void BtnFiltrar_Click(object sender, EventArgs e)
    {
        controlador.Filtrar();
    }

    private void BtnVisualizar_Click(object sender, EventArgs e)
    {
        if (controlador is ControladorCategoria ctrl)
            ctrl.VisualizarDespesasPorCategoria();
    }

    private void BtnAddItemTarefa_Click(object sender, EventArgs e)
    {
        if (controlador is ControladorTarefa ctrl)
            ctrl.CadastrarItem();
    }

    private void BtnAtualizarTarefa_Click(object sender, EventArgs e)
    {
        if (controlador is ControladorTarefa ctrl)
            ctrl.AtualizarItensTarefa();
    }

    private void ContatosMenuItem_Click(object sender, EventArgs e)
    {
        controlador = IoC.ObterControlador(sender);

        ConfigurarToolTips(controlador);

        ConfigurarListagem(controlador);

        ConfigurarBotoes(controlador);
    }


    private void CompromissosMenuItem_Click(object sender, EventArgs e)
    {
        controlador = IoC.ObterControlador(sender);

        ConfigurarToolTips(controlador);

        ConfigurarListagem(controlador);

        ConfigurarBotoes(controlador);
    }

    private void TarefasMenuItem_Click(object sender, EventArgs e)
    {
        controlador = IoC.ObterControlador(sender);

        ConfigurarToolTips(controlador);

        ConfigurarListagem(controlador);

        ConfigurarBotoes(controlador);

    }

    private void CategoriasMenu_Click(object sender, EventArgs e)
    {
        controlador = IoC.ObterControlador(sender);

        ConfigurarListagem(controlador);

        ConfigurarToolTips(controlador);

        ConfigurarBotoes(controlador);

    }

    private void ControleDespesaMenu_Click(object sender, EventArgs e)
    {
        controlador = IoC.ObterControlador(sender);

        ConfigurarListagem(controlador);

        ConfigurarToolTips(controlador);

        ConfigurarBotoes(controlador);
    }



    private void ConfigurarBotoes(ControladorBase controlador)
    {
        btnFiltrar.Enabled = controlador.Configuracao.BtnFiltrarEnabled;

        btnAdicionar.Enabled = controlador.Configuracao.BtnAdicionarEnabled;

        btnEditar.Enabled = controlador.Configuracao.BtnEditarEnabled;

        btnExcluir.Enabled = controlador.Configuracao.BtnExcluirEnabled;

        btnAddItemTarefa.Enabled = controlador.Configuracao.BtnAddItemTarefaEnabled;

        btnAtualizarTarefa.Enabled = controlador.Configuracao.BtnAtualizarTarefaEnabled;

        btnVisualizar.Enabled = controlador.Configuracao.BtnVisualizarEnabled;

    }

    private void ConfigurarToolTips(ControladorBase controlador)
    {
        btnAdicionar.ToolTipText = controlador.Configuracao.ToolTipInserir;

        btnEditar.ToolTipText = controlador.Configuracao.ToolTipEditar;

        btnExcluir.ToolTipText = controlador.Configuracao.ToolTipExcluir;

        btnAddItemTarefa.ToolTipText = controlador.Configuracao.ToolTipAdicionarItemTarefa;

        btnAtualizarTarefa.ToolTipText = controlador.Configuracao.ToolTipAtualizarTarefa;

        btnFiltrar.ToolTipText = controlador.Configuracao.ToolTipoFiltrar;
    }

   
}