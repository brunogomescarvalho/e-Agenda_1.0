using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public class RepositorioDespesaArquivo : RepositorioBaseArquivo<Despesa>,IRepositorioDespesa
    {
        public RepositorioDespesaArquivo(List<Despesa> registros) : base(registros)
        {
        }

        protected override string NOME_ARQUIVO => "ModuloDespesa\\despesas.json";

        public List<Despesa> ListarDespesasPorCategorias(Categoria Categoria)
        {
            return (from n in registros
                    where n.Categorias.Contains(Categoria)
                    select n).ToList();
        }
    }
}
