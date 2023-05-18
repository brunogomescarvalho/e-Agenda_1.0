using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public abstract class ControladorBase<TRepositorio,TEntidade> : IControler where TRepositorio : RepositorioBase<TEntidade> where TEntidade:EntidadeBase<TEntidade>
    {

       protected RepositorioBase<TEntidade>? RepositorioBase;

        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();
    }
}
