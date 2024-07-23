using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Work Center Capacity
/// </summary>
public partial class MrpWorkcenterCapacity
{
    public int Id { get; set; }

    /// <summary>
    /// Work Center
    /// </summary>
    public int WorkcenterId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

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
    /// Capacity
    /// </summary>
    public double? Capacity { get; set; }

    /// <summary>
    /// Setup Time (minutes)
    /// </summary>
    public double? TimeStart { get; set; }

    /// <summary>
    /// Cleanup Time (minutes)
    /// </summary>
    public double? TimeStop { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual MrpWorkcenter Workcenter { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
