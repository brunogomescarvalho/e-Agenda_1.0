
using e_Agenda.Dominio.ModuloCompartilhado;

namespace e_Agenda.InfraDados.ModuloCompartilhado
{
    public abstract class RepositorioBaseArquivo<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        private int contador;
        protected ContextoDados Contexto { get; set; }

        protected List<TEntidade> registros;

        protected RepositorioBaseArquivo(ContextoDados contexto)
        {
            this.Contexto = contexto;

            this.registros = ObterDados();

            AtualizarContador();
        }

        protected abstract List<TEntidade> ObterDados();

        public TEntidade BuscarPorId(int id)
        {
            return registros.FirstOrDefault(i => i.Id.Equals(id))!;
        }

        public virtual bool Cadastrar(TEntidade entidade)
        {       
            entidade.AtribuirId(++contador);

            registros.Add(entidade);

            Contexto.GravarDadosEmArquivo();

            return true;
        }

        public virtual bool Editar(TEntidade entidadeEditada)
        {
            TEntidade entidade = BuscarPorId(entidadeEditada.Id);

            entidade.Editar(entidadeEditada);

            Contexto.GravarDadosEmArquivo();

            return true;
        }

        public void Excluir(TEntidade entidade)
        {
            registros.Remove(entidade);

            Contexto.GravarDadosEmArquivo();
        }

        public void Excluir(int id)
        {
            registros.Remove(BuscarPorId(id));

            Contexto.GravarDadosEmArquivo();
        }

      
        public List<TEntidade> Listar()
        {
            return registros;
        }

        private void AtualizarContador()
        {
            if (registros.Count > 0)
            contador = registros.Max(x => x.Id);
        }       
    }
}
