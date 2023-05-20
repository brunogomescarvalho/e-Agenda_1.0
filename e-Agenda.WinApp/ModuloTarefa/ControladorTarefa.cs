using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase<RepositorioTarefa, Tarefa>
    {
        public override string ToolTipInserir =>"Inserir Tarefa";

        public override string ToolTipEditar =>"Editar Tarefa";

        public override string ToolTipExcluir =>"Excluir Tarefa";

        public ListagemTarefasControl? listagemTarefasControl;

        public ControladorTarefa(RepositorioTarefa repositorioTarefa)
        {
            RepositorioBase = repositorioTarefa;
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
          
        }

        public override void Inserir()
        {
            TelaTarefaForm telaForm = new TelaTarefaForm();

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

        public override string ObterTipoCadastro()
        {
            return "Cadastro Tarefa";
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
                MessageBox.Show("Para incluir itens é necessário selecionar uma tarefa!", "Tarefa Não Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
            
            return tarefa!;
        }

        public void AtualizarItensTarefa()
        {
            Tarefa tarefa = ObterTarefa();

            if (tarefa == null)
                return;

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
    }
}
