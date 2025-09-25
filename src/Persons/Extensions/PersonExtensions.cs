using Avolutions.Baf.Domain.Persons.Abstractions;

namespace Avolutions.Baf.Domain.Persons.Extensions;

public static class PersonExtensions
{
    public static string FullName(this IPerson person)
    {
        return $"{person.AcademicTitle?.Value} {person.FirstName} {person.LastName}".Trim();
    }
}