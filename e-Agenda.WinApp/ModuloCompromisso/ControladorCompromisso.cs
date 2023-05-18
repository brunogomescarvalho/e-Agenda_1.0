using e_Agenda.WinApp.ModuloCompartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    internal class ControladorCompromisso : ControladorBase<RepositorioCompromisso, Compromisso>
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
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
           TelaCompromissoForm telaCompromissoForm = new TelaCompromissoForm(ObterContatos());

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
            listaCompromissosControl ??= new ListaCompromissosControl();

            AtualizarCompromissos();

            return listaCompromissosControl;
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
    }
}
