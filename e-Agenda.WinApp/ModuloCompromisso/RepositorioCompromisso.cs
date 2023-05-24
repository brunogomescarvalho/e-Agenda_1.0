using e_Agenda.WinApp.ModuloCompartilhado;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso(List<Compromisso> registros) : base(registros)
        {
            IniciarCompromissos();

        }
        public bool VerificarHorario(Compromisso c)
        {
            var compromissosDoDia = registros.FindAll(i => i.Data.Date == c.Data.Date);

            var horaInicialCompromisso = new TimeSpan(c.HoraInicio.Hour, c.HoraInicio.Minute, c.HoraInicio.Second);
            var horaFinalCompromisso = new TimeSpan(c.HoraTermino.Hour, c.HoraTermino.Minute, c.HoraTermino.Second);

            foreach (Compromisso item in compromissosDoDia)
            {
                var horarioJaCadastradoInicio = new TimeSpan(item.HoraInicio.Hour, item.HoraInicio.Minute, item.HoraInicio.Second);
                var horarioJaCadastradoFinal = new TimeSpan(item.HoraTermino.Hour, item.HoraTermino.Minute, item.HoraTermino.Second);

                if (horaInicialCompromisso <= horarioJaCadastradoInicio && horaFinalCompromisso >= horarioJaCadastradoFinal)
                    return false;
                else if (horaInicialCompromisso <= horarioJaCadastradoInicio && horaFinalCompromisso >= horarioJaCadastradoFinal)
                    return false;
                else if (horaFinalCompromisso <= horarioJaCadastradoInicio && horaFinalCompromisso <= horarioJaCadastradoFinal)
                    return false;
                else if (horaInicialCompromisso >= horarioJaCadastradoInicio && horaFinalCompromisso <= horarioJaCadastradoFinal)
                    return false;
            }

            return true;

        }

        public List<Compromisso>BuscarPassados()
        {
            return registros.FindAll(i => i.Data.Date < DateTime.Now.Date || i.Data.Date <= DateTime.Now.Date && i.HoraInicio.Hour < DateTime.Now.Hour);
        }

        public List<Compromisso>BuscarProximos()
        {
            return registros.FindAll(i => i.Data.Date > DateTime.Now.Date || i.Data.Date >= DateTime.Now.Date && i.HoraInicio.Hour > DateTime.Now.Hour);
        }

        public List<Compromisso>BuscarDeHoje()
        {
            return registros.FindAll(i=>i.Data.Date == DateTime.Now.Date && i.HoraInicio.Hour > DateTime.Now.Hour );
        }

        public List<Compromisso> BuscarPorDatas(DateTime dataInicial, DateTime dataFinal)
        {
            return registros.FindAll(i=>i.Data.Date >= dataInicial && i.Data.Date <= dataFinal);
        }



        private void IniciarCompromissos()
        {
            var listCompromissos = new List<Compromisso> {
            new Compromisso(null, "Implementar Nova solução", "Centro de Tecnologia", DateTime.Now.AddDays(-5), new DateTime(1,1,1, 10, 30,00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Reunião de equipe", "Sala de conferências", DateTime.Now.AddDays(-4), new DateTime(1,1,1, 11, 30, 00), new DateTime(1,1,1, 12, 00, 00)),
            new Compromisso(null, "Treinamento de vendas", "Auditório principal", DateTime.Now.AddDays(-3), new DateTime(1,1,1, 10, 30, 00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Entrevista de emprego", "Centro de Tecnologia Sala 3B", DateTime.Now.AddDays(-2), new DateTime(1,1,1, 9, 00, 00), new DateTime(1,1,1, 10, 30, 00)),
            new Compromisso(null, "Almoço de negócios", "Restaurante Hotel", DateTime.Now.Date,  new DateTime(1,1,1, 12, 30, 00),  new DateTime(1,1,1, 13, 30, 00)),
            new Compromisso(null, "Reunião de planejamento", "Sala de projetos", DateTime.Now.AddDays(1), new DateTime(1,1,1, 14, 30, 00), new DateTime(1,1,1, 15, 30, 00)),
            new Compromisso(null, "Workshop de inovação", "Centro de convenções", DateTime.Now.AddDays(2), new DateTime(1,1,1, 10, 30, 00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Apresentação de produtos", "Showroom", DateTime.Now.AddDays(3), new DateTime(1,1,1, 15, 30, 00), new DateTime(1,1,1, 16, 30, 00)),
            new Compromisso(null, "Reunião com fornecedor", "Escritório 5A", DateTime.Now.AddDays(4), new DateTime(1,1,1, 10, 00, 00), new DateTime(1,1,1, 11, 30, 00)),
            new Compromisso(null, "Lançamento do novo projeto", "Sala de conferências 2", DateTime.Now.AddDays(5), new DateTime(1,1,1, 13, 30, 00), new DateTime(1,1,1, 15, 30, 00))};

            for (int i = 0; i < listCompromissos.Count; i++)
            {
                this.Cadastrar(listCompromissos[i]);
            }

        }

    }
}
