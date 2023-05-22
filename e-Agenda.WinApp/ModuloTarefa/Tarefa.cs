using e_Agenda.WinApp.ModuloCompartilhado;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace e_Agenda.WinApp.ModuloTarefa
{

    public delegate void onTarefaConcluidaEventHandler();

    public class Tarefa : EntidadeBase<Tarefa>
    {
        public Prioridade Prioridade { get; private set; }

        public List<Item> Itens { get; private set; }

        public string Titulo { get; private set; }

        public DateTime DataCriacao { get; private set; }

        public DateTime? DataConclusao { get; private set; }

        public decimal PorcentagemConcluida { get; private set; }

        public bool EstaConcluida { get => PorcentagemConcluida == 100; }

        public event onTarefaConcluidaEventHandler TarefaConcluidaEventHandler = null!;
        public Tarefa(Prioridade prioridade, string titulo)
        {
            Prioridade = prioridade;

            Itens = new List<Item>();

            Titulo = titulo;

            DataCriacao = DateTime.Now;
            
        }

        public void AdicionarItem(List<Item> itens)
        {
            this.Itens.AddRange(itens);
        }

        public void CalcularPorcentagemConcluida()
        {
            decimal porcentagemPorItem = Math.Round(100M / Itens.Count, 2);

            PorcentagemConcluida = 0;

            PorcentagemConcluida = Itens.Sum(item => item.Concluido ? porcentagemPorItem : 0);

            bool finalizou = Itens.Exists(i => i.Concluido == false) == false;

            if (finalizou)
            {
                PorcentagemConcluida = 100;
                DataConclusao = DateTime.Now;

                TarefaConcluidaEventHandler();
            }
        }


        public List<Item>BuscarItensNaoConcluidos()
        {
            return Itens.FindAll(i => i.Concluido == false);
        }

        public List<Item> BuscarItensConcluidos()
        {
            return Itens.FindAll(i => i.Concluido == true);
        }

        public override void Editar(Tarefa tarefa)
        {
            this.Prioridade = tarefa.Prioridade;
            this.Titulo = tarefa.Titulo;
        }

        public override string ToString()
        {
            return $"{Id,-5} {Prioridade,-10} {DataCriacao,-15:d} {(EstaConcluida ? $"{DataConclusao,-15:d}" : $"{"Não Concluída",-15}")} {PorcentagemConcluida}%";
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
}
