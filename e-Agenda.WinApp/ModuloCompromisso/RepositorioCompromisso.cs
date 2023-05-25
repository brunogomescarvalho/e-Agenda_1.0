namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso(List<Compromisso> registros) : base(registros)
        {
           
        }
        public bool VerificarHorarioDisponivel(Compromisso c)
        {
            List<Compromisso> compromissosDoDia = registros.FindAll(i => i.Data.Date == c.Data.Date);

            var horarioPesquisarInicio = new TimeOnly(c.HoraInicio.Hour, c.HoraInicio.Minute);
            var horarioPesquisarFinal = new TimeOnly(c.HoraTermino.Hour, c.HoraTermino.Minute);

            foreach (var item in compromissosDoDia)
            {
                var horarioJaCadastradoInicio = new TimeOnly(item.HoraInicio.Hour,item.HoraInicio.Minute);
                var horarioJaCadastradoFinal = new TimeOnly(item.HoraTermino.Hour, item.HoraTermino.Minute);

                if (horarioPesquisarInicio >= horarioJaCadastradoInicio && 
                    horarioPesquisarInicio <= horarioJaCadastradoFinal)
                    return false;

                else if (horarioPesquisarFinal >= horarioJaCadastradoInicio && 
                         horarioPesquisarFinal <= horarioJaCadastradoFinal)
                    return false;

                else if (horarioPesquisarInicio >= horarioJaCadastradoInicio && 
                         horarioPesquisarInicio <= horarioJaCadastradoFinal &&
                         horarioPesquisarFinal >= horarioJaCadastradoInicio && 
                         horarioPesquisarFinal <= horarioJaCadastradoFinal)
                    return false;

                else if (horarioPesquisarInicio <= horarioJaCadastradoInicio && 
                         horarioPesquisarInicio <= horarioJaCadastradoFinal && 
                         horarioPesquisarFinal >= horarioJaCadastradoFinal &&
                         horarioPesquisarFinal >= horarioJaCadastradoInicio)
                    return false;

            }


            return true;

        }

        public List<Compromisso>BuscarPassados()
        {
            return registros.Where(i => i.Data.Date < DateTime.Now.Date || i.Data.Date <= DateTime.Now.Date && i.HoraInicio.Hour < DateTime.Now.Hour).ToList();
        }

        public List<Compromisso>BuscarProximos()
        {
            return registros.Where(i => i.Data.Date > DateTime.Now.Date || i.Data.Date >= DateTime.Now.Date && i.HoraInicio.Hour > DateTime.Now.Hour).ToList();
        }

        public List<Compromisso>BuscarDeHoje()
        {
            return registros.Where(i => i.Data.Date == DateTime.Now.Date && i.HoraInicio.Hour > DateTime.Now.Hour).ToList();
        }

        public List<Compromisso> BuscarPorDatas(DateTime dataInicial, DateTime dataFinal)
        {
            return registros.Where(i => i.Data.Date >= dataInicial && i.Data.Date <= dataFinal).ToList();
        }
    }
}
