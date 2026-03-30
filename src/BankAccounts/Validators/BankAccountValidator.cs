using Avolutions.Baf.Core.Persistence;
using Avolutions.Baf.Domain.BankAccounts.Models;
using Avolutions.Baf.Domain.BankAccounts.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.BankAccounts.Validators;

public class BankAccountValidator : AbstractValidator<BankAccount>
{
    public BankAccountValidator(BafDbContext dbContext, IStringLocalizer<BankAccountResources> localizer)
    {
        RuleFor(x => x.BankName)
            .NotEmpty()
            .WithName(localizer["Field.BankName"]);

        RuleFor(x => x.AccountHolder)
            .NotEmpty()
            .WithName(localizer["Field.AccountHolder"]);

        RuleFor(x => x.Iban)
            .NotEmpty()
            .WithName(localizer["Field.Iban"])
            .Matches("^[A-Z]{2}\\d{2}[A-Z0-9]{1,30}$")
            .WithMessage(localizer["Validation.InvalidFormat", localizer["Field.Iban"]])
            .MaximumLength(34)
            .WithMessage(localizer["Validation.InvalidFormat", localizer["Field.Iban"], 34]);

        RuleFor(x => x.Bic)
            .NotEmpty()
            .WithName(localizer["Field.Bic"])
            .Matches("^[A-Z]{4}[A-Z]{2}[A-Z0-9]{2}([A-Z0-9]{3})?$")
            .WithMessage(localizer["Validation.InvalidFormat", localizer["Field.Bic"]])
            .MaximumLength(11)
            .WithMessage(localizer["Validation.InvalidFormat", localizer["Field.Bic"], 11]);
    }
}