namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        private Tarefa? tarefa;

        public Tarefa Tarefa
        {
            get => tarefa!;
            set
            {
                textDescricao.Text = value.Titulo.ToString();
                textPrioridade.Text = value.Prioridade.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = textDescricao.Text;

            string prioridadeStr = textPrioridade.Text;

            Prioridade prioridade = Prioridade.Normal;

            switch (prioridadeStr)
            {
                case "Alta": prioridade = Prioridade.Alta; break;
                case "Baixa": prioridade = Prioridade.Baixa; break;
                case "Normal": prioridade = Prioridade.Normal; break;
            }

            tarefa = new Tarefa(prioridade, descricao);

            string[]erros = tarefa.Validar();

            if(erros.Length > 0)
            {
                TelaPrincipal.Instancia.AlterarTextRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
