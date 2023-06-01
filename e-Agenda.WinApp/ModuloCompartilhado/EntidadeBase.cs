using System.Text.Json.Serialization;

namespace e_Agenda.WinApp.ModuloCompartilhado;

[Serializable]
public abstract class EntidadeBase<TEntidade>
{
   
    public int Id { get; set; }

    public void AtribuirId(int id)
    {
        this.Id = id;
    }

    public abstract void Editar(TEntidade entidade);

    public abstract string[] Validar();
}
