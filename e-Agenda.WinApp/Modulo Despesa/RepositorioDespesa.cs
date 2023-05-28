
using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.Modulo_Despesa
{
    public class RepositorioDespesa : RepositorioBase<Despesa>
    {
        public RepositorioDespesa(List<Despesa> registros) : base(registros)
        {
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria Categoria)
        {
          return (from n in registros
                 where n.Categorias.Contains(Categoria) select n).ToList();
           
        }
    }
}
