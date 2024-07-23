using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// CRM Lead Mining Request
/// </summary>
public partial class CrmIapLeadMiningRequest
{
    public int Id { get; set; }

    /// <summary>
    /// Number of Leads
    /// </summary>
    public int LeadNumber { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? TeamId { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Size
    /// </summary>
    public int? CompanySizeMin { get; set; }

    /// <summary>
    /// Company Size Max
    /// </summary>
    public int? CompanySizeMax { get; set; }

    /// <summary>
    /// Number of Contacts
    /// </summary>
    public int? ContactNumber { get; set; }

    /// <summary>
    /// Preferred Role
    /// </summary>
    public int? PreferredRoleId { get; set; }

    /// <summary>
    /// Seniority
    /// </summary>
    public int? SeniorityId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Request Number
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Target
    /// </summary>
    public string SearchType { get; set; } = null!;

    /// <summary>
    /// Error Type
    /// </summary>
    public string? ErrorType { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string LeadType { get; set; } = null!;

    /// <summary>
    /// Filter on
    /// </summary>
    public string? ContactFilterType { get; set; }

    /// <summary>
    /// Filter on Size
    /// </summary>
    public bool? FilterOnSize { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual CrmIapLeadRole? PreferredRole { get; set; }

    public virtual CrmIapLeadSeniority? Seniority { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmIapLeadIndustry> CrmIapLeadIndustries { get; set; } = new List<CrmIapLeadIndustry>();

    public virtual ICollection<CrmIapLeadRole> CrmIapLeadRoles { get; set; } = new List<CrmIapLeadRole>();

    public virtual ICollection<CrmTag> CrmTags { get; set; } = new List<CrmTag>();

    public virtual ICollection<ResCountry> ResCountries { get; set; } = new List<ResCountry>();

    public virtual ICollection<ResCountryState> ResCountryStates { get; set; } = new List<ResCountryState>();
}
