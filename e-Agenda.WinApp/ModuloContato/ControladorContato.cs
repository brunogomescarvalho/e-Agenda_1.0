using e_Agenda.WinApp.ModuloCompartilhado;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase<RepositorioContato,Contato>
    {
      
        private ListagemContatosControl? listagemContatosControl;

        public ControladorContato(RepositorioContato repositorioContato)
        {
            RepositorioBase = repositorioContato;
            ConfigurarTela();
        }

        public override void Editar()
        {
            int id = listagemContatosControl!.ObterIdContatoSelecionado();

            Contato contatoSelecionado = RepositorioBase!.BuscarPorId(id);

            if (contatoSelecionado == null)
                return;

            string question = $"Confirma editar o contato {contatoSelecionado.Id} - {contatoSelecionado.Nome} ?";
            string titulo = "Editar Contato";

            DialogResult opcao = MessageBox.Show(question, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

                    RepositorioBase!.Editar(contatoSelecionado);

                    AtualizarContatos();
                }
            }
        }

        public override void Excluir()
        {
            int id = listagemContatosControl!.ObterIdContatoSelecionado();

            Contato contatoSelecionado = RepositorioBase!.BuscarPorId(id);

            if (contatoSelecionado == null)
                return;

            string question = $"Confirma excluir o contato {contatoSelecionado.Id} - {contatoSelecionado.Nome} ?";
            string titulo = "Excluir Contato";

            DialogResult opcao = MessageBox.Show(question, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcao == DialogResult.Yes)
            {
                RepositorioBase!.Excluir(contatoSelecionado);

                AtualizarContatos();
            }
        }

        public override void Inserir()
        {
           TelaContatoForm contatoForm = new TelaContatoForm();

           DialogResult opcao = contatoForm.ShowDialog();

            if( opcao == DialogResult.OK )
            {
                Contato contato = contatoForm.Contato!;

                RepositorioBase!.Cadastrar(contato);

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
            List<Contato> contatos = RepositorioBase!.Listar();

            listagemContatosControl!.AtualizarLista(contatos);
        }

        public override void ConfigurarTela()
        {
            Configuracao = new Configuracao(
            "Contato",
            "Inserir Contato",
            "Editar Contato",
            "Excluir Contato");
        }
    }
}
