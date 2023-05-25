namespace e_Agenda.WinApp.ModuloTarefa;
public class ControladorTarefa:ControladorBase
{
    private ListagemTarefasControl? listagemTarefasControl;

    private RepositorioTarefa repositorioTarefa;

    public ControladorTarefa(RepositorioTarefa repositorioTarefa)
    {
        this.repositorioTarefa = repositorioTarefa;

        ConfigurarTela();
    }

    public override void Editar()
    {
        Tarefa tarefa = ObterTarefa();

        if (tarefa == null)
            return;

        DialogResult confimacao = ConfirmarAcao($"Confirma editar a tarefa Id: {tarefa.Id} - Titulo: {tarefa.Titulo} ?", "Editar Tarefa");

        if (confimacao == DialogResult.No)
            return;

        TelaTarefaForm formTarefa = new TelaTarefaForm();

        formTarefa.Text = "Editar Tarefa";

        formTarefa.Tarefa = tarefa;

        DialogResult opcao = formTarefa.ShowDialog();

       

        if (opcao == DialogResult.OK)
        {
            Tarefa tarefaEditada = formTarefa.Tarefa;

            tarefa.Editar(tarefaEditada);

            repositorioTarefa!.Editar(tarefa);

            AtualizarTarefa();
        }
    }

    public override void Excluir()
    {
        Tarefa tarefa = ObterTarefa();

        if (tarefa == null)
            return;

        DialogResult confimacao = ConfirmarAcao($"Confirma excluir a tarefa Id: {tarefa.Id} - Titulo: {tarefa.Titulo} ?", "Excluir Tarefa");

        if (confimacao == DialogResult.Yes)
        {
            repositorioTarefa!.Excluir(tarefa);

            AtualizarTarefa();
        }

    }

    public override void Inserir()
    {
        var telaForm = new TelaTarefaForm();

        DialogResult opcao = telaForm.ShowDialog();

        if (opcao == DialogResult.OK)
        {
            Tarefa tarefa = telaForm.Tarefa;

            repositorioTarefa!.Cadastrar(tarefa);

            AtualizarTarefa();
        }
    }

    public override UserControl ObterListagem()
    {
        listagemTarefasControl ??= new ListagemTarefasControl();

        AtualizarTarefa();

        return listagemTarefasControl;
    }

    private void AtualizarTarefa()
    {
        List<Tarefa> tarefas = this.repositorioTarefa.ObterTarefasPendentes();

        listagemTarefasControl!.AtualizarLista(tarefas);

        TelaPrincipal.Instancia.AlterarTextRodape($"Exibindo {tarefas.Count} tarefas.");
    }

    public void CadastrarItem()
    {
        Tarefa tarefa = ObterTarefa();

        if (tarefa.EstaConcluida)
        {
            MessageBox.Show("A tarefa selecionada já está concluída!", "Tarefa Concluída", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        if (tarefa == null)
            return;

        var telaItens = new TelaItemTarefaForm(tarefa!);

        DialogResult opcao = telaItens.ShowDialog();

        if (opcao == DialogResult.OK)
        {
            List<ItemTarefa> itens = telaItens.ObterItens();

            itens.ForEach(i=>tarefa.AdicionarItem(i));

            repositorioTarefa!.Editar(tarefa);

            AtualizarTarefa();
        }
    }
    private Tarefa ObterTarefa()
    {
        int idtTarefa = listagemTarefasControl!.ObterIdTarefaSelecionada();

        Tarefa tarefa = repositorioTarefa!.BuscarPorId(idtTarefa);

        if (tarefa == null)
            MessageBox.Show("É necessário selecionar uma tarefa!", "Tarefa Não Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        return tarefa!;
    }

    public void AtualizarItensTarefa()
    {
        Tarefa tarefa = ObterTarefa();

        if (tarefa == null)
            return;

        if (tarefa.EstaConcluida)
        {
            MessageBox.Show("A tarefa selecionada já está concluída!", "Tarefa Concluída", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        if (tarefa.Itens.Count == 0)
        {
            MessageBox.Show("A tarefa selecionada não possui itens cadastrados!", "Atualizar Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        var telaAtualizar = new TelaAtualizarTarefaForm(tarefa);

        DialogResult opcao = telaAtualizar.ShowDialog();

        if (opcao == DialogResult.OK)
        {
            tarefa.TarefaConcluidaEventHandler += Tarefa_TarefaConcluidaEventHandler;

            telaAtualizar.BuscarItensSelecionados().ForEach(i => tarefa.TornarItemConcluido(i));

            telaAtualizar.BuscarItensNaoSelecionados().ForEach(i => tarefa.TornarItemPendente(i));

            tarefa.TarefaConcluidaEventHandler -= Tarefa_TarefaConcluidaEventHandler;

            repositorioTarefa!.Editar(tarefa);

            AtualizarTarefa();

        }
    }

    private void Tarefa_TarefaConcluidaEventHandler()
    {
        MessageBox.Show("A tarefa foi concluída e movida para a lista de tarefas concluídas!", "Tarefa Concluída", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }

    public void Filtrar()
    {
        var telaFiltro = new TelaFiltrarTarefasForm();

        DialogResult opcao = telaFiltro.ShowDialog();

        List<Tarefa> tarefas = null!;

        string opcaoString = "";

        if (opcao == DialogResult.OK)
        {
            TipoDeBusca tipoDeBusca = telaFiltro.ObterOpcao();

            switch (tipoDeBusca)
            {
                case TipoDeBusca.todas:
                    tarefas = this.repositorioTarefa.ObterTodasTarefas();
                    opcaoString = "Tarefas";
                    break;
                case TipoDeBusca.concluidas:
                    tarefas = this.repositorioTarefa.ObterTarefasConcluidas();
                    opcaoString = "Tarefas Concluídas";
                    break;
                case TipoDeBusca.pendentes:
                    opcaoString = "Tarefas Pendentes";
                    tarefas = this.repositorioTarefa.ObterTarefasPendentes();
                    break;
            }

            TelaPrincipal.Instancia.AlterarTextCadastro(opcaoString);

            listagemTarefasControl!.AtualizarLista(tarefas);
        }

    }

    public override void ConfigurarTela()
    {
        Configuracao = new Configuracao(

        "Inserir Tarefa",
        "Editar Tarefa",
        "Excluir Tarefa");

        Configuracao.ToolTipoFiltrar = "Filtrar Tarefas";
        Configuracao.BtnAddItemTarefaEnabled = true;
        Configuracao.BtnAtualizarTarefaEnabled = true;
        Configuracao.BtnFiltrarEnabled = true;

    }
}
