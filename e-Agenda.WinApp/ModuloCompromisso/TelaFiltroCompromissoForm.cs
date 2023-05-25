namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromisso : Form
    {
        public FiltroCompromisso FiltroCompromisso { get; private set; }
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public TelaFiltroCompromisso()
        {
            InitializeComponent();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            if (radioButtonHoje.Checked)
                FiltroCompromisso = FiltroCompromisso.Hoje;

            else if (radioButtonPassados.Checked)
                FiltroCompromisso = FiltroCompromisso.Passados;

            else if (radioButtonProximos.Checked)
                FiltroCompromisso = FiltroCompromisso.Futuros;

            else if (radioButtonDatas.Checked)
            {
                DataInicial = dateTimeInicial.Value;
                DataFinal = dateTimeFinal.Value;
                FiltroCompromisso = FiltroCompromisso.Data;
            }
            else FiltroCompromisso = FiltroCompromisso.Todos;
        }
    }
}
