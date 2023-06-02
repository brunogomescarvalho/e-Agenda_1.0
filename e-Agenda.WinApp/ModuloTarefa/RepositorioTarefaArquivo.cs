
namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaArquivo : RepositorioBaseArquivo<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaArquivo(ContextoDados contexto) : base(contexto)
        {
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

        public List<Tarefa> OrdenadarTarefas(List<Tarefa> tarefas)
        {
            tarefas.Sort(new OrganizadorDePrioridade());

            return tarefas;
        }

        protected override List<Tarefa>ObterDados()
        {
            return Contexto.tarefas;
        }
    }
}
