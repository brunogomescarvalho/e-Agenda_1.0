using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public abstract class EntidadeBase<TEntidade>
    {
        public int Id { get; private set; }

        public void AtribuirId(int id)
        {
            this.Id = id;
        }

        public abstract void Editar(TEntidade entidade);
    }
}
