
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.InfraDados.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloContato
{
    public class RepositorioContatoArquivo : RepositorioBaseArquivo<Contato>, IRepositorioContato
    {
        public RepositorioContatoArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Contato> ObterDados()
        {
            return Contexto.Contatos;
        }
    }
}
