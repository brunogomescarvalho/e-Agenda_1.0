
using static e_Agenda.WinApp.ModuloCompromisso.ControladorCompromisso;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroCompromisso : Form
    {

        string opcao = "";

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
                opcao = radioBtn.Text;
            }

        }

        public StatusCompromisso Getstatus()
        {
            if (opcao == "Hoje")
                return StatusCompromisso.Hoje;
            else if (opcao == "Passados")
                return StatusCompromisso.Passado;
            else if (opcao == "Próximos")
                return StatusCompromisso.Futuro;
            else
                return StatusCompromisso.Todos;

        }
    }
}
