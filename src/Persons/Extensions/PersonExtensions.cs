using Avolutions.Baf.Domain.Persons.Abstractions;

namespace Avolutions.Baf.Domain.Persons.Extensions;

public static class PersonExtensions
{
    public static string FullName(this IPerson person)
    {
        return $"{person.AcademicTitle?.Value} {person.FirstName} {person.LastName}".Trim();
    }
    
    public static string LetterSalutation(this IPerson person)
    {
        var salutation = person.Salutation?.LetterSalutation;
        var title = person.AcademicTitle?.Value;
        var lastName = person.LastName;

        return !string.IsNullOrWhiteSpace(title) ? $"{salutation} {title} {lastName}".Trim() : $"{salutation} {lastName}".Trim();
    }
}