
namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoriaMemoria : RepositorioBaseMemoria<Categoria>,IRepositorioCategoria
    {
        public RepositorioCategoriaMemoria(List<Categoria> registros) : base(registros)
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
    }
}
