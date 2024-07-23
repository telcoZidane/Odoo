using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Specify product lot/serial number in pos order line
/// </summary>
public partial class PosPackOperationLot
{
    public int Id { get; set; }

    /// <summary>
    /// Pos Order Line
    /// </summary>
    public int? PosOrderLineId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Lot Name
    /// </summary>
    public string? LotName { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual PosOrderLine? PosOrderLine { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
