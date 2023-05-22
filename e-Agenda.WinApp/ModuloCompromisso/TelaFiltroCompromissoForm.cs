
using static e_Agenda.WinApp.ModuloCompromisso.ControladorCompromisso;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromisso : Form
    {

        string opcao = "";

        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public TelaFiltroCompromisso()
        {
            InitializeComponent();

            IniciarRadioButtons();
        }

        private void IniciarRadioButtons()
        {
            foreach (var item in tableLayoutPanel1.Controls)
            {
                if (item is RadioButton radioBtn)
                {
                    radioBtn.CheckedChanged += RadioBtn_CheckedChanged;
                }

            }
        }

        private void RadioBtn_CheckedChanged(object? sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender!;

            if (radioBtn.Checked)
            {
                opcao = radioBtn.Tag.ToString()!;
            }

        }

        public FiltroCompromisso Getstatus()
        {
            if (opcao == "Hoje")
                return FiltroCompromisso.Hoje;

            else if (opcao == "Passados")
                return FiltroCompromisso.Passado;

            else if (opcao == "Próximos")
                return FiltroCompromisso.Futuro;

            else if (opcao == "Datas")
            {
                DataInicial = dateTimeInicial.Value;
                DataFinal = dateTimeFinal.Value;

                return FiltroCompromisso.Data;
            }

            else
                return FiltroCompromisso.Todos;
        }

    }
}
