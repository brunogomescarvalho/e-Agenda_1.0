using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private readonly List<Contato> contatos;

        private Compromisso? compromisso;

        public Compromisso Compromisso
        {
            get => compromisso!;

            set
            {
                textId.Text = value.Id.ToString();
                textBoxAssunto.Text = value.Assunto;
                textBoxLocal.Text = value.Local;
                textData.Text = value.Data.ToShortDateString();
                textHoraInicial.Text = value.HoraInicio.ToShortTimeString();
                textHorarioFinal.Text = value.HoraTermino.ToShortTimeString();
            }
        }

        public TelaCompromissoForm(List<Contato> contatos)
        {
            this.contatos = contatos;

            InitializeComponent();
        }

        private void TelaCompromissoForm_Load(object sender, EventArgs e)
        {
            contatos.ForEach(contato => { comboBoxContatos.Items.Add(contato); });
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            string id = textId.Text;

            Contato contato = comboBoxContatos.SelectedItem == null ? null! : (Contato)comboBoxContatos.SelectedItem;

            string assunto = textBoxAssunto.Text;

            string local = textBoxLocal.Text;

            DateTime data = Convert.ToDateTime(textData.Text.ToString().Trim());

            DateTime horarioInicial = default;

            if (TimeSpan.TryParse(textHoraInicial.Text.ToString(), out TimeSpan horaInicial))
                horarioInicial = DateTime.MinValue.Date + horaInicial;

            DateTime horarioFinal = default;

            if (TimeSpan.TryParse(textHorarioFinal.Text.ToString(), out TimeSpan horaFinal))
                horarioFinal = DateTime.MinValue.Date + horaFinal;

            compromisso = new Compromisso(contato, assunto, local, data, horarioInicial, horarioFinal);

            int idCompromisso = id == "" ? 0 : Convert.ToInt32(id);

            if (idCompromisso > 0)
                compromisso.AtribuirId(idCompromisso);

        }

        private void checkIncluirContato_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chekc = (CheckBox)sender;

            if (chekc.Checked)
                comboBoxContatos.Enabled = true;
            else
                comboBoxContatos.Enabled = false;
        }
    }
}
