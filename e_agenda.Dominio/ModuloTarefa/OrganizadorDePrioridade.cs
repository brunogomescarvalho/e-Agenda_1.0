using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.Dominio.ModuloTarefa;
public class OrganizadorDePrioridade : IComparer<Tarefa>
{
    public int Compare(Tarefa? x, Tarefa? y)
    {
        if (x!.Prioridade > y!.Prioridade)
            return 1;

        else if (x.Prioridade == y.Prioridade)
            return 0;

        else return -1;
    }
}