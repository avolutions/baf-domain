using Avolutions.Baf.Core.Entity.Models;

namespace Avolutions.Baf.Domain.Salutations.Models;

public class SalutationTranslation : TranslationEntity
{
    public string LetterSalutation { get; set; } = string.Empty;
}