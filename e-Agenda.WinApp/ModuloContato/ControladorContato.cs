namespace e_Agenda.WinApp.ModuloContato;

public class ControladorContato : ControladorBase
{
    private RepositorioContato repositorioContato;
    private ListagemContatosControl? listagemContatosControl;

    public ControladorContato(RepositorioContato repositorioContato)
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
        int id = listagemContatosControl!.ObterIdContatoSelecionado();

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
                contatoSelecionado = contatoForm.Contato;

                repositorioContato.Editar(contatoSelecionado);

                AtualizarContatos();
            }
        }
    }

    public override void Excluir()
    {
        int id = listagemContatosControl!.ObterIdContatoSelecionado();

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
        listagemContatosControl ??= new ListagemContatosControl();

        AtualizarContatos();

        return listagemContatosControl;
    }

    private void AtualizarContatos()
    {
        List<Contato> contatos = repositorioContato!.Listar();

        listagemContatosControl!.AtualizarLista(contatos);

        TelaPrincipal.Instancia.AlterarTextRodape($"Exibindo {contatos.Count} contatos.");
    }

    public override void ConfigurarTela()
    {
        Configuracao = new Configuracao(

        "Inserir Contato",
        "Editar Contato",
        "Excluir Contato");
    }
}
