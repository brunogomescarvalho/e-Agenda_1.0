
namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoArquivo : RepositorioBaseArquivo<Contato>, IRepositorioContato
    {
        protected override string NOME_ARQUIVO { get => "ModuloContato\\contatos.json"; }

        public RepositorioContatoArquivo(List<Contato> registros) : base(registros)
        {
        }


    }
}
