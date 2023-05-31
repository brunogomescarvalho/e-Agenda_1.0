using System.Runtime.Serialization.Formatters.Binary;

namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public abstract class RepositorioBaseArquivo<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {

        protected abstract string NOME_ARQUIVO { get; }

        protected List<TEntidade> registros;

        private int contador;

        protected RepositorioBaseArquivo(List<TEntidade> registros)
        {
            this.registros = registros;

            if (File.Exists(NOME_ARQUIVO))
                CarregarDadosDoArquivo();
        }

        public TEntidade BuscarPorId(int id)
        {
            return registros.FirstOrDefault(i => i.Id.Equals(id))!;
        }

        public virtual bool Cadastrar(TEntidade entidade)
        {
            entidade.AtribuirId(contador++);

            registros.Add(entidade);

            GravarDadosEmArquivo();

            return true;
        }

        public virtual bool Editar(TEntidade entidade)
        {
            GravarDadosEmArquivo();

            return true;
        }

        public void Excluir(TEntidade entidade)
        {
            registros.Remove(entidade);
        }

        public void Excluir(int id)
        {
            TEntidade contato = BuscarPorId(id);

            registros.Remove(contato);
        }

        private void CarregarDadosDoArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            byte[] tarefaEmBytes = File.ReadAllBytes(NOME_ARQUIVO);

            MemoryStream tarefaStream = new MemoryStream(tarefaEmBytes);

            registros = (List<TEntidade>)serializador.Deserialize(tarefaStream);

            GravarDadosEmArquivo();

            AtualizarContador();
        }

        private void GravarDadosEmArquivo()
        {
            BinaryFormatter serializador = new BinaryFormatter();

            MemoryStream contatoStream = new MemoryStream();

            serializador.Serialize(contatoStream, registros);

            byte[] tarefasEmBytes = contatoStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO, tarefasEmBytes);
        }

        private void AtualizarContador()
        {
            contador = registros.Max(x => x.Id);
        }

        public List<TEntidade> Listar()
        {
            return registros;
        }
    }
}
