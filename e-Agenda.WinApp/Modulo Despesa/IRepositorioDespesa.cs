using e_Agenda.WinApp.ModuloCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Modulo_Despesa
{
    public interface IRepositorioDespesa : IRepositorioBase<Despesa>
    {
        List<Despesa> ListarDespesasPorCategorias(Categoria Categoria);
    }
}
