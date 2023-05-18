using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase<RepositorioCompromisso, Compromisso>
    {
        public override string ToolTipInserir => "Inserir Compromisso";

        public override string ToolTipEditar => "Editar Compromisso";

        public override string ToolTipExcluir => "Excluir Compromisso";


        public readonly RepositorioContato? RepositorioContato;


        public readonly RepositorioCompromisso repositorioCompromisso;


        public ListaCompromissosControl? listaCompromissosControl;

        public ControladorCompromisso( RepositorioCompromisso repositorioCompromisso,RepositorioContato repositorioContato)
        {
            RepositorioBase = repositorioCompromisso;
            RepositorioContato = repositorioContato;
            this.repositorioCompromisso = repositorioCompromisso;
        }

        public override void Editar()
        {
            Compromisso compromissoSelecionado = listaCompromissosControl!.ObterCompromissoSelecionado();

            if (compromissoSelecionado == null)
                return;

            string question = $"Confirma editar o contato {compromissoSelecionado.Id} - {compromissoSelecionado.Assunto} ?";
            string titulo = "Editar Compromisso";

            DialogResult opcao = MessageBox.Show(question, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (opcao == DialogResult.Yes)
            {
                var compromissoForm = new TelaCompromissoForm(ObterContatos());

                compromissoForm.Text = "Editar Compromisso";

                compromissoForm.Compromisso = compromissoSelecionado;

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
            Compromisso compromissoSelecionado = listaCompromissosControl!.ObterCompromissoSelecionado();

            if (compromissoSelecionado == null)
                return;

            string question = $"Confirma excluir o compromisso {compromissoSelecionado.Id} - {compromissoSelecionado.Assunto} ?";
            string titulo = "Excluir Compromisso";

            DialogResult opcao = MessageBox.Show(question, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        public void AbrirFormFiltro()
        {
            var telaFiltro = new TelaFiltroCompromisso();

            DialogResult result = telaFiltro.ShowDialog();

            if(result == DialogResult.OK)
            {
                StatusCompromisso status = telaFiltro.Getstatus();

                var listaFiltrada = repositorioCompromisso.FiltrarLista(status);

                listaCompromissosControl!.AtualizarListagem(listaFiltrada);
            }
        }

        private void AtualizarCompromissos()
        {
            List<Compromisso> compromissos = RepositorioBase!.Listar();

            listaCompromissosControl!.AtualizarListagem(compromissos);
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromisso";
        }

        public List<Contato> ObterContatos()
        {
            return RepositorioContato!.Listar();
        }

        public enum StatusCompromisso
        {
            Passado,Futuro,Hoje,
            Todos
        }

    }
}
