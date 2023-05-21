using e_Agenda.WinApp.ModuloCompartilhado;
using System.Collections;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public RepositorioTarefa(List<Tarefa> registros) : base(registros) { }
   
        public List<Tarefa> ObterTarefasPendentes()
        {
            return registros.FindAll(i => i.EstaConcluida.Equals(false));
        }

        public List<Tarefa> ObterTarefasConcluidas()
        {
            return registros.FindAll(i => i.EstaConcluida.Equals(true));
        }


        public List<Tarefa> ObterTarefasPorPrioridade()
        {
            var tarefasPendentes = ObterTarefasPendentes();

            tarefasPendentes.Sort(new OrganizadorDePrioridade());

            return tarefasPendentes;
        }

    }
}
