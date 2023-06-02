
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloDespesa;
using e_Agenda.InfraDados.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloDespesa
{
    public class RepositorioDespesaArquivo : RepositorioBaseArquivo<Despesa>,IRepositorioDespesa
    {
        public RepositorioDespesaArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public List<Despesa> ListarDespesasPorCategorias(Categoria Categoria)
        {
            return (from n in registros
                    where n.Categorias.Contains(Categoria)
                    select n).ToList();
        }

        protected override List<Despesa> ObterDados()
        {
            return Contexto.despesas;
        }
    }
}
