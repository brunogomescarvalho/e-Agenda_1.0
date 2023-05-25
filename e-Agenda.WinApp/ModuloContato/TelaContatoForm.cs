
namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato? contato;

        public Contato Contato
        {
            set
            {
                textId.Text = value!.Id.ToString();
                textNome.Text = value!.Nome;
                textTelefone.Text = value!.Telefone;
                textEmpresa.Text = value!.Empresa;
                textEmail.Text = value!.Email;
                textCargo.Text = value!.Cargo;
            }

            get => contato!;
        }

        public TelaContatoForm()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string id = textId.Text;

            string nome = textNome.Text;

            string telefone = textTelefone.Text;

            string email = textEmail.Text;

            string cargo = textCargo.Text;

            string empresa = textEmpresa.Text;

            contato = new Contato(nome, email, telefone, cargo, empresa);

            int idContato = id != "" ? Convert.ToInt32(id) : 0;

            if (idContato != 0)
                contato.AtribuirId(idContato);

            string[] erros = contato.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipal.Instancia.AlterarTextRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
