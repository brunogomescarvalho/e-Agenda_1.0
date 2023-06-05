namespace e_Agenda.Dominio.ModuloTarefa;

[Serializable]
public class ItemTarefa
{
    public string Descricao { get;private set; } = string.Empty;
    public bool Concluido { get; private set; }

    public ItemTarefa() { }

    public ItemTarefa(string descricao)
    {
        Descricao = descricao;
        Concluido = false;
    }

    public void TornarConcluida()
    {
        Concluido = true;
    }

    public void TornarPendente()
    {
        Concluido = false;
    }

    public string[] Validar()
    {
        List<string> erros = new();

        if(Descricao.Trim().Length > 0) { erros.Add("Preencha o campo Descrição"); }

        return erros.ToArray();
    }


    public override string ToString()
    {
        return $"{Descricao,-15}";
    }

    public override bool Equals(object? obj)
    {
        return obj is ItemTarefa item &&
               Descricao == item.Descricao &&
               Concluido == item.Concluido;
    }

}
