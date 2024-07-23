using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Convert Lead to Opportunity (in mass)
/// </summary>
public partial class CrmLead2opportunityPartnerMass
{
    public int Id { get; set; }

    /// <summary>
    /// Associated Lead
    /// </summary>
    public int? LeadId { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? TeamId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Conversion Action
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Related Customer
    /// </summary>
    public string? Action { get; set; }

    /// <summary>
    /// Force assignment
    /// </summary>
    public bool? ForceAssignment { get; set; }

    /// <summary>
    /// Apply deduplication
    /// </summary>
    public bool? Deduplicate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual CrmLead? Lead { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ICollection<CrmLead> CrmLeadsNavigation { get; set; } = new List<CrmLead>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();
}
