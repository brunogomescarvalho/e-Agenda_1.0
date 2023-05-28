using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class RepositorioCategoria : RepositorioBase<Categoria>
    {
        public RepositorioCategoria(List<Categoria> registros) : base(registros)
        {
        }

        public override bool Cadastrar(Categoria entidade)
        {
            if (VerificarItemJaCadastrado(entidade) == false)
            {
                return false;
            }

            return base.Cadastrar(entidade);
        }

        public override bool Editar(Categoria categoria)
        {
            if (VerificarItemJaCadastrado(categoria) == false)
            {
                return false;
            }

            return base.Editar(categoria);
        }
        public bool VerificarItemJaCadastrado(Categoria entidade)
        {
            if (registros.Any(i => i.Nome.TirarAcentosPalavra().ToLower() == entidade.Nome.TirarAcentosPalavra().ToLower()))
            {
                return false;
            }
            return true;
        }
    }
}
