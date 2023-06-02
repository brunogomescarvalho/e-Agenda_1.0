
namespace e_Agenda.Dominio.ModuloCompromisso
{
    public static class RepositorioComprimissoExtensions
    {

        public static bool VerificarHorario(this IRepositorioCompromisso Rep, Compromisso c, List<Compromisso> compromissos)
        {
            List<Compromisso> compromissosDoDia = compromissos.FindAll(i => i.Data.Date == c.Data.Date);

            var horarioPesquisarInicio = new TimeOnly(c.HoraInicio.Hour, c.HoraInicio.Minute);
            var horarioPesquisarFinal = new TimeOnly(c.HoraTermino.Hour, c.HoraTermino.Minute);

            if (c.Id > 0)
            {
                compromissosDoDia.Remove(compromissosDoDia.Find(i => i.Id == c.Id)!);
            }

            foreach (var item in compromissosDoDia)
            {
                var horarioJaCadastradoInicio = new TimeOnly(item.HoraInicio.Hour, item.HoraInicio.Minute);
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

    }
}
