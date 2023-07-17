using e_agenda.Aplicacao.ModuloCategoria;
using e_agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Dominio.ModuloDespesa;
using e_Agenda.Dominio.ModuloTarefa;
using e_Agenda.InfraDados.ModuloCategoria;
using e_Agenda.InfraDados.ModuloCompartilhado;
using e_Agenda.InfraDados.ModuloCompromisso;
using e_Agenda.InfraDados.ModuloContato;
using e_Agenda.InfraDados.ModuloDespesa;
using e_Agenda.InfraDados.ModuloTarefa;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesa;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public static class IoC
    {
        static Dictionary<string, ControladorBase> controladores = new();

        static IoC()
        {
            ContextoDados contexto = new(carregarDados: true);

            IRepositorioContato repositorioContato = new RepositorioContatoArquivo(contexto);

            IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoArquivo(contexto);

            IRepositorioTarefa repositorioTarefa = new RepositorioTarefaArquivo(contexto);

            IRepositorioDespesa repositorioDespesa = new RepositorioDespesaArquivo(contexto);

            IRepositorioCategoria repositorioCategoria = new RepositorioCategoriaArquivo(contexto);

            ServicoCategoria servicoCategoria = new ServicoCategoria(repositorioCategoria, new ValidadorCategoria());

            var controladorContato = new ControladorContato(repositorioContato);

            var controladorCompromisso= new ControladorCompromisso(repositorioCompromisso, repositorioContato);

            var controladorTarefa = new ControladorTarefa(repositorioTarefa);

            var controladorCategoria = new ControladorCategoria(repositorioCategoria, repositorioDespesa, servicoCategoria);

            var controladorDespesa = new ControladorDespesa(repositorioDespesa, repositorioCategoria);



            controladores.Add("Contatos", controladorContato);
            controladores.Add("Compromissos", controladorCompromisso);
            controladores.Add("Tarefas", controladorTarefa);
            controladores.Add("Despesas", controladorDespesa);
            controladores.Add("Categorias", controladorCategoria);
        }

        public static ControladorBase ObterControlador(object sender)
        {
            ToolStripItem btn = (ToolStripItem)sender;

            return controladores[btn.Text];
        }
    }
}
