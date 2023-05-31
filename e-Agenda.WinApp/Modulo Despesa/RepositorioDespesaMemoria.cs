
using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.Modulo_Despesa
{
    public class RepositorioDespesaMemoria : RepositorioBaseMemoria<Despesa>,IRepositorioDespesa
    {
        public RepositorioDespesaMemoria(List<Despesa> registros) : base(registros)
        {
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria Categoria)
        {
          return (from n in registros
                 where n.Categorias.Contains(Categoria) select n).ToList();
           
        }
    }
}
