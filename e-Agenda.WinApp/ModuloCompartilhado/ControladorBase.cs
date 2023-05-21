using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public abstract class ControladorBase<TRepositorio, TEntidade> : IControler where TRepositorio : RepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {

        protected RepositorioBase<TEntidade>? RepositorioBase;

        public Configuracao Configuracao { get; set; } = null!;

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public abstract UserControl ObterListagem();

        public abstract void ConfigurarTela();

        public DialogResult ConfirmarAcao(string question, string titulo)
        {
           return MessageBox.Show(question, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
