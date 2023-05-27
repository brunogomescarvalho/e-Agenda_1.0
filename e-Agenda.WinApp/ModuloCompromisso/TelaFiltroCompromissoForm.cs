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

            CriarEventoCheck();
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
                FiltroCompromisso = FiltroCompromisso.Datas;
            }
            else FiltroCompromisso = FiltroCompromisso.Todos;
        }


        private void CriarEventoCheck()
        {
            panelDatas.Enabled = false;

            foreach (RadioButton item in panelChecks.Controls)
            {
                item.CheckedChanged += Item_CheckedChanged;
            }
        }

        private void Item_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton item = (RadioButton)sender!;

            if (item.Checked && item.Name == "radioButtonDatas")
            {
                panelDatas.Enabled = true;
            }
            else
            {
                panelDatas.Enabled = false;
            }

        }
    }
}
