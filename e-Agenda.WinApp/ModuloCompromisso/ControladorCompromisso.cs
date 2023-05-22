using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class ControladorCompromisso : ControladorBase<RepositorioCompromisso, Compromisso>
    {
        
        public readonly RepositorioContato? RepositorioContato;

        public readonly RepositorioCompromisso repositorioCompromisso;

        public ListaCompromissosControl? listaCompromissosControl;

        public ControladorCompromisso( RepositorioCompromisso repositorioCompromisso,RepositorioContato repositorioContato)
        {
            RepositorioBase = repositorioCompromisso;

            RepositorioContato = repositorioContato;

            this.repositorioCompromisso = repositorioCompromisso;

            ConfigurarTela();
        }

        public override void Editar()
        {
            int id = listaCompromissosControl!.ObterIdCompromissoSelecionado();

            Compromisso compromissoSelecionado = repositorioCompromisso.BuscarPorId(id);

            if (compromissoSelecionado == null)
                return;

            DialogResult opcao = ConfirmarAcao($"Confirma editar o contato {compromissoSelecionado.Id} - {compromissoSelecionado.Assunto} ?", "Editar Compromisso");

            if (opcao == DialogResult.Yes)
            {
                var compromissoForm = new TelaCompromissoForm(ObterContatos())
                {
                    Text = "Editar Compromisso",

                    Compromisso = compromissoSelecionado
                };

                DialogResult opcaoSalvar = compromissoForm.ShowDialog();

                if (opcaoSalvar == DialogResult.OK)
                {
                    compromissoSelecionado = compromissoForm.Compromisso;

                    RepositorioBase!.Editar(compromissoSelecionado);

                    AtualizarCompromissos();
                }
            }
        }

        public override void Excluir()
        {
            int id = listaCompromissosControl!.ObterIdCompromissoSelecionado();

            Compromisso compromissoSelecionado = repositorioCompromisso.BuscarPorId(id);

            if (compromissoSelecionado == null)
                return;

            DialogResult opcao = ConfirmarAcao($"Confirma excluir o contato {compromissoSelecionado.Id} - {compromissoSelecionado.Assunto} ?", "Editar Compromisso");

            if (opcao == DialogResult.Yes)
            {
                RepositorioBase!.Excluir(compromissoSelecionado);

                AtualizarCompromissos();
            }
        }

        public override void Inserir()
        {
           var telaCompromissoForm = new TelaCompromissoForm(ObterContatos());

           DialogResult opcao = telaCompromissoForm.ShowDialog();

            if(opcao == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromissoForm.Compromisso;

                bool horarioDisponivel = repositorioCompromisso.VerificarHorario(compromisso);

                if(horarioDisponivel == false)
                {
                    MessageBox.Show("Já existe um compromisso agendado para o horário informado", "Horário Indiponível", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                RepositorioBase!.Cadastrar(compromisso);

                AtualizarCompromissos();
            }
        }

        public override UserControl ObterListagem()
        {
            listaCompromissosControl ??= new ListaCompromissosControl(repositorioCompromisso.Listar());

            AtualizarCompromissos();

            return listaCompromissosControl;
        }

        public void AbrirFormFiltro(ToolStripLabel textTipoCadastro)
        {
            var telaFiltro = new TelaFiltroCompromisso();

            DialogResult result = telaFiltro.ShowDialog();

            if(result == DialogResult.OK)
            {
                StatusCompromisso status = telaFiltro.Getstatus();

                List<Compromisso> listaFiltrada = repositorioCompromisso.FiltrarLista(status);

                listaCompromissosControl!.AtualizarListagem(listaFiltrada);

                AlterarTextTipoCadastro(textTipoCadastro,status);
            }
        }

        private void AlterarTextTipoCadastro(ToolStripLabel textTipoCadastro, StatusCompromisso status)
        {
            switch (status)
            {
                case StatusCompromisso.Passado:
                    textTipoCadastro.Text = "Compromissos Passados";
                    break;
                case StatusCompromisso.Futuro:
                    textTipoCadastro.Text = "Compromissos Futuros";
                    break;
                case StatusCompromisso.Hoje:
                    textTipoCadastro.Text = "Compromissos de Hoje";
                    break;
                case StatusCompromisso.Todos:
                    textTipoCadastro.Text = "Compromissos";
                    break;
            }
        }

        private void AtualizarCompromissos()
        {
            List<Compromisso> compromissos = RepositorioBase!.Listar();

            listaCompromissosControl!.AtualizarListagem(compromissos);
        }

        public List<Contato> ObterContatos()
        {
            return RepositorioContato!.Listar();
        }

        public override void ConfigurarTela()
        {
            Configuracao = new Configuracao(
            "Compromissos",
            "Inserir Compromisso",
            "Editar Compromisso",
            "Excluir Compromisso")
            {
                ToolTipoFiltrar = "Filtrar Compromissos",
                BtnFiltrarEnabled = true
            };

        }

    }
}
