using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Split Production Detail
/// </summary>
public partial class MrpProductionSplitLine
{
    public int Id { get; set; }

    /// <summary>
    /// Split Production
    /// </summary>
    public int MrpProductionSplitId { get; set; }

    /// <summary>
    /// Responsible
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
    /// Quantity To Produce
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Schedule Date
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpProductionSplit MrpProductionSplit { get; set; } = null!;

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
