using Avolutions.Baf.Core.Lookups.Models;

namespace Avolutions.Baf.Domain.Salutations.Models;

public class SalutationTranslation : LookupTranslation
{
    public string LetterSalutation { get; set; } = string.Empty;
}