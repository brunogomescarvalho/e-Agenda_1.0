
namespace e_Agenda.WinApp.ModuloTarefa;

public delegate void onTarefaConcluidaEventHandler();
public class Tarefa : EntidadeBase<Tarefa>
{
    public Prioridade Prioridade { get; private set; }

    public List<ItemTarefa> Itens { get; private set; }

    public string Titulo { get; private set; }

    public DateTime DataCriacao { get; private set; }

    public DateTime? DataConclusao { get; private set; }

    public decimal PorcentagemConcluida { get; private set; }

    public bool EstaConcluida { get => PorcentagemConcluida == 100; }


    public event onTarefaConcluidaEventHandler TarefaConcluidaEventHandler = null!;

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
    }

    private void CalcularPorcentagemConcluida()
    {

        decimal finalizados = Itens.Count(i => i.Concluido == true);

        decimal qtdDeItens = Itens.Count;

        PorcentagemConcluida = Math.Round(finalizados/qtdDeItens * 100, 2);

        if (EstaConcluida)
        {
            DataConclusao = DateTime.Now;
            TarefaConcluidaEventHandler();
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

        else if (DataCriacao.Date < DateTime.Now)
            erros.Add("Não é possível cadastrar tarefa data datas passadas");

        return erros.ToArray();
    }

    
}
