
namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromissoArquivo : RepositorioBaseArquivo<Compromisso>,IRepositorioCompromisso
    {
        public RepositorioCompromissoArquivo(List<Compromisso> registros) : base(registros)
        {
        }

        protected override string NOME_ARQUIVO => "ModuloCompromisso\\compromissos.json";


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
    }
}
