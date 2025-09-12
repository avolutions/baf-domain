using Avolutions.Baf.Domain.Salutations.Models;

namespace Avolutions.Baf.Domain.Salutations.Seed;

internal static class SalutationSeedData
{
    public static IEnumerable<Salutation> Salutations =>
    [
        new()
        {
            Translations = new List<SalutationTranslation>
            {
                new() { Language = "de", Value = "Herr", LetterSalutation = "Sehr geehrter Herr" },
                new() { Language = "en", Value = "Mr.",  LetterSalutation = "Dear Mr." }
            }
        },
        new()
        {
            Translations = new List<SalutationTranslation>
            {
                new() { Language = "de", Value = "Frau", LetterSalutation = "Sehr geehrte Frau" },
                new() { Language = "en", Value = "Ms.",  LetterSalutation = "Dear Ms." }
            }
        },
        new()
        {
            Translations = new List<SalutationTranslation>
            {
                new() { Language = "de", Value = "Divers", LetterSalutation = "Sehr geehrte*r" },
                new() { Language = "en", Value = "Mx.", LetterSalutation = "Dear Mx." }
            }
        }
    ];
}