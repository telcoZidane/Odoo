using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Quants
/// </summary>
public partial class StockQuant
{
    public int Id { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Storage Category
    /// </summary>
    public int? StorageCategoryId { get; set; }

    /// <summary>
    /// Lot/Serial Number
    /// </summary>
    public int? LotId { get; set; }

    /// <summary>
    /// Package
    /// </summary>
    public int? PackageId { get; set; }

    /// <summary>
    /// Owner
    /// </summary>
    public int? OwnerId { get; set; }

    /// <summary>
    /// Assigned To
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Scheduled Date
    /// </summary>
    public DateOnly? InventoryDate { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Reserved Quantity
    /// </summary>
    public decimal ReservedQuantity { get; set; }

    /// <summary>
    /// Counted Quantity
    /// </summary>
    public decimal? InventoryQuantity { get; set; }

    /// <summary>
    /// Difference
    /// </summary>
    public decimal? InventoryDiffQuantity { get; set; }

    /// <summary>
    /// Inventory Quantity Set
    /// </summary>
    public bool? InventoryQuantitySet { get; set; }

    /// <summary>
    /// Incoming Date
    /// </summary>
    public DateTime InDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Accounting Date
    /// </summary>
    public DateOnly? AccountingDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockLot? Lot { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual StockQuantPackage? Package { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual StockStorageCategory? StorageCategory { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockInventoryAdjustmentName> StockInventoryAdjustmentNames { get; set; } = new List<StockInventoryAdjustmentName>();

    public virtual ICollection<StockInventoryConflict> StockInventoryConflicts { get; set; } = new List<StockInventoryConflict>();

    public virtual ICollection<StockInventoryConflict> StockInventoryConflictsNavigation { get; set; } = new List<StockInventoryConflict>();

    public virtual ICollection<StockInventoryWarning> StockInventoryWarnings { get; set; } = new List<StockInventoryWarning>();

    public virtual ICollection<StockRequestCount> StockRequestCounts { get; set; } = new List<StockRequestCount>();

    public virtual ICollection<StockTrackConfirmation> StockTrackConfirmations { get; set; } = new List<StockTrackConfirmation>();
}
