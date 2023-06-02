
using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefasControl : UserControl
    {
        public TabelaTarefasControl()
        {
            InitializeComponent();

            CriarColunas();

            gridTarefas.ConfigurarGridSomenteLeitura();

            gridTarefas.ConfigurarGridZebrado();
        }

        public void AtualizarLista(List<Tarefa> tarefas)
        {
            gridTarefas.Rows.Clear();

            tarefas.ForEach(t =>
            {
                gridTarefas.Rows.Add(t.Id, t.Titulo, t.Prioridade, 
                t.DataCriacao.ToShortDateString(),
                t.DataConclusao, t.PorcentagemConcluida + " %");
            });

        }

        private void CriarColunas()
        {
            DataGridViewColumn[] column = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {Name = "Id", HeaderText = "Número"},

                new DataGridViewTextBoxColumn()
                {Name = "Titulo",  HeaderText = "Título"},

                new DataGridViewTextBoxColumn()
                {Name = "Prioridade", HeaderText = "Prioridade"},

                new DataGridViewTextBoxColumn()
                {Name = "Data_Criacao", HeaderText = "Data Criação"},

                new DataGridViewTextBoxColumn()
                {Name = "Data_Conclusao", HeaderText = "Data Conclusão"},

                new DataGridViewTextBoxColumn()
                {Name = "Porcentagem_Concluida", HeaderText = "Progresso",}

            };

            gridTarefas.Columns.AddRange(column);
        }

        public int ObterIdTarefaSelecionada()
        {
            try
            {
                var selectedRow = gridTarefas.SelectedRows[0];

                return Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                return -1;
            }
        }
    }
}
