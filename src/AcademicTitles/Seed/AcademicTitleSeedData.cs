using Avolutions.Baf.Domain.AcademicTitles.Models;

namespace Avolutions.Baf.Domain.AcademicTitles.Seed;

internal static class AcademicTitleSeedData
{
    public static IEnumerable<AcademicTitle> AcademicTitles =>
    [
        new()
        {
            Translations = new List<AcademicTitleTranslation>
            {
                new() { Language = "de", Value = "Dr." },
                new() { Language = "en", Value = "Dr." }
            }
        },
        new()
        {
            Translations = new List<AcademicTitleTranslation>
            {
                new() { Language = "de", Value = "Prof." },
                new() { Language = "en", Value = "Prof." }
            }
        },
        new()
        {
            Translations = new List<AcademicTitleTranslation>
            {
                new() { Language = "de", Value = "Dipl.-Ing." },
                new() { Language = "en", Value = "Dipl.-Ing." }
            }
        }
    ];
}