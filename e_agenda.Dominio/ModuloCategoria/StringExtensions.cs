using System.Globalization;
using System.Text;

namespace e_Agenda.InfraDados.ModuloCompartilhado
{
    public static class StringExtensions
    {
        public static string TirarAcentosPalavra(this string text)
        {
            return new string(text
                .Normalize(NormalizationForm.FormD)
                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray());
        }
    }
}

