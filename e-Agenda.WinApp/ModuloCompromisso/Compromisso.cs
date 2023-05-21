using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public Contato? Contato { get; private set; }
        public string Assunto { get; private set; }
        public string Local { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime HoraInicio { get; private set; }
        public DateTime HoraTermino { get; private set; }

        public Compromisso(Contato? contato, string assunto, string local, DateTime data, DateTime horaInicio, DateTime horaTermino)
        {
            Contato = contato;
            Assunto = assunto;
            Local = local;
            Data = data;
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
        }

        public override void Editar(Compromisso compromisso)
        {
            Contato = compromisso.Contato;
            Assunto = compromisso.Assunto;
            Local = compromisso.Local;
            Data = compromisso.Data;
            HoraInicio = compromisso.HoraInicio;
            HoraTermino = compromisso.HoraTermino;
        }
    }
}
