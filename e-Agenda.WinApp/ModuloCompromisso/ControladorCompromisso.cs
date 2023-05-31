using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso;
public partial class ControladorCompromisso : ControladorBase
{

    public readonly IRepositorioContato repositorioContato;

    public readonly IRepositorioCompromisso repositorioCompromisso;

    public ListaCompromissosControl? listaCompromissosControl;

    public ControladorCompromisso(IRepositorioCompromisso repositorioCompromisso, IRepositorioContato repositorioContato)
    {
        this.repositorioCompromisso = repositorioCompromisso;

        this.repositorioContato = repositorioContato;

        ConfigurarTela();
    }

    public override void Inserir()
    {
        var telaCompromissoForm = new TelaCompromissoForm(ObterContatos());

        DialogResult opcao = telaCompromissoForm.ShowDialog();

        if (opcao == DialogResult.OK)
        {
            Compromisso compromisso = telaCompromissoForm.Compromisso;

            bool horarioDisponivel = repositorioCompromisso.VerificarHorarioDisponivel(compromisso);

            if (horarioDisponivel == false)
            {
                MessageBox.Show("Já existe um compromisso agendado para o horário informado", "Horário Indiponível", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            repositorioCompromisso!.Cadastrar(compromisso);

            AtualizarCompromissos();
        }
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
                compromissoSelecionado.Editar(compromissoForm.Compromisso);

                bool horarioDisponivel = repositorioCompromisso.VerificarHorarioDisponivel(compromissoSelecionado);

                if (horarioDisponivel == false)
                {
                    MessageBox.Show("Já existe um compromisso agendado para o horário informado", "Horário Indiponível", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                repositorioCompromisso!.Editar(compromissoSelecionado);

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
            repositorioCompromisso!.Excluir(compromissoSelecionado);

            AtualizarCompromissos();
        }
    }



    public override UserControl ObterListagem()
    {
        listaCompromissosControl ??= new ListaCompromissosControl();

        AtualizarCompromissos();

        return listaCompromissosControl;
    }

    public override void Filtrar()
    {
        var telaFiltro = new TelaFiltroCompromisso();

        DialogResult result = telaFiltro.ShowDialog();

        if (result == DialogResult.OK)
        {
            FiltroCompromisso status = telaFiltro.FiltroCompromisso;

            List<Compromisso> listaFiltrada;

            if (status == FiltroCompromisso.Datas)
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

            TelaPrincipal.Instancia.AlterarTextCadastro($"Compromissos {status}");

            TelaPrincipal.Instancia.AlterarTextRodape(listaFiltrada.Any() ? $"Exibindo {listaFiltrada.Count} compromissos." : "Nenhum compromisso cadastrado até o momento!");
        }
    }

    public List<Compromisso> FiltrarLista(FiltroCompromisso status)
    {
        switch (status)
        {
            case FiltroCompromisso.Passados: return repositorioCompromisso.BuscarPassados();

            case FiltroCompromisso.Futuros: return repositorioCompromisso.BuscarProximos();

            case FiltroCompromisso.Hoje: return repositorioCompromisso.BuscarDeHoje();

            default: return repositorioCompromisso.Listar();

        }

    }

    private void AtualizarCompromissos()
    {
        List<Compromisso> compromissos = repositorioCompromisso!.Listar();

        listaCompromissosControl!.AtualizarListagem(compromissos);

        TelaPrincipal.Instancia.AlterarTextRodape(compromissos.Any() ? $"Exibindo {compromissos.Count} compromissos(s)" : "Nenhum compromisso até o momento");
    }

    public List<Contato> ObterContatos()
    {
        return repositorioContato!.Listar();
    }

    public override void ConfigurarTela()
    {
        TelaPrincipal.Instancia.AlterarTextCadastro("Cadastro Compromissos");

        Configuracao ??= new Configuracao(

        "Inserir Compromisso",
        "Editar Compromisso",
        "Excluir Compromisso")
        {
            ToolTipoFiltrar = "Filtrar Compromissos",
            BtnFiltrarEnabled = true,

        };

    }

}
