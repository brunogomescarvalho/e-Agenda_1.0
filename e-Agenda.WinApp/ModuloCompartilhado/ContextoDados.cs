using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesa;
using e_Agenda.WinApp.ModuloTarefa;
using Microsoft.Win32;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace e_Agenda.WinApp.ModuloCompartilhado
{
    public class ContextoDados
    {
        public List<Contato> contatos { get; set; }

        public List<Compromisso> compromissos { get; set; }

        public List<Categoria> categorias { get; set; }

        public List<Despesa> despesas { get; set; }

        public List<Tarefa> tarefas { get; set; }

        private string NOME_ARQUIVO { get => @"ModuloCompartilhado\dados.json"; }


        public ContextoDados()
        {
            contatos = new List<Contato>();

            compromissos = new List<Compromisso>();

            categorias = new List<Categoria>();

            despesas = new List<Despesa>();

            tarefas = new List<Tarefa>();          
        }

        public ContextoDados(bool carregarDados) :this()
        {
            CarregarDadosDoArquivo();
        }


        private void GravarDadosJson()
        {
            JsonSerializerOptions options = new JsonSerializerOptions();

            options.WriteIndented = true;

            options.IncludeFields = true;

            options.ReferenceHandler = ReferenceHandler.Preserve;

            string json = JsonSerializer.Serialize(this,options);

            File.WriteAllText(NOME_ARQUIVO, json);
        }

        private void CarregarDadosJson()
        {

            JsonSerializerOptions options = new JsonSerializerOptions();

            options.ReferenceHandler = ReferenceHandler.Preserve;

            options.WriteIndented = true;

            string file = File.ReadAllText(NOME_ARQUIVO);

            if (file.Length > 100)
            {
                ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(file, options)!;

                contatos = ctx.contatos;
                compromissos = ctx.compromissos;
                tarefas = ctx.tarefas;
                despesas = ctx.despesas;
                categorias = ctx.categorias;
            }
        }

        public void GravarDadosEmArquivo()
        {
            GravarDadosJson();
        }

        public void CarregarDadosDoArquivo()
        {
            CarregarDadosJson();
        }




        //private void CarregarDadosXML()
        //{
        //    //  BinaryFormatter serializador = new BinaryFormatter();

        //    XmlSerializer serializador = new XmlSerializer(typeof(List<TEntidade>));

        //    byte[] tarefaEmBytes = File.ReadAllBytes(NOME_ARQUIVO);
        //    MemoryStream tarefaStream = new MemoryStream(tarefaEmBytes);

        //    registros = (List<TEntidade>)serializador.Deserialize(tarefaStream)!;

        //    GravarDadosEmArquivo();

        //    AtualizarContador();
        //}

        //private void GravarDadosXML()
        //{
        //    // BinaryFormatter serializador = new BinaryFormatter();

        //    XmlSerializer serializador = new XmlSerializer(typeof(List<TEntidade>));

        //    MemoryStream contatoStream = new MemoryStream();

        //    serializador.Serialize(contatoStream, registros);

        //    byte[] tarefasEmBytes = contatoStream.ToArray();

        //    File.WriteAllBytes(NOME_ARQUIVO, tarefasEmBytes);
        //}




    }
}
