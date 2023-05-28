
namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaForm : Form
    {

        private Categoria categoria = null!;

        public Categoria Categoria
        {
            get => categoria;
            set
            {
                textId.Text = value.Id.ToString();
                textCategoria.Text = value.Nome;
            }
        }

        public TelaCategoriaForm()
        {
            InitializeComponent();

            this.ConfigurarDialog();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string idStr = textId.Text;
            string nome = textCategoria.Text;

            int id = idStr == string.Empty ? 0 : Convert.ToInt32(idStr);

            categoria = new Categoria(nome);

            if (id > 0)
            {
                categoria.AtribuirId(id);
            }

            var erros = categoria.Validar();

            if (erros.Any())
            {
                TelaPrincipal.Instancia.AlterarTextRodape(erros[0]);
                DialogResult = DialogResult.None; return;
            }
        }
    }
}
