
namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public abstract class RepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected List<TEntidade> registros;

        private int contador = 0;

        public RepositorioBase(List<TEntidade> registros)
        {
            this.registros = registros;
        }

        public void Cadastrar(TEntidade entidade)
        {
            entidade.AtribuirId(++contador);
            registros.Add(entidade);
        }

        public List<TEntidade>Listar()
        {
            return registros;
        }

        public TEntidade BuscarPorId(int id)
        {
            return registros.FirstOrDefault(x => x.Id == id)!;
        }

        public void Editar(TEntidade entidade)
        {
            TEntidade buscada = BuscarPorId(entidade.Id);

            buscada.Editar(entidade);
        }

        public void Excluir(TEntidade entidade)
        {
            TEntidade buscada = BuscarPorId(entidade.Id);

            registros.Remove(buscada);
        }
    }
}
