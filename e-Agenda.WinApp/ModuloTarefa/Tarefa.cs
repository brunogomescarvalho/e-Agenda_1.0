using e_Agenda.WinApp.ModuloCompartilhado;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {
        public Prioridade Prioridade { get; private set; }

        public List<Item> Itens { get; private set; }

        public string Titulo { get; private set; }

        public DateTime DataCriacao { get; private set; }

        public DateTime DataConclusao { get; private set; }

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
        }


        public List<Item>BuscarItensNaoConcluidos()
        {
            return Itens.FindAll(i => i.Concluido == false);
        }

        public List<Item> BuscarItensConcluidos()
        {
            return Itens.FindAll(i => i.Concluido == true);
        }

        public override void Editar(Tarefa entidade)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Id,-5} {Prioridade,-10} {DataCriacao,-15:d} {(EstaConcluida? $"{DataConclusao,-15:d}": $"{"Não Conluída",-15}")} {PorcentagemConcluida}%";
        }
    }

    public enum Prioridade
    {
        Alta,Normal,Baixa
    }

    public class Item
    {
        private string Descricao { get; set; }

        public bool Concluido { get; private set; }

        public Item(string descricao)
        {
            Descricao = descricao;
            Concluido = false;
        }

        public void ConcluirItem()
        {
            Concluido = true;
        }


        public override string ToString()
        {
            return $"{Descricao,-15} {(Concluido? "Concluído": "Não Conlcuído")}";
        }

    }
}
