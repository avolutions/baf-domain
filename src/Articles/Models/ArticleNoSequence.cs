using Avolutions.Baf.Core.NumberSequences.Models;

namespace Avolutions.Baf.Domain.Articles.Models;

public sealed class ArticleNoSequence : INumberSequenceDefinition
{
    public static string Name => "ArticleNo";

    public static NumberSequence Defaults { get; } = new()
    {
        Name = Name,
        NextNumber = 1,
        NumberLength = 5,
        Prefix = ""
    };
}