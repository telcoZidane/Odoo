using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Packages
/// </summary>
public partial class StockQuantPackage
{
    public int Id { get; set; }

    /// <summary>
    /// Package Type
    /// </summary>
    public int? PackageTypeId { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int? LocationId { get; set; }

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
    /// Package Reference
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Package Use
    /// </summary>
    public string PackageUse { get; set; } = null!;

    /// <summary>
    /// Pack Date
    /// </summary>
    public DateOnly? PackDate { get; set; }

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

    public virtual StockLocation? Location { get; set; }

    public virtual StockPackageType? PackageType { get; set; }

    public virtual ICollection<StockMoveLine> StockMoveLinePackages { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMoveLine> StockMoveLineResultPackages { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; set; } = new List<StockPackageLevel>();

    public virtual ICollection<StockQuant> StockQuants { get; set; } = new List<StockQuant>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual ResUser? WriteU { get; set; }
}
