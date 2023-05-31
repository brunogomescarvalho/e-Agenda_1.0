
namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoArquivo : RepositorioBaseArquivo<Contato>, IRepositorioContato
    {
        protected override string NOME_ARQUIVO { get => @"C:\arquivosProjetos\e-Agenda\Contatos_eAgenda.bin"; }

        public RepositorioContatoArquivo(List<Contato> registros) : base(registros)
        {
        }


    }
}
