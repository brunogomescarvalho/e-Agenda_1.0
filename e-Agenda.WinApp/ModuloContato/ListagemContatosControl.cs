
namespace e_Agenda.WinApp.ModuloContato
{
    public partial class ListagemContatosControl : UserControl
    {
        public ListagemContatosControl()
        {
            InitializeComponent();
        }

        public void AtualizarLista(List<Contato> contatos)
        {
            listContatos.Rows.Clear();

            if (contatos.Count > 1)
                listContatos.Rows.Add(contatos.Count - 1);

            for (int i = 0; i < contatos.Count; i++)
            {
                listContatos.Rows[i].Cells[0].Value = contatos[i].Id;
                listContatos.Rows[i].Cells[1].Value = contatos[i].Nome;
                listContatos.Rows[i].Cells[2].Value = contatos[i].Telefone;
                listContatos.Rows[i].Cells[3].Value = contatos[i].Email;
                listContatos.Rows[i].Cells[4].Value = contatos[i].Empresa;
                listContatos.Rows[i].Cells[5].Value = contatos[i].Cargo;
            }
        }

        public int ObterIdContatoSelecionado()
        {
            var selectedRow = listContatos.SelectedRows[0];

            return Convert.ToInt16(selectedRow.Cells[0].Value);
              
        }
    }
}
