
using e_Agenda.Dominio.ModuloCompartilhado;

namespace e_Agenda.Dominio.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        List<Tarefa> ObterTodasTarefas();

        List<Tarefa> ObterTarefasPendentes();

        List<Tarefa> ObterTarefasConcluidas();

        List<Tarefa> OrdenadarTarefas(List<Tarefa> tarefas);


    }
}
