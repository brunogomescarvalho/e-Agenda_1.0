using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorioBase<Tarefa>
    {
        List<Tarefa> ObterTodasTarefas();

        List<Tarefa> ObterTarefasPendentes();

        List<Tarefa> ObterTarefasConcluidas();

        List<Tarefa> OrdenadarTarefas(List<Tarefa> tarefas);


    }
}
