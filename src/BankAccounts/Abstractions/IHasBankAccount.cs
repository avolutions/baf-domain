using Avolutions.Baf.Domain.BankAccounts.Models;

namespace Avolutions.Baf.Domain.BankAccounts.Abstractions;

public interface IHasBankAccount
{
    public Guid BankAccountId { get; set; }
    public BankAccount BankAccount { get; set; }
}