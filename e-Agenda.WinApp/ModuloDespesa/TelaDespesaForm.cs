using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesa
{
    public partial class TelaDespesaForm : Form
    {

        private Despesa despesa = null!;

        public Despesa Despesa
        {
            get => despesa;

            set
            {
                textId.Text = value.Id.ToString();
                textDescricao.Text = value.Descricao;
                textValor.Value = value.Valor;
                textData.Value = value.Data;

                for (int i = 0; i < listCategorias.Items.Count; i++)
                {
                    for (int j = 0; j < value.Categorias.Count; j++)
                    {
                        if (listCategorias.Items[i].Equals(value.Categorias[j]))
                        {
                            listCategorias.SetItemChecked(i, true);
                        }
                    }
                }

                foreach (var item in comboFormaPgto.Items)
                {
                    if (value.FormaDePagamento.ToString() == item.ToString())
                    {
                        comboFormaPgto.SelectedItem = item;
                    }
                }
            }
        }

        public TelaDespesaForm(List<Categoria> categorias)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            CarregarComboFormaPgto();

            CarregarListaCategorias(categorias);
        }


        private void CarregarComboFormaPgto()
        {
            var formasDePgto = Enum.GetValues<FormaDePagamento>().ToList();

            formasDePgto.ForEach(i =>
            {
                if (i != FormaDePagamento.Nenhum)
                    comboFormaPgto.Items.Add(i);
            });
        }

        private void CarregarListaCategorias(List<Categoria> categorias)
        {
            listCategorias.Items.Clear();

            categorias.ForEach(i => listCategorias.Items.Add(i));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string idStr = textId.Text;
            string descricao = textDescricao.Text;
            decimal valor = Convert.ToDecimal(textValor.Text);
            DateTime data = Convert.ToDateTime(textData.Text);

            _ = Enum.TryParse(Convert.ToString(comboFormaPgto.SelectedItem)!.ToCharArray(), out FormaDePagamento formaPgto);

            List<Categoria> categorias = listCategorias.CheckedItems.Cast<Categoria>().ToList();

            despesa = new Despesa(descricao, valor, data, formaPgto, categorias);

            int id = idStr == "" ? 0 : Convert.ToInt32(idStr);

            despesa.AtribuirId(id);

            var erros = despesa.Validar();

            if (erros.Any())
            {
                DialogResult = DialogResult.None;
                TelaPrincipal.Instancia.AlterarTextRodape(erros[0]);
            }
        }
    }
}
