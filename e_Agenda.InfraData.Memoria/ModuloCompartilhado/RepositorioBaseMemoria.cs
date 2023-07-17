using e_Agenda.Dominio.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloCompartilhado;
public abstract class RepositorioBaseMemoria<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
{
    protected List<TEntidade> registros;

    private int contador = 0;

    public RepositorioBaseMemoria(List<TEntidade> registros)
    {
        this.registros = registros;
    }

    public virtual void Cadastrar(TEntidade entidade)
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

    public virtual void Editar(TEntidade entidade)
    {
        TEntidade buscada = BuscarPorId(entidade.Id);

        buscada.Editar(entidade);
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
