using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Category
/// </summary>
public partial class ProductCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Parent Category
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Complete Name
    /// </summary>
    public string? CompleteName { get; set; }

    /// <summary>
    /// Parent Path
    /// </summary>
    public string? ParentPath { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Force Removal Strategy
    /// </summary>
    public int? RemovalStrategyId { get; set; }

    /// <summary>
    /// Reserve Packagings
    /// </summary>
    public string? PackagingReserveMethod { get; set; }

    public virtual ICollection<AccountAnalyticApplicability> AccountAnalyticApplicabilities { get; set; } = new List<AccountAnalyticApplicability>();

    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; set; } = new List<AccountAnalyticDistributionModel>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductCategory> InverseParent { get; set; } = new List<ProductCategory>();

    public virtual ProductCategory? Parent { get; set; }

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

    public virtual ProductRemoval? RemovalStrategy { get; set; }

    public virtual ICollection<StockPutawayRule> StockPutawayRules { get; set; } = new List<StockPutawayRule>();

    public virtual ICollection<StockWarehouseOrderpoint> StockWarehouseOrderpoints { get; set; } = new List<StockWarehouseOrderpoint>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockRoute> Routes { get; set; } = new List<StockRoute>();
}
