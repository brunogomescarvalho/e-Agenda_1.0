using e_Agenda.Dominio.ModuloCompartilhado;
using System.Text.RegularExpressions;

namespace e_Agenda.Dominio.ModuloContato;

[Serializable]
public class Contato : EntidadeBase<Contato>
{
    public string Nome { get;  set; } = string.Empty;
    public string Email { get;  set; } = string.Empty;
    public string Telefone { get;  set; } = string.Empty;
    public string Empresa { get;  set; } = string.Empty;
    public string Cargo { get;  set; } = string.Empty;

    public Contato() { }

    public Contato(string nome, string email, string telefone, string empresa, string cargo)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        Empresa = empresa;
        Cargo = cargo;
    }


    public override void Editar(Contato contato)
    {
        Nome = contato.Nome;
        Email = contato.Email;
        Telefone = contato.Telefone;
        Empresa = contato.Empresa;
        Cargo = contato.Cargo;
    }

    public override string[] Validar()
    {
        List<string> erros = new List<string>();

        if (string.IsNullOrEmpty(Nome))
            erros.Add("Preencha o campo nome");

        else if (string.IsNullOrEmpty(Email))
            erros.Add("Preencha o campo e-mail");

        else if (!EmailEhValido(Email))
            erros.Add("E-mail fora do padrão");

        else if (string.IsNullOrEmpty(Telefone))
            erros.Add("Preencha o campo telefone");

        else if (!TelefoneEhValido(Telefone))
            erros.Add("Telefone fora do padrao");

        return erros.ToArray();
    }

    private static bool TelefoneEhValido(string telefone)
    {
        string padrao = @"^(?:\([1-9]{2}\)\s?)?(?:9\d{4}-\d{4}|\d{4}-\d{4})$";

        return Regex.IsMatch(telefone, padrao);

    }

    private static bool EmailEhValido(string email)
    {
        string padrao = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.(?:com\.br|com)$";

        return Regex.IsMatch(email, padrao);
    }

    public override string ToString()
    {
        return $"Id: {Id} - Nome: {Nome} - Telefone: {Telefone} - Empresa: {Empresa}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Contato contato &&
               Nome == contato.Nome &&
               Email == contato.Email &&
               Telefone == contato.Telefone &&
               Empresa == contato.Empresa &&
               Cargo == contato.Cargo;
    }
}
