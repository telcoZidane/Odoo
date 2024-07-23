using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock package type
/// </summary>
public partial class StockPackageType
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Height
    /// </summary>
    public int? Height { get; set; }

    /// <summary>
    /// Width
    /// </summary>
    public int? Width { get; set; }

    /// <summary>
    /// Length
    /// </summary>
    public int? PackagingLength { get; set; }

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
    /// Package Type
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Barcode
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Weight
    /// </summary>
    public double? BaseWeight { get; set; }

    /// <summary>
    /// Max Weight
    /// </summary>
    public double? MaxWeight { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ProductPackaging> ProductPackagings { get; set; } = new List<ProductPackaging>();

    public virtual ICollection<StockQuantPackage> StockQuantPackages { get; set; } = new List<StockQuantPackage>();

    public virtual ICollection<StockStorageCategoryCapacity> StockStorageCategoryCapacities { get; set; } = new List<StockStorageCategoryCapacity>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockPutawayRule> StockPutawayRules { get; set; } = new List<StockPutawayRule>();
}
