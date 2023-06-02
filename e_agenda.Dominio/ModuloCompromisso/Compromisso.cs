using e_Agenda.Dominio.ModuloCompartilhado;
using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.Dominio.ModuloCompromisso;

[Serializable]
public partial class Compromisso : EntidadeBase<Compromisso>
{
    public Contato? Contato { get; set; }
    public string Assunto { get; set; }
    public string Local { get; set; }
    public DateTime Data { get; set; }
    public DateTime HoraInicio { get; set; }
    public DateTime HoraTermino { get; set; }

    public Compromisso() { }

    public Compromisso(Contato? contato, string assunto, string local, DateTime data, DateTime horaInicio, DateTime horaTermino)
    {
        Contato = contato;
        Assunto = assunto;
        Local = local;
        Data = data.Date;
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
        List<string> erros = new();

        if (string.IsNullOrEmpty(Assunto))
            erros.Add("Preencha o campo assunto");

        else if (string.IsNullOrEmpty(Local))
            erros.Add("Preencha o campo local");

        return erros.ToArray();
    }
}
