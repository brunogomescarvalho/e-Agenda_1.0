using e_Agenda.Dominio.ModuloCompartilhado;

namespace e_Agenda.Dominio.ModuloCompromisso
{
    public interface IRepositorioCompromisso : IRepositorioBase<Compromisso>
    {
        bool VerificarHorarioDisponivel(Compromisso compromisso);

        List<Compromisso> BuscarPorDatas(DateTime startDate, DateTime endDate);

        List<Compromisso> BuscarPassados();

        List<Compromisso> BuscarProximos();

        List<Compromisso> BuscarDeHoje();
    }
}
