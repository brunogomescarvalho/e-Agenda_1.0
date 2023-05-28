
using e_Agenda.WinApp.Modulo_Despesa;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;


namespace e_Agenda.WinApp;

public partial class TelaPrincipal : Form
{
    private ControladorBase controlador = null!;

    private readonly RepositorioContato repositorioContato = new RepositorioContato(new List<Contato>());

    private readonly RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso(new List<Compromisso>());

    private readonly RepositorioTarefa repositorioTarefa = new RepositorioTarefa(new List<Tarefa>());

    private readonly RepositorioDespesa repositorioDespesa = new RepositorioDespesa(new List<Despesa>());

    private readonly RepositorioCategoria repositorioCategoria = new RepositorioCategoria(new List<Categoria>());

    private static TelaPrincipal telaPrincipal = null!;

    public static TelaPrincipal Instancia { get => telaPrincipal; }

    public TelaPrincipal()
    {
        InitializeComponent();

        telaPrincipal ??= this;

        PopularRepositorios();
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


    private void PopularRepositorios()
    {
        var item1 = new ItemTarefa("teste1");
        var item2 = new ItemTarefa("teste2");
        var item3 = new ItemTarefa("teste3");
        var item4 = new ItemTarefa("teste4");
        var item5 = new ItemTarefa("teste5");
        var item6 = new ItemTarefa("teste6");
        var item7 = new ItemTarefa("teste7");
        var item8 = new ItemTarefa("teste8");
        var item9 = new ItemTarefa("teste9");
        var item10 = new ItemTarefa("teste10");
        var item11 = new ItemTarefa("teste11");

        var tarefa1 = new Tarefa(Prioridade.Alta, "teste");
        var tarefa2 = new Tarefa(Prioridade.Normal, "teste2");

        var itens1 = new List<ItemTarefa>() { item1, item2, item3, item4, item5, item6, item7, item11 };
        var itens2 = new List<ItemTarefa>() { item8, item9, item10 };

        itens1.ForEach(i => tarefa1.AdicionarItem(i));
        itens2.ForEach(i => tarefa2.AdicionarItem(i));

        repositorioTarefa.Cadastrar(tarefa1);
        repositorioTarefa.Cadastrar(tarefa2);


        Contato contato1 = new Contato("Roger", "Waters@gmail.com", "(49)3222-2340", "Set Controls", "Desenvolvedor");
        Contato contato2 = new Contato("David", "Gilmour@gtech.com", "(49)9998-1234", "Sun", "Gerente");

        repositorioContato.Cadastrar(contato1);
        repositorioContato.Cadastrar(contato2);

        var listCompromissos = new List<Compromisso> {
            new Compromisso(contato2, "Implementar Nova solução", "Centro de Tecnologia", DateTime.Now.AddDays(-5), new DateTime(1,1,1, 10, 30,00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(contato1, "Reunião de equipe", "Sala de conferências", DateTime.Now.AddDays(-4), new DateTime(1,1,1, 11, 30, 00), new DateTime(1,1,1, 12, 00, 00)),
            new Compromisso(null, "Treinamento de vendas", "Auditório principal", DateTime.Now.AddDays(-3), new DateTime(1,1,1, 10, 30, 00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Entrevista de emprego", "Centro de Tecnologia Sala 3B", DateTime.Now.AddDays(-2), new DateTime(1,1,1, 9, 00, 00), new DateTime(1,1,1, 10, 30, 00)),
            new Compromisso(null, "Almoço de negócios", "Restaurante Hotel", DateTime.Now.Date,  new DateTime(1,1,1, 12, 30, 00),  new DateTime(1,1,1, 13, 30, 00)),
            new Compromisso(null, "Reunião de planejamento", "Sala de projetos", DateTime.Now.AddDays(1), new DateTime(1,1,1, 14, 30, 00), new DateTime(1,1,1, 15, 30, 00)),
            new Compromisso(null, "Workshop de inovação", "Centro de convenções", DateTime.Now.AddDays(2), new DateTime(1,1,1, 10, 30, 00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Apresentação de produtos", "Showroom", DateTime.Now.AddDays(3), new DateTime(1,1,1, 15, 30, 00), new DateTime(1,1,1, 16, 30, 00)),
            new Compromisso(null, "Reunião com fornecedor", "Escritório 5A", DateTime.Now.AddDays(4), new DateTime(1,1,1, 10, 00, 00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Lançamento do novo projeto", "Sala de conferências 2", DateTime.Now.AddDays(5), new DateTime(1,1,1, 13, 30, 00), new DateTime(1,1,1, 15, 30, 00))};

        listCompromissos.ForEach(i => repositorioCompromisso.Cadastrar(i));

        repositorioCategoria.Cadastrar(new Categoria("Alimentação"));
        repositorioCategoria.Cadastrar(new Categoria("Combustível"));

    }

   
}