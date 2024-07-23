using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Storage Category Capacity
/// </summary>
public partial class StockStorageCategoryCapacity
{
    public int Id { get; set; }

    /// <summary>
    /// Storage Category
    /// </summary>
    public int StorageCategoryId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Package Type
    /// </summary>
    public int? PackageTypeId { get; set; }

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

    /// <summary>
    /// Quantity
    /// </summary>
    public double Quantity { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual StockPackageType? PackageType { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual StockStorageCategory StorageCategory { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
