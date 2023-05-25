
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizarTarefaForm : Form
    {

        private List<ItemTarefa> itensFinalizado = new List<ItemTarefa>();

        public TelaAtualizarTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            MostrarTabela(tarefa);

        }

        private void MostrarTabela(Tarefa tarefa)
        {
            textTarefa.Text = $"{tarefa}";

            progressoTarefa.Value = Convert.ToInt32(tarefa.PorcentagemConcluida);

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
