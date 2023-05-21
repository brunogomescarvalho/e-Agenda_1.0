
namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizarTarefaForm : Form
    {

        private List<Item> itensFinalizado;

        public TelaAtualizarTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            textTarefa.Text = tarefa.ToString();

            listItens.Items.Clear();

            tarefa.BuscarItensNaoConcluidos().ForEach(i => { listItens.Items.Add(i); });

            itensFinalizado = new List<Item>();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (var item in listItens.CheckedItems)
            {
                Item itemConvertido = (Item)item;

                itensFinalizado.Add(itemConvertido);
            }
        }

        public List<Item>BuscarItensSelecionados()
        {
            return itensFinalizado;
        }
    }
}
