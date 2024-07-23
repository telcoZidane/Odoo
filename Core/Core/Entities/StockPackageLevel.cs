using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Stock Package Level
/// </summary>
public partial class StockPackageLevel
{
    public int Id { get; set; }

    /// <summary>
    /// Package
    /// </summary>
    public int PackageId { get; set; }

    /// <summary>
    /// Picking
    /// </summary>
    public int? PickingId { get; set; }

    /// <summary>
    /// To
    /// </summary>
    public int? LocationDestId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation? LocationDest { get; set; }

    public virtual StockQuantPackage Package { get; set; } = null!;

    public virtual StockPicking? Picking { get; set; }

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ResUser? WriteU { get; set; }
}
