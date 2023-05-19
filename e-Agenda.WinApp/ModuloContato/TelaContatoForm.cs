using System.Text.RegularExpressions;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato? contato;

        private bool telefoneValido;

        private bool emailValido;

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
            AdicionarEventoTextBox();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string id = textId.Text;

            string nome = textNome.Text;

            string telefone = textTelefone.Text;

            string email = textEmail.Text;

            string cargo = textCargo.Text;

            string empresa = textEmpresa.Text;

            contato = new Contato(nome,email,telefone, cargo, empresa);

            int idContato = id != "" ? Convert.ToInt32(id) : 0;

            if (idContato != 0)
                contato.AtribuirId(idContato);
        }

        private void AdicionarEventoTextBox()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox txtBox)
                {
                    txtBox.Leave += TxtBox_Leave;
                }

            }
        }

        private void TxtBox_Leave(object? sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender!;

            if (txtBox.Text == string.Empty)
                labelStatusContatoForm.Text = MostrarErro(txtBox);

            else if (txtBox.Name == "textTelefone")
            {
                telefoneValido = TelefoneEhValido(txtBox.Text);

                if (!telefoneValido)
                    labelStatusContatoForm.Text = "Telefone fora do padrão";
            }
            else if (txtBox.Name == "textEmail")
            {
                emailValido = EmailEhValido(txtBox.Text);

                if (!emailValido)
                    labelStatusContatoForm.Text = "Email fora do padrão";
            }

            CamposEstaoPreenchidos();
        }

        private void CamposEstaoPreenchidos()
        {
            bool preenchido = true;

            foreach (var item in this.Controls)
            {
                if (item is TextBox txtBox && txtBox.Name != "textId")
                {
                    if (txtBox.Text.Trim() == string.Empty || !telefoneValido || !emailValido)
                    {
                        preenchido = false;
                        break;
                    }

                }
            }

            btnSalvar.Enabled = preenchido;
        }

        private string MostrarErro(TextBox txtBox)
        {
            string campo = "";

            if (txtBox.Name == "textNome")
                campo = "Nome";

            else if (txtBox.Name == "textTelefone")
                campo = "Telefone";

            else if (txtBox.Name == "textEmail")
                campo = "Email";

            else if (txtBox.Name == "textEmpresa")
                campo = "Empresa";

            else if (txtBox.Name == "textCargo")
                campo = "Cargo";

            return $"Preencha o campo {campo}.";
        }

        public bool TelefoneEhValido(string telefone)
        {
            string padrao = @"^(?:\([1-9]{2}\)\s?)?(?:9\d{4}-\d{4}|\d{4}-\d{4})$";

            return Regex.IsMatch(telefone, padrao);

        }

        public bool EmailEhValido(string email)
        {
            string padrao = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.(?:com\.br|com)$";

            return Regex.IsMatch(email, padrao);
        }
    }
}
