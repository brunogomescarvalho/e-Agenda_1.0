using e_Agenda.WinApp.ModuloCompartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase<RepositorioTarefa, Tarefa>
    {
      

        public ListagemTarefasControl? listagemTarefasControl;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            RepositorioBase = repositorioTarefa;
            ConfigurarTela(); 
        }

        public override void Editar()
        {
            Tarefa tarefa = ObterTarefa();

            if (tarefa == null)
                return;

            DialogResult confimacao = ConfirmarAcao($"Confirma editar a tarefa Id: {tarefa.Id} - Titulo: {tarefa.Titulo} ?", "Editar Tarefa");

            if (confimacao == DialogResult.Cancel)
                return;

            TelaTarefaForm formTarefa = new TelaTarefaForm();

            formTarefa.Text = "Editar Tarefa";

            DialogResult opcao = formTarefa.ShowDialog();

            if(opcao == DialogResult.OK)
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

            if (confimacao == DialogResult.Cancel)
                return;

            RepositorioBase!.Excluir(tarefa);

            AtualizarTarefa();

        }

        public override void Inserir()
        {
            var telaForm = new TelaTarefaForm();

            var opcao = telaForm.ShowDialog();

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
            List<Tarefa> tarefas = RepositorioBase!.Listar();

            listagemTarefasControl!.AtualizarLista(tarefas);
        }

        public void CadastrarItem()
        {
            Tarefa tarefa = ObterTarefa();

            if (tarefa == null)
                return;

            var telaItens = new TelaItemForm(tarefa!);

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
            Tarefa tarefa = listagemTarefasControl!.ObterContatoSelecionado();

            if (tarefa == null)
                MessageBox.Show("É necessário selecionar uma tarefa!", "Tarefa Não Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
            
            return tarefa!;
        }

        public void AtualizarItensTarefa()
        {
            Tarefa tarefa = ObterTarefa();

            if (tarefa == null)
                return;

            if(tarefa.EstaConcluida)
            {
                MessageBox.Show("A tarefa selecionada já está concluída!", "Tarefa Concluída", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(tarefa.Itens.Count==0)
            {
                MessageBox.Show("A tarefa selecionada não possui itens cadastrados!", "Atualizar Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var telaAtualizar = new TelaAtualizarTarefaForm(tarefa);
            
            DialogResult opcao = telaAtualizar.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                var itensParaFinalizar = telaAtualizar.itensFinalizado;

                foreach (var item in tarefa.Itens)
                {
                    if (itensParaFinalizar.Contains(item))
                    {
                        item.ConcluirItem();
                    }
                }

                tarefa.CalcularPorcentagemConcluida();

                AtualizarTarefa();
            }

        }

        public override void ConfigurarTela()
        {
            Configuracao = new Configuracao(
            "Tarefa",
            "Inserir Tarefa",
            "Editar Tarefa",
            "Excluir Tarefa","","Adicionar Item Tarefa", "Finalizar Item Tarefa", false, true, true);
        }
    }
}
