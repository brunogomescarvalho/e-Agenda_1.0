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
