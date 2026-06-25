using System.ComponentModel.DataAnnotations.Schema;
using Avolutions.Baf.Core.Entity.Abstractions;
using Avolutions.Baf.Core.Entity.Attributes;
using Avolutions.Baf.Core.Entity.Models;
using Avolutions.Baf.Core.Lookups.Attributes;
using Avolutions.Baf.Domain.QuantityUnits.Models;

namespace Avolutions.Baf.Domain.Articles.Models;

public class Article : EntityBase, INavigable
{
    public ArticleType Type { get; set; } = ArticleType.Product;
    [EntityNavigationKey]
    public string ArticleNo { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public decimal? Percentage { get; set; }
    public decimal TaxRate { get; set; }
    public Guid QuantityUnitId { get; set; }
    [Lookup]
    public QuantityUnit QuantityUnit { get; set; } = null!;
    public override string GetName() => $"{ArticleNo} - {Title}";
    
    [NotMapped]
    public decimal GrossPrice => Math.Round(Price * (1 + TaxRate / 100m), 2, MidpointRounding.AwayFromZero);
}