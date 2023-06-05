
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.InfraDados.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloCompromisso
{
    public class RepositorioCompromissoArquivo : RepositorioBaseArquivo<Compromisso>,IRepositorioCompromisso
    {
        public RepositorioCompromissoArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public bool VerificarHorarioDisponivel(Compromisso c)
        {
            return this.VerificarHorario(c, registros);
        }

        public List<Compromisso> BuscarPassados()
        {
            return registros.Where(i => i.Data.Date < DateTime.Now.Date || i.Data.Date <= DateTime.Now.Date && i.HoraInicio.Hour < DateTime.Now.Hour).ToList();
        }

        public List<Compromisso> BuscarProximos()
        {
            return registros.Where(i => i.Data.Date > DateTime.Now.Date || i.Data.Date >= DateTime.Now.Date && i.HoraInicio.Hour > DateTime.Now.Hour).ToList();
        }

        public List<Compromisso> BuscarDeHoje()
        {
            return registros.Where(i => i.Data.Date == DateTime.Now.Date && i.HoraInicio.Hour > DateTime.Now.Hour).ToList();
        }

        public List<Compromisso> BuscarPorDatas(DateTime dataInicial, DateTime dataFinal)
        {
            return registros.Where(i => i.Data.Date >= dataInicial && i.Data.Date <= dataFinal).ToList();
        }

        protected override List<Compromisso> ObterDados()
        {
            return Contexto.compromissos;
        }
    }
}
