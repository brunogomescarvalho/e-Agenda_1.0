namespace e_Agenda.WinApp.ModuloCompartilhado;
public abstract class RepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
{
    protected List<TEntidade> registros;

    private int contador = 0;

    public RepositorioBase(List<TEntidade> registros)
    {
        this.registros = registros;
    }

    public virtual bool Cadastrar(TEntidade entidade)
    {
        entidade.AtribuirId(++contador);

        registros.Add(entidade);

        return true;
    }

    public List<TEntidade>Listar()
    {
        return registros;
    }

    public TEntidade BuscarPorId(int id)
    {
        return registros.FirstOrDefault(x => x.Id == id)!;
    }

    public virtual bool Editar(TEntidade entidade)
    {
        TEntidade buscada = BuscarPorId(entidade.Id);

        buscada.Editar(entidade);

        return true;
    }

    public void Excluir(TEntidade entidade)
    {
        registros.Remove(entidade);
    }

    public void Excluir(int id)
    {
        TEntidade entidade = BuscarPorId(id);

        registros.Remove(entidade);
    }
}
