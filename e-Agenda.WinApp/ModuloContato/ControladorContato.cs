using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloContato;

public class ControladorContato : ControladorBase
{
    private IRepositorioContato repositorioContato;

    private TabelaContatoControl? gridContato;

    public ControladorContato(IRepositorioContato repositorioContato)
    {
        this.repositorioContato = repositorioContato;
        ConfigurarTela();
    }

    public override void Inserir()
    {
        TelaContatoForm contatoForm = new TelaContatoForm();

        DialogResult opcao = contatoForm.ShowDialog();

        if (opcao == DialogResult.OK)
        {
            Contato contato = contatoForm.Contato!;

            repositorioContato.Cadastrar(contato);

            AtualizarContatos();

        }
    }
    public override void Editar()
    {
        int id = gridContato!.ObterIdContatoSelecionado();

        Contato contatoSelecionado = repositorioContato.BuscarPorId(id);

        if (contatoSelecionado == null)
            return;

        DialogResult opcao = ConfirmarAcao($"Confirma editar o contato {contatoSelecionado.Id} - {contatoSelecionado.Nome} ?", "Editar Contato");

        if (opcao == DialogResult.Yes)
        {
            var contatoForm = new TelaContatoForm
            {
                Text = "Editar Contato",

                Contato = contatoSelecionado
            };

            DialogResult opcaoSalvar = contatoForm.ShowDialog();

            if (opcaoSalvar == DialogResult.OK)
            {
                contatoSelecionado.Editar(contatoForm.Contato);

                repositorioContato.Editar(contatoSelecionado);

                AtualizarContatos();
            }
        }
    }

    public override void Excluir()
    {
        int id = gridContato!.ObterIdContatoSelecionado();

        Contato contatoSelecionado = repositorioContato!.BuscarPorId(id);

        if (contatoSelecionado == null)
            return;

        DialogResult opcao = ConfirmarAcao($"Confirma excluir o contato {contatoSelecionado.Id} - {contatoSelecionado.Nome} ?", "Excluir Contato");

        if (opcao == DialogResult.Yes)
        {
            repositorioContato!.Excluir(contatoSelecionado);

            AtualizarContatos();
        }
    }

    public override UserControl ObterListagem()
    {
        gridContato ??= new TabelaContatoControl();

        AtualizarContatos();

        return gridContato;
    }

    private void AtualizarContatos()
    {
        List<Contato> contatos = repositorioContato!.Listar();

        gridContato!.AtualizarLista(contatos);
        TelaPrincipal.Instancia.AlterarTextRodape(contatos.Any()? $"Exibindo {contatos.Count} contatos(s)." : "Nenhum contato cadastrado!");
    }
    public override void ConfigurarTela()
    {
        TelaPrincipal.Instancia.AlterarTextCadastro("Cadastro Contatos");

        Configuracao ??= new Configuracao(

        "Inserir Contato",
        "Editar Contato",
        "Excluir Contato");
    }
}
