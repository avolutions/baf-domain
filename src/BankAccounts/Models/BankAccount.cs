using Avolutions.Baf.Core.Entity.Models;

namespace Avolutions.Baf.Domain.BankAccounts.Models;

public class BankAccount : EntityBase
{
    public string BankName { get; set; } = string.Empty;
    public string AccountHolder { get; set; } = string.Empty;
    public string Iban { get; set; } = string.Empty;
    public string Bic { get; set; } = string.Empty;
}