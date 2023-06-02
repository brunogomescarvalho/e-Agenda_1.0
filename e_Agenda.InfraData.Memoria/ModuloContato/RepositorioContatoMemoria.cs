
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.InfraDados.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloContato
{
    public class RepositorioContatoMemoria : RepositorioBaseMemoria<Contato>, IRepositorioContato
    {
        public RepositorioContatoMemoria(List<Contato> registros) : base(registros)
        {
            
        }
    }
}
