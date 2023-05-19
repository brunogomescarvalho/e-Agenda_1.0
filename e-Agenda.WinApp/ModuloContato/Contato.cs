using e_Agenda.WinApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class Contato : EntidadeBase<Contato>
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Empresa { get; set; }

        public string Cargo { get; set; }


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

        public override string ToString()
        {
            return $"{Id,-5} {Nome, -20} {Telefone,-20} {Email,-20} {Empresa,-20} {Cargo,-10}";
        }
    }
}
