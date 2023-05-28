namespace e_Agenda.WinApp.ModuloCategoria
{
    public class Categoria : EntidadeBase<Categoria>
    {
        public string Nome { get; private set; }

        public Categoria(string categoria)
        {
            Nome = categoria;
        }

        public override void Editar(Categoria entidade)
        {
            Nome = entidade.Nome;
        }

        public override string[] Validar()
        {
            return Nome.Trim() == string.Empty ? new string[] { "Informe o nome da categoria!" } : Array.Empty<string>();
        }
    }




}
