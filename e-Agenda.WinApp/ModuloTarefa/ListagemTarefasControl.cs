using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class ListagemTarefasControl : UserControl
    {
        public ListagemTarefasControl()
        {
            InitializeComponent();
        }

        public void AtualizarLista(List<Tarefa> tarefas)
        {
            listTarefasControl.Rows.Clear();

            if (tarefas.Count > 1)
                listTarefasControl.Rows.Add(tarefas.Count - 1);

            for (int i = 0; i < tarefas.Count; i++)
            {
                listTarefasControl.Rows[i].Cells[0].Value = tarefas[i].Id;
                listTarefasControl.Rows[i].Cells[1].Value = tarefas[i].Titulo;
                listTarefasControl.Rows[i].Cells[2].Value = tarefas[i].Prioridade;
                listTarefasControl.Rows[i].Cells[3].Value = tarefas[i].DataCriacao.ToShortDateString();
                listTarefasControl.Rows[i].Cells[4].Value = tarefas[i].DataConclusao?.ToShortDateString();
                listTarefasControl.Rows[i].Cells[5].Value = tarefas[i].PorcentagemConcluida;
            }

        }

        public int ObterIdTarefaSelecionada()
        {
            try
            {
                var selectedRow = listTarefasControl.SelectedRows[0];

                return Convert.ToInt32(selectedRow.Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                return -1;
            }
        }
    }
}
