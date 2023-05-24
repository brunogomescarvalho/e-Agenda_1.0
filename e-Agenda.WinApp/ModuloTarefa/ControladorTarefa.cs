using e_Agenda.WinApp.ModuloCompartilhado;
using static e_Agenda.WinApp.ModuloTarefa.TelaFiltrarTarefasForm;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase<RepositorioTarefa, Tarefa>
    {

        private ListagemTarefasControl? listagemTarefasControl;

        private readonly RepositorioTarefa RepositorioTarefa;

        private bool tarefaConcluida = false;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            RepositorioBase = repositorioTarefa;
            RepositorioTarefa = repositorioTarefa;
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

            DialogResult opcao = formTarefa.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                Tarefa tarefaEditada = formTarefa.Tarefa;

                tarefa.Editar(tarefaEditada);

                RepositorioBase!.Editar(tarefa);

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
                RepositorioBase!.Excluir(tarefa);

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

                RepositorioBase!.Cadastrar(tarefa);

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
            List<Tarefa> tarefas = RepositorioTarefa.ObterTarefasPendentes();

            listagemTarefasControl!.AtualizarLista(tarefas);
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
                List<Item> itens = telaItens.ObterItens();

                tarefa.AdicionarItem(itens);

                tarefa.CalcularPorcentagemConcluida();

                AtualizarTarefa();
            }
        }
        private Tarefa ObterTarefa()
        {
            int idtTarefa = listagemTarefasControl!.ObterIdTarefaSelecionada();

            Tarefa tarefa = RepositorioBase!.BuscarPorId(idtTarefa);

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
                List<Item> itensParaFinalizar = telaAtualizar.BuscarItensSelecionados();

                foreach (Item item in tarefa.Itens)
                {
                    if (itensParaFinalizar.Contains(item))
                    {
                        item.ConcluirItem();
                    }
                }

                tarefa.TarefaConcluidaEventHandler += Tarefa_TarefaConcluidaEventHandler;

                tarefa.CalcularPorcentagemConcluida();
               
                AtualizarTarefa();
                
            }

        }

        private void Tarefa_TarefaConcluidaEventHandler()
        {
            if(tarefaConcluida == false)
            {
                MessageBox.Show("A tarefa foi concluída e movida para a lista de tarefas concluídas!", "Tarefa Concluída", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tarefaConcluida = true;
            }
        }

     

        public void AbrirFormFiltro()
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
                        tarefas = RepositorioTarefa.ObterTodasTarefas();
                        opcaoString = "Tarefas";
                        break;
                    case TipoDeBusca.concluidas:
                        tarefas = RepositorioTarefa.ObterTarefasConcluidas();
                        opcaoString = "Tarefas Concluídas";
                        break;
                    case TipoDeBusca.pendentes:
                        opcaoString = "Tarefas Pendentes";
                        tarefas = this.RepositorioTarefa.ObterTarefasPendentes();
                        break;
                }

                TelaPrincipal.Instancia.AlterarTextCadastro(opcaoString);
                listagemTarefasControl!.AtualizarLista(tarefas);
            }

        }

        public override void ConfigurarTela()
        {
            Configuracao = new Configuracao(

            "Tarefas",
            "Inserir Tarefa",
            "Editar Tarefa",
            "Excluir Tarefa");

            Configuracao.ToolTipoFiltrar = "Filtrar Tarefas";
            Configuracao.BtnAddItemTarefaEnabled = true;
            Configuracao.BtnAtualizarTarefaEnabled = true;
            Configuracao.BtnFiltrarEnabled = true;

        }
    }
}
