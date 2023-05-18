using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class Compromisso : EntidadeBase<Compromisso>
    {
        public Contato? Contato { get; set; }
        public string Assunto { get; set; }
        public string Local { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraTermino { get; set; }

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

        public override string ToString()
        {
            string nomeContato = $"{Contato?.Nome,-20}";
            string emailContato = $"{Contato?.Email,-15}";
            string contatoNaoCadastrado = $"{"Contato não Cadastrado",-35}";

            return $"{Id,-5} {(Contato == null ? contatoNaoCadastrado : nomeContato + emailContato)} {Assunto,-40} {Local,-40} {Data,-25:d} {HoraInicio,-5:t} {HoraTermino,-5:t}";
        }
    }
}
