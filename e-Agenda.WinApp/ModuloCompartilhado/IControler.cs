using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public interface IControler
    {
        Configuracao Configuracao { get; protected set; }
        void Inserir();

        void Editar();

        void Excluir();

        UserControl ObterListagem();

      
    }
}
