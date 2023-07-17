using e_agenda.Aplicacao.ModuloCategoria;
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloDespesa;
using FluentResults;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private readonly IRepositorioCategoria repositorioCategoria;

        private readonly IRepositorioDespesa repositorioDespesa;

        private TabelaCategoriasControl tabelaCategoria = null!;

        ServicoCategoria servicoCategoria;

        public ControladorCategoria(IRepositorioCategoria repositorioCategoria, IRepositorioDespesa repositorioDespesa, ServicoCategoria servicoCategoria)
        {
            this.repositorioCategoria = repositorioCategoria;

            this.repositorioDespesa = repositorioDespesa;

            this.servicoCategoria = servicoCategoria;

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

            telaForm.onGravarRegistro += servicoCategoria.Editar;

            DialogResult opcao = telaForm.ShowDialog();

            if (opcao == DialogResult.OK)
            {                        
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
            }
            else
            {
                var opcao = ConfirmarAcao($"Confirma excluír a categoria {categoriaSelecionada.Nome} ?", "Confirmar Excluisão");
                if(opcao == DialogResult.Yes)
                {
                   Result result = servicoCategoria.Excluir(categoriaSelecionada);

                    if(result.IsFailed)
                    {
                        TelaPrincipal.Instancia.AlterarTextRodape(result.Errors[0].Message);
                    }
                    else
                    {
                        AtualizarCategorias();
                    }
                   
                }
            }
        }

        public override void Inserir()
        {
            var telaForm = new TelaCategoriaForm();

            telaForm.onGravarRegistro += servicoCategoria.Cadastrar;

            DialogResult opcao = telaForm.ShowDialog();

            if (opcao == DialogResult.OK)
            {
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
