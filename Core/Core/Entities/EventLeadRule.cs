using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Event Lead Rules
/// </summary>
public partial class EventLeadRule
{
    public int Id { get; set; }

    /// <summary>
    /// Event
    /// </summary>
    public int? EventId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? LeadSalesTeamId { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? LeadUserId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Create
    /// </summary>
    public string LeadCreationBasis { get; set; } = null!;

    /// <summary>
    /// When
    /// </summary>
    public string LeadCreationTrigger { get; set; } = null!;

    /// <summary>
    /// Lead Type
    /// </summary>
    public string LeadType { get; set; } = null!;

    /// <summary>
    /// Rule Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Registrations Domain
    /// </summary>
    public string? EventRegistrationFilter { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual EventEvent? Event { get; set; }

    public virtual CrmTeam? LeadSalesTeam { get; set; }

    public virtual ResUser? LeadUser { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmTag> CrmTags { get; set; } = new List<CrmTag>();

    public virtual ICollection<EventType> EventTypes { get; set; } = new List<EventType>();
}
