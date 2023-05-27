
namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
        {
            InitializeComponent();

            CriarColunas();

            gridContatos.ConfigurarGridZebrado();

            gridContatos.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarLista(List<Contato> contatos)
        {
            gridContatos.Rows.Clear();

            contatos.ForEach(c =>
            {
                gridContatos.Rows.Add(c.Id, c.Nome, c.Telefone, c.Email, c.Empresa, c.Cargo);
            });
        }

        private void CriarColunas()
        {
            DataGridViewColumn[] column = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {Name = "Id", HeaderText = "Número",},

                new DataGridViewTextBoxColumn()
                {Name = "Nome", HeaderText = "Nome",},

                new DataGridViewTextBoxColumn()
                {Name = "Telefone", HeaderText = "Telefone",},

                new DataGridViewTextBoxColumn()
                {Name = "E_mail", HeaderText = "e-Mail",},

                new DataGridViewTextBoxColumn()
                {Name = "Empresa", HeaderText = "Empresa",},

                new DataGridViewTextBoxColumn()
                {Name = "Cargo", HeaderText = "Cargo",}
            };

            gridContatos.Columns.AddRange(column);

        }

        public int ObterIdContatoSelecionado()
        {
            try
            {
                var selectedRow = gridContatos.SelectedRows[0].Cells[0].Value;

                return Convert.ToInt16(selectedRow);
            }
            catch (ArgumentOutOfRangeException)
            {
                return -1;
            }

        }
    }
}
