
namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoArquivo : RepositorioBaseArquivo<Contato>, IRepositorioContato
    {
        public RepositorioContatoArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Contato> ObterDados()
        {
            return Contexto.contatos;
        }
    }
}
