
namespace e_Agenda.WinApp.ModuloDespesa
{
    public partial class TabelaDespesasControl : UserControl
    {
        public TabelaDespesasControl()
        {
            InitializeComponent();
            ConstruirColunas();

            gridDespesas.ConfigurarGridSomenteLeitura();
            gridDespesas.ConfigurarGridZebrado();
        }

        private void ConstruirColunas()
        {
            var columns = new DataGridViewColumn[]
                {
                    new DataGridViewTextBoxColumn()
                    { Name = "id", HeaderText = "Número"},

                    new DataGridViewTextBoxColumn()
                    { Name = "descricao", HeaderText = "Descrição" },

                    new DataGridViewTextBoxColumn()
                    { Name = "valor", HeaderText = "Valor" },

                    new DataGridViewTextBoxColumn()
                    { Name = "formaPagamento", HeaderText = "Forma de Pgto"},

                    new DataGridViewTextBoxColumn()
                    { Name = "categorias", HeaderText = "Categorias"},

                };

            gridDespesas.Columns.AddRange(columns);

        }

        public void AtualizarColunas(List<Despesa> despesas)
        {
            gridDespesas.Rows.Clear();

            despesas.ForEach(d => gridDespesas.Rows.Add(d.Id,d.Descricao,$"R$ {d.Valor}",d.FormaDePagamento,string.Join(", ", d.Categorias)));
        }

        public int ObterIdSelecionado()
        {
            try
            {
                return Convert.ToInt32(gridDespesas.SelectedRows[0].Cells[0].Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                return -1;
            }
        }

    }
}
