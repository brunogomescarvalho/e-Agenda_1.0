
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.InfraDados.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloCategoria
{
    public class RepositorioCategoriaArquivo : RepositorioBaseArquivo<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        public override bool Cadastrar(Categoria entidade)
        {
            if (VerificarItemJaCadastrado(entidade) == false)
            {
                return false;
            }

            return base.Cadastrar(entidade);
        }

        public override bool Editar(Categoria entidade)
        {
            if (VerificarItemJaCadastrado(entidade) == false)
            {
                return false;
            }

            return base.Editar(entidade);

        }
        public bool VerificarItemJaCadastrado(Categoria entidade)
        {
            if (registros.Any(i => i.Nome.TirarAcentosPalavra().ToLower() == entidade.Nome.TirarAcentosPalavra().ToLower() && i.Id != entidade.Id))
            {
                return false;
            }
            return true;
        }

        protected override List<Categoria> ObterDados()
        {
            return Contexto.categorias;
        }
    }
}
