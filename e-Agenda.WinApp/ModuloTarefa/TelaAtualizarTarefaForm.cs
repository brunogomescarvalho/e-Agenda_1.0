
using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizarTarefaForm : Form
    {
        public TelaAtualizarTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            MostrarTabela(tarefa);

        }

        private void MostrarTabela(Tarefa tarefa)
        {
            textNumero.Text = tarefa.Id.ToString();

            textTitulo.Text = tarefa.Titulo.ToString();

            textPrioridade.Text = tarefa.Prioridade.ToString();

            textProgresso.Text = tarefa.PorcentagemConcluida.ToString() + " %";

            listItens.Items.Clear();

            List<ItemTarefa> itensTarefa = tarefa.BuscarItens();

            itensTarefa.ForEach(i => listItens.Items.Add(i));

            for (int i = 0; i < itensTarefa.Count; i++)
            {
                if (itensTarefa[i].Concluido)
                {
                    listItens.SetItemChecked(i, true);
                }
            }
        }

        public List<ItemTarefa> BuscarItensSelecionados()
        {
            return listItens.CheckedItems.Cast<ItemTarefa>().ToList();
        }

        public List<ItemTarefa> BuscarItensNaoSelecionados()
        {
            return listItens.Items.Cast<ItemTarefa>().ToList().Except(BuscarItensSelecionados()).ToList();
        }
    }
}
