
namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public abstract class EntidadeBase<TEntidade>
    {
        public int Id { get; private set; }

        public void AtribuirId(int id)
        {
            this.Id = id;
        }

        public abstract void Editar(TEntidade entidade);

        public abstract string[] Validar();
    }
}
