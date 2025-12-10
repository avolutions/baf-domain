using System.ComponentModel.DataAnnotations.Schema;
using Avolutions.Baf.Core.Lookups.Extensions;
using Avolutions.Baf.Core.Lookups.Models;

namespace Avolutions.Baf.Domain.Salutations.Models;

public class Salutation : Lookup<SalutationTranslation>
{
    public Salutation() : base() { }
    public Salutation(bool createMissingTranslations) : base(createMissingTranslations) { }
    [NotMapped]
    public string LetterSalutation => Translations.Localized(t => t.LetterSalutation);
}