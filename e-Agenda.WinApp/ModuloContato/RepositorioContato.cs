using e_Agenda.WinApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase<Contato>
    {
        public RepositorioContato(List<Contato> registros) : base(registros)
        {
            Contato contato1 = new Contato("fulano", "fulano@gmail.com", "3222-2340", "Ab Tec", "Dev");
            Contato contato2 = new Contato("ciclano", "cilcano@gtech.com", "9998-1234", "gtech", "Gerente");

            contato1.AtribuirId(12);
            contato2.AtribuirId(13);

            this.registros.AddRange(new Contato[]
            {
              contato1,contato2
            }) ;
        }
    }
}
