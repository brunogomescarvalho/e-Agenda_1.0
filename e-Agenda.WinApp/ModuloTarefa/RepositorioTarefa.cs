using e_Agenda.WinApp.ModuloCompartilhado;
using System.Collections;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public RepositorioTarefa(List<Tarefa> registros) : base(registros) 
        {
            IncluirAlgunsItens(); 
        }

        public List<Tarefa> ObterTodasTarefas()
        {
            return OrdenadarTarefas(Listar());
        }

        public List<Tarefa> ObterTarefasPendentes()
        {
            return OrdenadarTarefas(registros.FindAll(i => i.EstaConcluida.Equals(false)));
        }

        public List<Tarefa> ObterTarefasConcluidas()
        {
            return OrdenadarTarefas(registros.FindAll(i => i.EstaConcluida.Equals(true)));
        }

        private static List<Tarefa> OrdenadarTarefas(List<Tarefa> tarefas)
        {
            tarefas.Sort(new OrganizadorDePrioridade());

            return tarefas;
        }


        private void IncluirAlgunsItens()
        {
            var item1 = new Item("teste1");
            var item2 = new Item("teste2");
            var item3 = new Item("teste3");
            var item4 = new Item("teste4");
            var item5 = new Item("teste5");
            var item6 = new Item("teste6");
            var item7 = new Item("teste7");
            var item8 = new Item("teste8");
            var item9 = new Item("teste9");
            var item10 = new Item("teste10");
            var item11 = new Item("teste11");

            var tarefa1 = new Tarefa(Prioridade.Alta, "teste");
            var tarefa2 = new Tarefa(Prioridade.Normal, "teste2");

            tarefa1.AtribuirId(11);
            tarefa2.AtribuirId(12);  

            tarefa1.AdicionarItem(new List<Item>() { item1, item2,item3,item4,item5,item6, item7 });
            tarefa2.AdicionarItem(new List<Item>() { item8, item9,item10});

            registros.AddRange(new List<Tarefa>()
            {
             tarefa1,tarefa2
            });
        }
    }
}
