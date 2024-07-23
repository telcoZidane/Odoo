using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// People Role
/// </summary>
public partial class CrmIapLeadRole
{
    public int Id { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Reveal
    /// </summary>
    public string RevealId { get; set; } = null!;

    /// <summary>
    /// Role Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequests { get; set; } = new List<CrmIapLeadMiningRequest>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequestsNavigation { get; set; } = new List<CrmIapLeadMiningRequest>();
}
