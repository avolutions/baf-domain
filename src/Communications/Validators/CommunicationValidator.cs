using Avolutions.Baf.Domain.Communications.Models;
using Avolutions.Baf.Domain.Communications.Resources;
using FluentValidation;
using Microsoft.Extensions.Localization;

namespace Avolutions.Baf.Domain.Communications.Validators;

public class CommunicationValidator : AbstractValidator<Communication>
{
    private const string WebsitePattern =
        @"^(https?:\/\/)?([\w-]+\.)+[a-zA-Z]{2,}(:\d{1,5})?([\/?#]\S*)?$";
    
    public CommunicationValidator(IStringLocalizer<CommunicationResources> localizer)
    {
        RuleFor(c => c.Email)
            .EmailAddress()
            .Matches(@"@[^@\s]+\.[a-zA-Z]{2,}$")
            .MaximumLength(320)
            .When(c => !string.IsNullOrWhiteSpace(c.Email))
            .WithName(localizer["Field.Email"]);
 
        RuleFor(c => c.EmailAlternative)
            .EmailAddress()
            .Matches(@"@[^@\s]+\.[a-zA-Z]{2,}$")
            .MaximumLength(320)
            .When(c => !string.IsNullOrWhiteSpace(c.EmailAlternative))
            .WithName(localizer["Field.EmailAlternative"]);
        
        RuleFor(c => c.Website)
            .Matches(WebsitePattern)
            .MaximumLength(2048)
            .When(c => !string.IsNullOrWhiteSpace(c.Website))
            .WithName(localizer["Field.Website"]);
    }
}