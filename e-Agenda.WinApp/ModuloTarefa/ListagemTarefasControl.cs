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
            listTarefasControl.Items.Clear();

            tarefas.ForEach(i => listTarefasControl.Items.Add(i));

        }

        public Tarefa ObterContatoSelecionado()
        {
            return (Tarefa)listTarefasControl.SelectedItem;
        }
    }
}
