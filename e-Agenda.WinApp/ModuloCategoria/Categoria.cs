namespace e_Agenda.WinApp.ModuloCategoria
{
    [Serializable]
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
            return Nome.Trim() == string.Empty ? 
                new string[] { "Informe o nome da categoria!" } : Array.Empty<string>();
        }

        public override string ToString()
        {
            return $"{Nome}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Categoria categoria &&
                   Id == categoria.Id &&
                   Nome == categoria.Nome;
        }
    }
}
