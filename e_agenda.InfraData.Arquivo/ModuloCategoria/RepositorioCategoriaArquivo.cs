
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.InfraDados.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloCategoria
{
    public class RepositorioCategoriaArquivo : RepositorioBaseArquivo<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public override void Cadastrar(Categoria entidade)
        {
            if (!CategoriaJaCadastrada(entidade))
            {
                base.Cadastrar(entidade);
            }
        }

        public override void Editar(Categoria entidade)
        {
            if (CategoriaJaCadastrada(entidade) == false)
            {
                base.Editar(entidade);
            }
        }
        public bool CategoriaJaCadastrada(Categoria entidade)
        {
            return registros.Any(i => i.Nome.TirarAcentosPalavra().ToLower() == entidade.Nome.TirarAcentosPalavra().ToLower() && i.Id != entidade.Id);
        }

        protected override List<Categoria> ObterDados()
        {
            return Contexto.Categorias;
        }

        public Categoria BuscarPorNome(string nome)
        {
            return registros.FirstOrDefault(i => i.Nome == nome)!;
        }
    }
}
