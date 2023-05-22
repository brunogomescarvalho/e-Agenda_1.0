
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizarTarefaForm : Form
    {

        private List<Item> itensFinalizado = new List<Item>();

        public TelaAtualizarTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            MostrarTabela(tarefa);

        }

        private void MostrarTabela(Tarefa tarefa)
        {
            textTarefa.Text = tarefa.ToString();

            listItens.Items.Clear();

            tarefa.BuscarItensNaoConcluidos().ForEach(i => listItens.Items.Add(i));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (var item in listItens.CheckedItems)
            {
                Item itemConvertido = (Item)item;

                itensFinalizado.Add(itemConvertido);
            }
        }

        public List<Item> BuscarItensSelecionados()
        {
            return itensFinalizado;
        }
    }
}
