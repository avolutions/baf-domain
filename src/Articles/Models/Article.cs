using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Avolutions.Baf.Core.Entity.Models;
using Avolutions.Baf.Domain.QuantityUnits.Models;
using Microsoft.EntityFrameworkCore;

namespace Avolutions.Baf.Domain.Articles.Models;

public class Article : EntityBase
{
    public ArticleType Type { get; set; } = ArticleType.Product;
    public string ArticleNo { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal Price { get; set; }
    [Range(0, 100)]
    [Precision(5, 2)]
    public decimal TaxRate { get; set; }
    public Guid QuantityUnitId { get; set; }
    public QuantityUnit QuantityUnit { get; set; } = null!;
    public override string GetName() => $"{ArticleNo} - {Title}";
    
    [NotMapped]
    public decimal GrossPrice => Math.Round(Price * (1 + TaxRate / 100m), 2, MidpointRounding.AwayFromZero);
}