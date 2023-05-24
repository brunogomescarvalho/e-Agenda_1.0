using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class ControladorCompromisso : ControladorBase<RepositorioCompromisso, Compromisso>
    {

        public readonly RepositorioContato? RepositorioContato;

        public readonly RepositorioCompromisso repositorioCompromisso;

        public ListaCompromissosControl? listaCompromissosControl;

        public ControladorCompromisso(RepositorioCompromisso repositorioCompromisso, RepositorioContato repositorioContato)
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

            if (opcao == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromissoForm.Compromisso;

                bool horarioDisponivel = repositorioCompromisso.VerificarHorario(compromisso);

                if (horarioDisponivel == false)
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
            listaCompromissosControl ??= new ListaCompromissosControl();

            AtualizarCompromissos();

            return listaCompromissosControl;
        }

        public void AbrirFormFiltro()
        {
            var telaFiltro = new TelaFiltroCompromisso();

            DialogResult result = telaFiltro.ShowDialog();

            if (result == DialogResult.OK)
            {
                FiltroCompromisso status = telaFiltro.Getstatus();

                List<Compromisso> listaFiltrada;

                if (status == FiltroCompromisso.Data)
                {
                    DateTime dataInicial = telaFiltro.DataInicial.Date;
                    DateTime dataFinal = telaFiltro.DataFinal.Date;

                    listaFiltrada = repositorioCompromisso.BuscarPorDatas(dataInicial, dataFinal);
                }
                else
                {
                    listaFiltrada = FiltrarLista(status);
                }

                listaCompromissosControl!.AtualizarListagem(listaFiltrada);

                AlterarTextTipoCadastro(status);
            }
        }

        private void AlterarTextTipoCadastro(FiltroCompromisso status)
        {
            string opcao = "";

            switch (status)
            {
                case FiltroCompromisso.Passado:
                    opcao = "Compromissos Passados";
                    break;
                case FiltroCompromisso.Futuro:
                    opcao = "Compromissos Futuros";
                    break;
                case FiltroCompromisso.Hoje:
                    opcao = "Compromissos de Hoje";
                    break;
                case FiltroCompromisso.Todos:
                    opcao = "Compromissos";
                    break;
            }
            TelaPrincipal.Instancia.AlterarTextCadastro(opcao);
        }

        public List<Compromisso> FiltrarLista(FiltroCompromisso status)
        {
            switch (status)
            {
                case FiltroCompromisso.Passado: return repositorioCompromisso.BuscarPassados();

                case FiltroCompromisso.Futuro: return repositorioCompromisso.BuscarProximos();

                case FiltroCompromisso.Hoje: return repositorioCompromisso.BuscarDeHoje();

                default: return repositorioCompromisso.Listar();

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
