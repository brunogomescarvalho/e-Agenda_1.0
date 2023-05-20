
namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaItemForm : Form
    {

        public TelaItemForm(Tarefa tarefa)
        {
            InitializeComponent();

            textTarefa.Text = tarefa.ToString();

            listItens.Items.Clear();

            tarefa.Itens.ForEach(i => listItens.Items.Add(i));
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string descricao = textDescricao.Text;

            var novoItem = new Item(descricao);

            listItens.Items.Add(novoItem);

            textDescricao.Text = "";
        }

        public List<Item> ObterItens()
        {
            List<Item> itens = new List<Item>();

            foreach (var item in listItens.Items)
            {
                Item itemDaTarefa = (Item)item;

                itens.Add(itemDaTarefa);
            }

            return itens;
        }

    }
}
