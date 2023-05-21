namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class ListaCompromissosControl : UserControl
    {
        public ListaCompromissosControl(List<Compromisso> lista)
        {
            InitializeComponent();
        }

        public void AtualizarListagem(List<Compromisso> compromissos)
        {
            listCompromissos.Rows.Clear();

            if (compromissos.Count > 1)
                listCompromissos.Rows.Add(compromissos.Count - 1);

            for (int i = 0; i < compromissos.Count; i++)
            {
                listCompromissos.Rows[i].Cells[0].Value = compromissos[i].Id;
                listCompromissos.Rows[i].Cells[1].Value = compromissos[i].Assunto;
                listCompromissos.Rows[i].Cells[2].Value = compromissos[i].Local;
                listCompromissos.Rows[i].Cells[3].Value = compromissos[i].Data.ToShortDateString();
                listCompromissos.Rows[i].Cells[4].Value = compromissos[i].HoraInicio.ToShortTimeString();
                listCompromissos.Rows[i].Cells[5].Value = compromissos[i].HoraTermino.ToShortTimeString();
                listCompromissos.Rows[i].Cells[6].Value = compromissos[i].Contato == null ? "Sem Contato" : $"{compromissos[i].Contato!.Id} {compromissos[i].Contato!.Nome}";
            }
        }

        public int ObterIdCompromissoSelecionado()
        {
            var selectedRow = listCompromissos.SelectedRows[0];

            return Convert.ToInt32(selectedRow.Cells[0].Value);
        }
    }
}
