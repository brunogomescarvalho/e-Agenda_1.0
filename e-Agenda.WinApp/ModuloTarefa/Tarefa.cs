
namespace e_Agenda.WinApp.ModuloTarefa;

public class Tarefa : EntidadeBase<Tarefa>
{
    public Prioridade Prioridade { get; private set; }

    public List<ItemTarefa> Itens { get; private set; }

    public string Titulo { get; private set; }

    public DateTime DataCriacao { get; private set; }

    public DateTime? DataConclusao { get; private set; }

    public decimal PorcentagemConcluida { get; private set; }

    public bool EstaConcluida { get => PorcentagemConcluida == 100; }

    public Tarefa(Prioridade prioridade, string titulo)
    {
        Prioridade = prioridade;

        Itens = new List<ItemTarefa>();

        Titulo = titulo;

        DataCriacao = DateTime.Now;
        
    }

    public void AdicionarItem(ItemTarefa item)
    {
        this.Itens.Add(item);
        CalcularPorcentagemConcluida();
    }

    private void CalcularPorcentagemConcluida()
    {

        decimal finalizados = Itens.Count(i => i.Concluido == true);

        decimal qtdDeItens = Itens.Count;

        PorcentagemConcluida = Math.Round(finalizados/qtdDeItens * 100, 2);

        if (EstaConcluida)
        {
            DataConclusao = DateTime.Now;
        }
    }

    public List<ItemTarefa> BuscarItens()
    {
        return Itens;
    }

    public override void Editar(Tarefa tarefa)
    {
        this.Prioridade = tarefa.Prioridade;
        this.Titulo = tarefa.Titulo;
        this.Itens = tarefa.Itens;
    }


    public override string ToString()
    {
        return $"{$"Tarefa: {Titulo}",-10} {$"Prioridade: {Prioridade}",-8} Progresso: {PorcentagemConcluida}%";
    }

    public void TornarItemConcluido(ItemTarefa item)
    {
        ItemTarefa itemParaFinalizar = Itens.FirstOrDefault(i => i.Equals(item))!;

        itemParaFinalizar.TornarConcluida();

        CalcularPorcentagemConcluida();

    }
    public void TornarItemPendente(ItemTarefa item)
    {
        ItemTarefa itemParaFinalizar = Itens.FirstOrDefault(i => i.Equals(item))!;

        itemParaFinalizar.TornarPendente();

        CalcularPorcentagemConcluida();
    }

    public override string[] Validar()
    {
        List<string> erros = new List<string>();

        if (string.IsNullOrEmpty(Titulo))
            erros.Add("Preencha o campo título");

        else if (string.IsNullOrEmpty(Prioridade.ToString()))
            erros.Add("Selecione a prioridade da tarefa");

        return erros.ToArray();
    }

    
}
