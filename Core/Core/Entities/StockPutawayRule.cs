using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Putaway Rule
/// </summary>
public partial class StockPutawayRule
{
    public int Id { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Product Category
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// When product arrives in
    /// </summary>
    public int LocationInId { get; set; }

    /// <summary>
    /// Store to sublocation
    /// </summary>
    public int LocationOutId { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Storage Category
    /// </summary>
    public int? StorageCategoryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ProductCategory? Category { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation LocationIn { get; set; } = null!;

    public virtual StockLocation LocationOut { get; set; } = null!;

    public virtual ProductProduct? Product { get; set; }

    public virtual StockStorageCategory? StorageCategory { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockPackageType> StockPackageTypes { get; set; } = new List<StockPackageType>();
}
