using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

using System.Xml.Serialization;

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

            GravarDadosEmArquivo();
        }

        public void Excluir(int id)
        {
            registros.Remove(BuscarPorId(id));

            GravarDadosEmArquivo();
        }

        private void GravarDadosJson()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();

            options.WriteIndented = true;

            string json = JsonSerializer.Serialize(registros);

            File.WriteAllText(NOME_ARQUIVO, json);
        }

        private void CarregarDadosJson()
        {
            string file = File.ReadAllText(NOME_ARQUIVO);

            if(file.Length > 10)
            {
                registros = JsonSerializer.Deserialize<List<TEntidade>>(file)!;
            }
        }

        private void CarregarDadosXML()
        {
            //  BinaryFormatter serializador = new BinaryFormatter();

            XmlSerializer serializador = new XmlSerializer(typeof(List<TEntidade>));

            byte[] tarefaEmBytes = File.ReadAllBytes(NOME_ARQUIVO);

            MemoryStream tarefaStream = new MemoryStream(tarefaEmBytes);

            registros = (List<TEntidade>)serializador.Deserialize(tarefaStream)!;

            GravarDadosEmArquivo();

            AtualizarContador();
        }

        private void GravarDadosXML()
        {
            // BinaryFormatter serializador = new BinaryFormatter();

            XmlSerializer serializador = new XmlSerializer(typeof(List<TEntidade>));

            MemoryStream contatoStream = new MemoryStream();

            serializador.Serialize(contatoStream, registros);

            byte[] tarefasEmBytes = contatoStream.ToArray();

            File.WriteAllBytes(NOME_ARQUIVO, tarefasEmBytes);
        }

        public List<TEntidade> Listar()
        {
            return registros;
        }

        private void AtualizarContador()
        {
            contador = registros.Max(x => x.Id);
        }

        private void GravarDadosEmArquivo()
        {
            GravarDadosJson();
        }

        private void CarregarDadosDoArquivo()
        {
            CarregarDadosJson();
        }

        
    }
}
