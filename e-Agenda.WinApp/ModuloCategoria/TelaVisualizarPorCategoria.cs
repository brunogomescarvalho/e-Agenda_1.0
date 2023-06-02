using e_Agenda.Dominio.ModuloDespesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaVisualizarPorCategoria : Form
    {
        public TelaVisualizarPorCategoria(List<Despesa> lista)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            AtualizarLista(lista);
        }

        private void AtualizarLista(List<Despesa> lista)
        {
            listDespesas.Items.Clear();

            lista.ForEach(item => { listDespesas.Items.Add(item); });

            textCategoria.Text = lista[0].Categorias[0].ToString();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
