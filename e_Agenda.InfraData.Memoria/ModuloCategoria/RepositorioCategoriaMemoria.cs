
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.InfraDados.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloCategoria
{
    public class RepositorioCategoriaMemoria : RepositorioBaseMemoria<Categoria>,IRepositorioCategoria
    {
        public RepositorioCategoriaMemoria(List<Categoria> registros) : base(registros)
        {
        }

        public Categoria BuscarPorNome(string nome)
        {
            return registros.FirstOrDefault(i => i.Nome == nome)!;
        }

        public override void Cadastrar(Categoria entidade)
        {
            if (!VerificarItemJaCadastrado(entidade))
            {
                base.Cadastrar(entidade);
            }

        }

        public override void Editar(Categoria entidade)
        {
            if (VerificarItemJaCadastrado(entidade) == false)
            {
                base.Editar(entidade);
            }      
        }
        public bool VerificarItemJaCadastrado(Categoria entidade)
        {
            return registros.Any(i => i.Nome.TirarAcentosPalavra().ToLower() == entidade.Nome.TirarAcentosPalavra().ToLower() && i.Id != entidade.Id);        
        }
    }
}
