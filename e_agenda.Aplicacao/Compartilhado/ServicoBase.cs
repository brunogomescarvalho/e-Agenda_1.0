using e_Agenda.Dominio.ModuloCompartilhado;
using FluentResults;
using Serilog;

namespace e_agenda.Aplicacao.Compartilhado
{
     delegate void onAlterarTabela<TEntidade>(TEntidade entidade);

    public abstract class ServicoBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {

        protected IRepositorioBase<TEntidade> repositorioBase = null!;

      
        protected abstract List<string> Validar(TEntidade entidade);


        public Result Cadastrar(TEntidade entidade)
        {
            return AlterarTabela(repositorioBase.Cadastrar, entidade);
        }

        public Result Editar(TEntidade entidade)
        {
            return AlterarTabela(repositorioBase.Editar, entidade);
        }

        public Result Excluir(TEntidade entidade)
        {
            return AlterarTabela(repositorioBase.Excluir, entidade);
        }



        private Result AlterarTabela(onAlterarTabela<TEntidade> onAlterarTabela_, TEntidade entidade )
        {
            List<string> erros = Validar(entidade);

            if(erros.Any())
            {
                erros.ForEach(i => Log.Warning(i));

                return Result.Fail(erros);
            }

            try
            {
                Log.Debug($"Tentando {onAlterarTabela_.Method.Name} {typeof(TEntidade).Name}");

                onAlterarTabela_(entidade);

                Log.Debug("Solicitação efetuada com sucesso!");

                return Result.Ok();
            }
            catch
            {
                string erro = $"Falha ao tentar  {onAlterarTabela_.Method.Name} {typeof(TEntidade).Name}";

                Log.Error(erro);

                return Result.Fail(erro);
            }

            
        }
    }
}
