

using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Dominio.ModuloDespesa;
using e_Agenda.Dominio.ModuloTarefa;
using e_Agenda.InfraDados.ModuloCategoria;
using e_Agenda.InfraDados.ModuloCompartilhado;
using e_Agenda.InfraDados.ModuloCompromisso;
using e_Agenda.InfraDados.ModuloContato;
using e_Agenda.InfraDados.ModuloDespesa;
using e_Agenda.InfraDados.ModuloTarefa;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesa;
using e_Agenda.WinApp.ModuloTarefa;
using System.Media;

namespace e_Agenda.WinApp;

public partial class TelaPrincipal : Form
{
    private ControladorBase controlador = null!;

    private static ContextoDados contexto = new ContextoDados(carregarDados:true);

    private readonly IRepositorioContato repositorioContato = new RepositorioContatoArquivo(contexto);

    private readonly IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoArquivo(contexto);

    private readonly IRepositorioTarefa repositorioTarefa = new RepositorioTarefaArquivo(contexto);

    private readonly IRepositorioDespesa repositorioDespesa = new RepositorioDespesaArquivo(contexto);

    private readonly IRepositorioCategoria repositorioCategoria = new RepositorioCategoriaArquivo(contexto);

    private static TelaPrincipal telaPrincipal = null!;

    public static TelaPrincipal Instancia { get => telaPrincipal; }

    public TelaPrincipal()
    {
        InitializeComponent();

        telaPrincipal ??= this;
    }


    private void ConfigurarListagem(ControladorBase controladorBase)
    {
        UserControl listagem = controladorBase.ObterListagem();

        listagem.Dock = DockStyle.Fill;

        painelRegistros.Controls.Clear();

        painelRegistros.Controls.Add(listagem);
    }

    private void btnAdicionar_Click(object sender, EventArgs e)
    {
        controlador.Inserir();
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        controlador.Editar();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
        controlador.Excluir();
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
        controlador.Filtrar();
    }

    private void btnVisualizar_Click(object sender, EventArgs e)
    {
        if (controlador is ControladorCategoria ctrl)
            ctrl.VisualizarDespesasPorCategoria();
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

    private void contatosMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorContato(repositorioContato);

        ConfigurarToolTips(controlador);

        ConfigurarListagem(controlador);

        ConfigurarBotoes(controlador);
    }


    private void compromissosMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);

        ConfigurarToolTips(controlador);

        ConfigurarListagem(controlador);

        ConfigurarBotoes(controlador);
    }

    private void tarefasMenuItem_Click(object sender, EventArgs e)
    {
        controlador = new ControladorTarefa(repositorioTarefa);

        ConfigurarToolTips(controlador);

        ConfigurarListagem(controlador);

        ConfigurarBotoes(controlador);

    }

    private void categoriasMenu_Click(object sender, EventArgs e)
    {
        controlador = new ControladorCategoria(repositorioCategoria, repositorioDespesa);

        ConfigurarListagem(controlador);

        ConfigurarToolTips(controlador);

        ConfigurarBotoes(controlador);

    }

    private void controleDespesaMenu_Click(object sender, EventArgs e)
    {
        controlador = new ControladorDespesa(repositorioDespesa,repositorioCategoria);

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

    public void AlterarTextRodape(string menssagem)
    {
        statusLabel.Text = menssagem;
    }

    public void AlterarTextCadastro(string menssagem)
    {
        textTipoCadastro.Text = menssagem;
    }
}