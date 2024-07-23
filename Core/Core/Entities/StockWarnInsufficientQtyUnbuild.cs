﻿using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Warn Insufficient Unbuild Quantity
/// </summary>
public partial class StockWarnInsufficientQtyUnbuild
{
    public int Id { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Unbuild
    /// </summary>
    public int? UnbuildId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public string ProductUomName { get; set; } = null!;

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

    public virtual StockLocation Location { get; set; } = null!;

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual MrpUnbuild? Unbuild { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
