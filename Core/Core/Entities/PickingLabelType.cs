using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Choose whether to print product or lot/sn labels
/// </summary>
public partial class PickingLabelType
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Labels to print
    /// </summary>
    public string LabelType { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();
}
