
using e_Agenda.Dominio.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TabelaCategoriasControl : UserControl
    {
        public TabelaCategoriasControl()
        {
            InitializeComponent();

            CriarColunas();

            gridCategorias.ConfigurarGridSomenteLeitura();
            gridCategorias.ConfigurarGridZebrado();
        }


        private void CriarColunas()
        {
            DataGridViewColumn[] columns = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {Name = "id", HeaderText = "Número" },

                new DataGridViewTextBoxColumn()
                {Name="categoria", HeaderText = "Categoria" }
            };

            gridCategorias.Columns.AddRange(columns);
        }

        public void AtualizarCategorias(List<Categoria> categorias)
        {
            gridCategorias.Rows.Clear();

            categorias.ForEach(c => gridCategorias.Rows.Add(c.Id, c.Nome));
        }

        public int ObterIdSelecionado()
        {
            try
            {
                return Convert.ToInt32(gridCategorias.SelectedRows[0].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                return -1;
            }

        }
    }
}
