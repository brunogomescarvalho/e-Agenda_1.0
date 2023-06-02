
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloDespesa;
using e_Agenda.InfraDados.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloDespesa
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
