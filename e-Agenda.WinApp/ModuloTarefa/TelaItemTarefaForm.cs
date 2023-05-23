
namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaItemTarefaForm : Form
    {
        private readonly List<Item> itens;

        public TelaItemTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            itens = new List<Item>();

            CarregarListaItens(tarefa);
        }



        private void CarregarListaItens(Tarefa tarefa)
        {
            textTarefa.Text = tarefa.ToString();

            listItens.Rows.Clear();

            if (tarefa.Itens.Count > 1)
                listItens.Rows.Add(tarefa.Itens.Count - 1);

            for (int i = 0; i < tarefa.Itens.Count; i++)
            {
                listItens.Rows[i].Cells[0].Value = tarefa.Itens[i].Descricao;
                listItens.Rows[i].Cells[1].Value = tarefa.Itens[i].Concluido ? "Concluído" : "Pendente";
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            string descricao = textDescricao.Text;

            if (descricao.Trim().Length == 0)
            {
                TelaPrincipal.Instancia.AlterarTextRodape("Informe a descrição para o item da tarefa!");
                DialogResult = DialogResult.None;
                return;
            }

            var novoItem = new Item(descricao);

            var novaLinha = new DataGridViewRow();

            novaLinha.CreateCells(listItens);

            novaLinha.Cells[0].Value = novoItem.Descricao;
            novaLinha.Cells[1].Value = novoItem.Concluido ? "Concluído" : "Pendente";

            listItens.Rows.Add(novaLinha);

            itens.Add(novoItem);
        }

        public List<Item> ObterItens()
        {
            return itens;
        }

    }
}
