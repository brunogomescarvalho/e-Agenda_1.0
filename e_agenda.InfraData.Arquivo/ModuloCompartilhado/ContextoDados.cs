using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Dominio.ModuloDespesa;
using e_Agenda.Dominio.ModuloTarefa;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace e_Agenda.InfraDados.ModuloCompartilhado
{
    public class ContextoDados
    {
        public List<Contato> Contatos { get; set; }
        public List<Compromisso> Compromissos { get; set; }
        public List<Categoria> Categorias { get; set; }
        public List<Despesa> Despesas { get; set; }
        public List<Tarefa> Tarefas { get; set; }

        private const string NOME_ARQUIVO = @"ModuloCompartilhado\dados.json";

        public ContextoDados()
        {
            Contatos = new List<Contato>();

            Compromissos = new List<Compromisso>();

            Categorias = new List<Categoria>();

            Despesas = new List<Despesa>();

            Tarefas = new List<Tarefa>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            if (carregarDados)
            {
                CarregarDadosDoArquivo();
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

        private void GravarDadosJson()
        {
            JsonSerializerOptions options = new()
            {
                WriteIndented = true,

                IncludeFields = true,

                ReferenceHandler = ReferenceHandler.Preserve
            };

            string json = JsonSerializer.Serialize(this, options);

            File.WriteAllText(NOME_ARQUIVO, json);
        }

        private void CarregarDadosJson()
        {

            JsonSerializerOptions options = new()
            {
                ReferenceHandler = ReferenceHandler.Preserve,

                WriteIndented = true
            };

            string file = File.ReadAllText(NOME_ARQUIVO);

            if (file.Length > 100)
            {
                ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(file, options)!;

                Contatos = ctx.Contatos;
                Compromissos = ctx.Compromissos;
                Tarefas = ctx.Tarefas;
                Despesas = ctx.Despesas;
                Categorias = ctx.Categorias;
            }
        }
    }
}
