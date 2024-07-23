using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Get Lost Reason
/// </summary>
public partial class CrmLeadLost
{
    public int Id { get; set; }

    /// <summary>
    /// Lost Reason
    /// </summary>
    public int? LostReasonId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Closing Note
    /// </summary>
    public string? LostFeedback { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmLostReason? LostReason { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
