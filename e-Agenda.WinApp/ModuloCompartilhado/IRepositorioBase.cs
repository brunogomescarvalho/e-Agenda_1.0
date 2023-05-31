
namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        bool Cadastrar(TEntidade entidade);

        bool Editar(TEntidade entidade);

        TEntidade BuscarPorId(int id);

        void Excluir(TEntidade entidade);

        void Excluir(int id);

        List<TEntidade> Listar();
    }
}
