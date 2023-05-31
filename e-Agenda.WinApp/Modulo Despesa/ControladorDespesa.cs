using e_Agenda.WinApp.ModuloCategoria;

namespace e_Agenda.WinApp.Modulo_Despesa
{
    public class ControladorDespesa : ControladorBase
    {
        private IRepositorioDespesa RepositorioDespesa { get; }
        private IRepositorioCategoria RepositorioCategoria { get; }

        private TabelaDespesasControl TabelaDespesas { get; set; } = null!;

        public ControladorDespesa(IRepositorioDespesa repositorioDespesa,IRepositorioCategoria repositorioCategoria)
        {
            RepositorioDespesa = repositorioDespesa;
            RepositorioCategoria = repositorioCategoria;
            ConfigurarTela();
        }

        
        public override void ConfigurarTela()
        {
            TelaPrincipal.Instancia.AlterarTextCadastro("Controle De Despesas");

            Configuracao ??= new Configuracao("Inserir Despesa", "Editar Despesa", "Excluir Despesa");

        }

        public override void Editar()
        {
            var telaDespesa = new TelaDespesaForm(RepositorioCategoria.Listar());

            int id = TabelaDespesas.ObterIdSelecionado();

            Despesa despesaSelecionada = RepositorioDespesa.BuscarPorId(id);

            if(despesaSelecionada == null)
            {
                MessageBox.Show("Nenhuma despesa selecionada", "Despesa não Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            telaDespesa.Despesa = despesaSelecionada;

            DialogResult opcao = telaDespesa.ShowDialog();
            {
                if(opcao == DialogResult.OK)
                {
                    despesaSelecionada.Editar(telaDespesa.Despesa);

                    RepositorioDespesa.Editar(despesaSelecionada);

                    AtualizarDespesas();
                }
            }
        }

        public override void Excluir()
        {
            int id = TabelaDespesas.ObterIdSelecionado();

            Despesa despesaSelecionada = RepositorioDespesa.BuscarPorId(id);

            if (despesaSelecionada == null)
            {
                MessageBox.Show("Nenhuma despesa selecionada", "Despesa não Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult confirmacao = MessageBox.Show($"Confirma excluír a despesa {despesaSelecionada.Descricao} ?", "Excluir Despesa", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if(confirmacao == DialogResult.OK)
            {
                RepositorioDespesa.Excluir(despesaSelecionada);

                AtualizarDespesas();
            }
        }

        public override void Inserir()
        {
            var telaDespesa = new TelaDespesaForm(RepositorioCategoria.Listar());

            DialogResult opcao = telaDespesa.ShowDialog();

            if(opcao == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.Despesa;

                RepositorioDespesa.Cadastrar(despesa);

                AtualizarDespesas();
            }
        }

        public override UserControl ObterListagem()
        {
            TabelaDespesas ??= new TabelaDespesasControl();

            AtualizarDespesas();

            return TabelaDespesas;
        }

        private void AtualizarDespesas()
        {
            List<Despesa> despesas = RepositorioDespesa.Listar();

            TabelaDespesas.AtualizarColunas(despesas);

            TelaPrincipal.Instancia.AlterarTextRodape(despesas.Any() ? $"Exibindo {despesas.Count} despesa(s)" : "Nenhuma despesa cadastrada até o momento!");
        }
    }
}
