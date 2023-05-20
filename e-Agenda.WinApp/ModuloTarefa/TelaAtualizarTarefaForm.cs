
namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaAtualizarTarefaForm : Form
    {

        public List<Item> itensFinalizado;

        public TelaAtualizarTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            itensFinalizado = new List<Item>();

            textTarefa.Text = tarefa.ToString();

            listItens.Items.Clear();

            tarefa.BuscarItensNaoConcluidos().ForEach(i => { listItens.Items.Add(i); });
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            foreach (var item in listItens.CheckedItems)
            {
                Item itemConvertido = (Item)item;

                itensFinalizado.Add(itemConvertido);
            }
        }
    }
}
