
namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaItemTarefaForm : Form
    {
        private readonly List<ItemTarefa> itens;

        public TelaItemTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();

            itens = new List<ItemTarefa>();

            CriarColunas();

            tabelaItens.ConfigurarGridSomenteLeitura();
            tabelaItens.ConfigurarGridZebrado();
            ConfigurarPanelTarefa();

            CarregarListaItens(tarefa);
        }


        private void CarregarListaItens(Tarefa tarefa)
        {
            textNumero.Text = tarefa.Id.ToString();
            textTitulo.Text = tarefa.Titulo.ToString();
            textPrioridade.Text = tarefa.Prioridade.ToString();
            textProgresso.Text = $"{tarefa.PorcentagemConcluida}%";

            tabelaItens.Rows.Clear();

            List<ItemTarefa> itens = tarefa.Itens;

            itens.ForEach(i => tabelaItens.Rows.Add(i.Descricao, i.Concluido ? "Concluído" : "Pendente"));
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

            var novoItem = new ItemTarefa(descricao);

            IncluirNovaLinha(novoItem);

            itens.Add(novoItem);

            textDescricao.Text = "";
        }

        private void CriarColunas()
        {
            var columns = new DataGridViewColumn[]
                {
                    new DataGridViewTextBoxColumn()
                    {Name = "descricao",HeaderText="Descrição" },

                    new DataGridViewTextBoxColumn()
                    {Name = "status", HeaderText="Status" }
                };

            tabelaItens.Columns.AddRange(columns);

        }

        private void ConfigurarPanelTarefa()
        {
            foreach (var item in panelTarefa.Controls)
            {
                if (item is TextBox text)
                {
                    text.ReadOnly = true;
                }
            }
        }

        private void IncluirNovaLinha(ItemTarefa novoItem)
        {
            tabelaItens.Rows.Add(novoItem.Descricao, novoItem.Concluido ? "Concluído" : "Pendente");
        }

        public List<ItemTarefa> ObterItens()
        {
            return itens;
        }

    }
}
