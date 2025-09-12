using System.ComponentModel.DataAnnotations.Schema;
using Avolutions.Baf.Core.Entity.Extensions;
using Avolutions.Baf.Core.Entity.Models;

namespace Avolutions.Baf.Domain.Salutations.Models;

public class Salutation : TranslatableEntity<SalutationTranslation>
{
    public Salutation() : base() { }
    public Salutation(bool createMissingTranslations) : base(createMissingTranslations) { }
    [NotMapped]
    public string LetterSalutation => Translations.Localized(t => t.LetterSalutation);
}