
using e_Agenda.WinApp.Modulo_Despesa;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private RepositorioCategoria repositorioCategoria;

        private RepositorioDespesa repositorioDespesa;

        private TabelaCategoriasControl tabelaCategoria = null!;

        public ControladorCategoria(RepositorioCategoria repositorioCategoria, RepositorioDespesa repositorioDespesa)
        {
            this.repositorioCategoria = repositorioCategoria;

            this.repositorioDespesa = repositorioDespesa;

            ConfigurarTela();
           
        }

        public override void ConfigurarTela()
        {
            TelaPrincipal.Instancia.AlterarTextCadastro("Categorias de Despesas");

            Configuracao = new Configuracao("Inserir Categoria", "Editar Categoria", "Excluir Categoria")
            { BtnVisualizarEnabled = true };
        }

        public override void Editar()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            Categoria categoriaSelecionada = repositorioCategoria.BuscarPorId(id);

            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Selecione uma categoria!");
                return;
            }

            TelaCategoriaForm telaForm = new TelaCategoriaForm();

            telaForm.Categoria = categoriaSelecionada;

            DialogResult opcao = telaForm.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                Categoria categoria = telaForm.Categoria;

                bool editou = repositorioCategoria.Editar(categoria);

                if (!editou)
                    MessageBox.Show($"Categoria {categoria.Nome} Já cadastrada", "Categoria já cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                AtualizarCategorias();
            }



        }

        public override void Excluir()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            Categoria categoriaSelecionada = repositorioCategoria.BuscarPorId(id);

            if (categoriaSelecionada == null)
            {
                MessageBox.Show("Selecione uma categoria!");
                return;
            }

            bool vinculado = repositorioDespesa.ListarDespesasPorCategorias(id).Any();

            if(vinculado)
            {
                MessageBox.Show("Não é possível excluir a categoria selecionada,\npois ela está vinculada a despesas cadastradas!","Categoria já Vinculada", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            else
            {
                var opcao = ConfirmarAcao($"Confirma excluír a categoria {categoriaSelecionada.Nome} ?", "Confirmar Excluisão");
                if(opcao == DialogResult.Yes)
                {
                    repositorioCategoria.Excluir(id);
                    AtualizarCategorias();
                }
            }

          
        }

        public override void Inserir()
        {
            TelaCategoriaForm telaForm = new TelaCategoriaForm();

            DialogResult opcao = telaForm.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                Categoria categoria = telaForm.Categoria;

                bool cadastrou = repositorioCategoria.Cadastrar(categoria);

                if (!cadastrou)
                    MessageBox.Show($"Categoria {categoria.Nome} Já cadastrada", "Categoria já cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

                AtualizarCategorias();
            }
        }


        public void VisualizarDespesasPorCategoria()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            if (id == -1)
            {
                MessageBox.Show("Selecione uma categoria!");
                return;
            }

            List<Despesa> despesasPorCategoria = repositorioDespesa.ListarDespesasPorCategorias(id);

            if (despesasPorCategoria.Count == 0)
            {
                MessageBox.Show("Nenhuma despesa para a categoria selecionada!");
                return;
            }

            TelaVisualizarPorCategoria tela = new TelaVisualizarPorCategoria(despesasPorCategoria);

            tela.ShowDialog();

        }

        public override UserControl ObterListagem()
        {
            tabelaCategoria ??= new TabelaCategoriasControl();

            AtualizarCategorias();

            return tabelaCategoria;
        }

        public void AtualizarCategorias()
        {
            List<Categoria> categorias = repositorioCategoria.Listar();

            tabelaCategoria.AtualizarCategorias(categorias);

            TelaPrincipal.Instancia.AlterarTextRodape(categorias.Any() ? $"Exibindo {categorias.Count} categoria(s)." : "Nenhuma categoria cadastrada até o momento!");
        }
    }
}
