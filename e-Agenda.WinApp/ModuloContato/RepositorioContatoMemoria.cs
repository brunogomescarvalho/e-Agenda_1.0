
namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoMemoria : RepositorioBaseMemoria<Contato>, IRepositorioContato
    {
        public RepositorioContatoMemoria(List<Contato> registros) : base(registros)
        {
            
        }
    }
}
