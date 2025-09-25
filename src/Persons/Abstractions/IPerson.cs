using Avolutions.Baf.Domain.AcademicTitles.Models;
using Avolutions.Baf.Domain.Salutations.Models;

namespace Avolutions.Baf.Domain.Persons.Abstractions;

public interface IPerson
{
    public string? FirstName { get; set; }
    public string LastName { get; set; }
    
    public Guid? SalutationId { get; set; }
    public Salutation? Salutation { get; set; }
    
    public Guid? AcademicTitleId { get; set; }
    public AcademicTitle? AcademicTitle { get; set; }
}