using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloContato;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public Contato? Contato { get; private set; }
        public string Assunto { get; private set; }
        public string Local { get; private set; }
        public DateTime Data { get; private set; }
        public TimeOnly HoraInicio { get; private set; }
        public TimeOnly HoraTermino { get; private set; }

        public Compromisso(Contato? contato, string assunto, string local, DateTime data, DateTime horaInicio, DateTime horaTermino)
        {
            Contato = contato;
            Assunto = assunto;
            Local = local;
            Data = data.Date;
            HoraInicio = new TimeOnly(horaInicio.Hour,horaInicio.Minute,horaInicio.Second);
            HoraTermino = new TimeOnly(horaTermino.Hour, horaTermino.Minute, horaTermino.Second);
        }

        public override void Editar(Compromisso compromisso)
        {
            Contato = compromisso.Contato;
            Assunto = compromisso.Assunto;
            Local = compromisso.Local;
            Data = compromisso.Data;
            HoraInicio = new TimeOnly(compromisso.HoraInicio.Hour, compromisso.HoraInicio.Minute, compromisso.HoraInicio.Second);
            HoraTermino = new TimeOnly(compromisso.HoraTermino.Hour, compromisso.HoraTermino.Minute, compromisso.HoraTermino.Second);
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Assunto))
                erros.Add("Preencha o campo assunto");

            else if (string.IsNullOrEmpty(Local))
                erros.Add("Preencha o campo local");

            return erros.ToArray();
        }

      
    }
}
