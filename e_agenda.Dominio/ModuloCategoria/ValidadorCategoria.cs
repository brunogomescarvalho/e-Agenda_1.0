using e_Agenda.Dominio.ModuloCategoria;
using FluentValidation;

namespace e_agenda.Dominio.ModuloCategoria
{
    public class ValidadorCategoria : AbstractValidator<Categoria>
    {
        public ValidadorCategoria() 
        {
            RuleFor(x => x.Nome)
               .NotNull()
               .Length(3, 20);
        }
    }
}
