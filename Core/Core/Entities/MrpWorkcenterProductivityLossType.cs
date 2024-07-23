using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// MRP Workorder productivity losses
/// </summary>
public partial class MrpWorkcenterProductivityLossType
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
    /// Category
    /// </summary>
    public string LossType { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MrpWorkcenterProductivityLoss> MrpWorkcenterProductivityLosses { get; set; } = new List<MrpWorkcenterProductivityLoss>();

    public virtual ResUser? WriteU { get; set; }
}
