namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {

        Prioridade[] prioridades = null!;

        public TelaTarefaForm()
        {
            InitializeComponent();
            CarregarPrioridades();
        }

        private Tarefa? tarefa;

        public Tarefa Tarefa { get => tarefa!; set => ConfigurarTarefa(value); }


        private void CarregarPrioridades()
        {
            prioridades = Enum.GetValues<Prioridade>();

            foreach (var item in prioridades)
            {
                comboBoxPrioridade.Items.Add(item);
            }
        }


        private void ConfigurarTarefa(Tarefa tarefa)
        {
            foreach (Prioridade item in prioridades)
            {
                if (item == tarefa.Prioridade)
                    comboBoxPrioridade.SelectedItem = item;
            }

            textDescricao.Text = tarefa.Titulo.ToString();
            textId.Text = tarefa.Id.ToString();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string descricao = textDescricao.Text;

            Prioridade prioridade = Prioridade.Normal;

            switch (comboBoxPrioridade.SelectedItem)
            {
                case Prioridade.Alta: prioridade = Prioridade.Alta; break;
                case Prioridade.Baixa: prioridade = Prioridade.Baixa; break;
                case Prioridade.Normal: prioridade = Prioridade.Normal; break;
            }

            tarefa = new Tarefa(prioridade, descricao);

            string[] erros = tarefa.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AlterarTextRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

    }
}
