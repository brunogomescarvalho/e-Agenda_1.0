
using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.Modulo_Despesa
{
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {
        public RepositorioDespesa(List<Despesa> registros) : base(registros)
        {
        }

        public List<Despesa> ListarDespesasPorCategorias(int idCategoria)
        {
            return registros.Where(c=>c.Id == idCategoria).ToList();
        }
    }
}
