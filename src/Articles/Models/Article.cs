using Avolutions.Baf.Core.Entity.Models;
using Avolutions.Baf.Domain.QuantityUnits.Models;

namespace Avolutions.Baf.Domain.Articles.Models;

public class Article : EntityBase
{
    public ArticleType Type { get; set; } = ArticleType.Product;
    public string ArticleNo { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public Guid QuantityUnitId { get; set; }
    public QuantityUnit QuantityUnit { get; set; } = null!;
    public override string GetName() => $"{ArticleNo} - {Title}";
}