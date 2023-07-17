
namespace e_Agenda.Dominio.ModuloCompartilhado
{
    public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        void Cadastrar(TEntidade entidade);

        void Editar(TEntidade entidade);

        TEntidade BuscarPorId(int id);

        void Excluir(TEntidade entidade);

        void Excluir(int id);

        List<TEntidade> Listar();
    }
}
