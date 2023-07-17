
using e_Agenda.Dominio.ModuloCompartilhado;

namespace e_Agenda.Dominio.ModuloCategoria
{
    public interface IRepositorioCategoria:IRepositorioBase<Categoria>
    {
        public Categoria BuscarPorNome(string nome);
    }
}
