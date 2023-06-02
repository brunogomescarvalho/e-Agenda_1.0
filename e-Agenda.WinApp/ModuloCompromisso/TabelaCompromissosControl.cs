using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class ListaCompromissosControl : UserControl
    {
        public ListaCompromissosControl()
        {
            InitializeComponent();

            CriarColunas();

            gridCompromissos.ConfigurarGridSomenteLeitura();

            gridCompromissos.ConfigurarGridZebrado();
        }

        public void AtualizarListagem(List<Compromisso> compromissos)
        {
            gridCompromissos.Rows.Clear();

            compromissos.ForEach(c =>
            {
                gridCompromissos.Rows.Add(c.Id, c.Assunto, c.Local, c.Data.ToShortDateString(),
                c.HoraInicio.ToShortTimeString(), c.HoraTermino.ToShortTimeString(),
                c.Contato != null ? c.Contato.Id : "N/D", c.Contato?.Nome);
            });

        }

        private void CriarColunas()
        {
            DataGridViewColumn[] columns = new DataGridViewColumn[]
                {
                    new DataGridViewTextBoxColumn()
                    {Name = "id",HeaderText = "Número"},

                    new DataGridViewTextBoxColumn()
                    {Name = "assunto",HeaderText = "Assunto"},

                    new DataGridViewTextBoxColumn()
                    {Name = "Local",HeaderText = "Local"},

                    new DataGridViewTextBoxColumn()
                    {Name = "data", HeaderText = "Data"},

                    new DataGridViewTextBoxColumn()
                    {Name = "hora_inicio",HeaderText = "Hora Início" },

                    new DataGridViewTextBoxColumn()
                    {Name = "hora_termino", HeaderText = "Hora Término" },

                    new DataGridViewTextBoxColumn()
                    {Name="contato_id",HeaderText = "Id Contato" },

                    new DataGridViewTextBoxColumn()
                    {Name = "contato_nome", HeaderText = "Nome" }
                };

            gridCompromissos.Columns.AddRange(columns);

        }

        public int ObterIdCompromissoSelecionado()
        {
            try
            {
                var selectedRow = gridCompromissos.SelectedRows[0];

                return Convert.ToInt32(selectedRow.Cells[0].Value);
            }

            catch (ArgumentOutOfRangeException)
            {
                return -1;
            }
        }
    }
}
