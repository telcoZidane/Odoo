using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Storage Category
/// </summary>
public partial class StockStorageCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Storage Category
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Allow New Product
    /// </summary>
    public string AllowNewProduct { get; set; } = null!;

    /// <summary>
    /// Max Weight
    /// </summary>
    public decimal? MaxWeight { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<StockLocation> StockLocations { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockPutawayRule> StockPutawayRules { get; set; } = new List<StockPutawayRule>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacities { get; set; } = new List<StockStorageCategoryCapacity>();

    public virtual ResUser? WriteU { get; set; }
}
