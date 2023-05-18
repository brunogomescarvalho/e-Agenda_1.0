using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private readonly List<Contato> contatos;

        private Compromisso? compromisso;

        public Compromisso Compromisso
        {
            get => compromisso!;
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

            if (TimeSpan.TryParse(textHoraFinal.Text.ToString(), out TimeSpan horaFinal))
                horarioFinal = DateTime.MinValue.Date + horaFinal;

            compromisso = new Compromisso(contato, assunto, local, data, horarioInicial, horarioFinal);

            int idCompromisso = id == "" ? 0 : Convert.ToInt32(id);

            if (idCompromisso > 0)
                compromisso.AtribuirId(idCompromisso);

        }
    }
}
