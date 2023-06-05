using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCompartilhado;

namespace e_Agenda.Dominio.ModuloDespesa
{
    public interface IRepositorioDespesa : IRepositorioBase<Despesa>
    {
        List<Despesa> ListarDespesasPorCategorias(Categoria Categoria);
    }
}
