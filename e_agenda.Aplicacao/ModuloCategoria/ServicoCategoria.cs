using e_agenda.Aplicacao.Compartilhado;
using e_agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCompartilhado;
using e_Agenda.InfraDados.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_agenda.Aplicacao.ModuloCategoria
{
    public class ServicoCategoria : ServicoBase<Categoria>
    {
        IRepositorioCategoria repositorioCategoria;
        ValidadorCategoria validadorCategoria;

        public ServicoCategoria(IRepositorioCategoria repositorioCategoria, ValidadorCategoria validadorCategoria)
        {
            this.validadorCategoria = validadorCategoria;
            this.repositorioCategoria = repositorioCategoria;
            repositorioBase = repositorioCategoria;
        }

        protected override List<string> Validar(Categoria entidade)
        {
            List<string> erros = validadorCategoria.Validate(entidade).Errors.Select(x => x.ErrorMessage).ToList();

           Categoria categoria = repositorioCategoria.BuscarPorNome(entidade.Nome);

            if(categoria.Id != entidade.Id && categoria.Nome.TirarAcentosPalavra() == entidade.Nome.TirarAcentosPalavra() )
            {
                erros.Add($"Já existe uma categoria cadastrada com o nome '{categoria.Nome}'");
            }
            return erros;
        }
    }
}
