using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public interface IControler
    {
        string ToolTipInserir { get; }

        string ToolTipEditar { get; }

        string ToolTipExcluir { get; }

        void Inserir();

        void Editar();

        void Excluir();

        UserControl ObterListagem();

        string ObterTipoCadastro();
        
    }
}
