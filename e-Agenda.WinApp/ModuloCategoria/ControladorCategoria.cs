using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloDespesa;


namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private IRepositorioCategoria repositorioCategoria;

        private IRepositorioDespesa repositorioDespesa;

        private TabelaCategoriasControl tabelaCategoria = null!;

        public ControladorCategoria(IRepositorioCategoria repositorioCategoria, IRepositorioDespesa repositorioDespesa)
        {
            this.repositorioCategoria = repositorioCategoria;

            this.repositorioDespesa = repositorioDespesa;

            ConfigurarTela();  
        }

        public override void ConfigurarTela()
        {
            TelaPrincipal.Instancia.AlterarTextCadastro("Categorias de Despesas");

            Configuracao ??= new Configuracao("Inserir Categoria", "Editar Categoria", "Excluir Categoria")
            { 
                BtnVisualizarEnabled = true 
            };
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

            var telaForm = new TelaCategoriaForm()
            {
                Categoria = categoriaSelecionada,
                Text = "Editar Categoria"
            };

            DialogResult opcao = telaForm.ShowDialog();

            if (opcao == DialogResult.OK)
            {
                categoriaSelecionada.Editar(telaForm.Categoria);

                bool editou = repositorioCategoria.Editar(categoriaSelecionada);

                if (!editou)
                    MessageBox.Show($"Categoria {categoriaSelecionada.Nome} Já cadastrada", "Categoria já cadastrada", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

            bool vinculado = repositorioDespesa.ListarDespesasPorCategorias(categoriaSelecionada).Any();

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
            var telaForm = new TelaCategoriaForm();

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

            Categoria categoria = repositorioCategoria.BuscarPorId(id);

            List<Despesa> despesasPorCategoria = repositorioDespesa.ListarDespesasPorCategorias(categoria); 

            if (despesasPorCategoria.Count == 0)
            {
                MessageBox.Show("Nenhuma despesa para a categoria selecionada!");
                return;
            }

            var tela = new TelaVisualizarPorCategoria(despesasPorCategoria);

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
