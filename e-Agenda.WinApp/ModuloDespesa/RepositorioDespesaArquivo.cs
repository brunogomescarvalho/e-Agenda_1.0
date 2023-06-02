using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
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
