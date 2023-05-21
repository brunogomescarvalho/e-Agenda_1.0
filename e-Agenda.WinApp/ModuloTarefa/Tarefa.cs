using e_Agenda.WinApp.ModuloCompartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {
        public Prioridade Prioridade { get; private set; }

        public List<Item> Itens { get; private set; }

        public string Titulo { get; private set; }

        public DateTime DataCriacao { get; private set; }

        public DateTime? DataConclusao { get; private set; }

        public double PorcentagemConcluida { get; private set; }

        public bool EstaConcluida { get => PorcentagemConcluida == 100; }

        public Tarefa(Prioridade prioridade, string titulo)
        {
            Prioridade = prioridade;

            Itens = new List<Item>();

            Titulo = titulo;

            DataCriacao = DateTime.Now;
        }

        public void AdicionarItem(List<Item> itens)
        {
            this.Itens.Clear();
            this.Itens.AddRange(itens);
        }

        public void CalcularPorcentagemConcluida()
        {
            var porcentagemPorItem = 100 / Itens.Count;

            PorcentagemConcluida = 0;

            foreach (var item in Itens)
            {
                if(item.Concluido == true)
                {
                    PorcentagemConcluida += porcentagemPorItem;
                }
            }

            if(EstaConcluida)
                DataConclusao = DateTime.Now;
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

    }
}
