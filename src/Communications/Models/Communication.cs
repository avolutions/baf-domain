using Avolutions.Baf.Core.Entity.Models;

namespace Avolutions.Baf.Domain.Communications.Models;

public class Communication : EntityBase
{
    public string? Phone { get; set; }
    public string? PhoneMobile { get; set; }
    public string? PhoneAlternative { get; set; }
    public string? Fax { get; set; }
    public string? Email { get; set; }
    public string? EmailAlternative { get; set; }
    public string? Website { get; set; }
}