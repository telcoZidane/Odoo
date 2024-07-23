using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sales Team
/// </summary>
public partial class CrmTeam
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Team Leader
    /// </summary>
    public int? UserId { get; set; }

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
    /// Sales Team
    /// </summary>
    public string Name { get; set; } = null!;

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

    /// <summary>
    /// Quotations
    /// </summary>
    public bool? UseQuotations { get; set; }

    /// <summary>
    /// Invoicing Target
    /// </summary>
    public double? InvoicedTarget { get; set; }

    /// <summary>
    /// Alias
    /// </summary>
    public int AliasId { get; set; }

    /// <summary>
    /// Assignment Domain
    /// </summary>
    public string? AssignmentDomain { get; set; }

    /// <summary>
    /// Lead Properties
    /// </summary>
    public string? LeadPropertiesDefinition { get; set; }

    /// <summary>
    /// Leads
    /// </summary>
    public bool? UseLeads { get; set; }

    /// <summary>
    /// Pipeline
    /// </summary>
    public bool? UseOpportunities { get; set; }

    /// <summary>
    /// Skip auto assignment
    /// </summary>
    public bool? AssignmentOptout { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual MailAlias Alias { get; set; } = null!;

    public virtual ICollection<ChatbotScriptStep> ChatbotScriptSteps { get; set; } = new List<ChatbotScriptStep>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmIapLeadMiningRequest> CrmIapLeadMiningRequests { get; set; } = new List<CrmIapLeadMiningRequest>();

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; set; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartners { get; set; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<CrmLeadScoringFrequency> CrmLeadScoringFrequencies { get; set; } = new List<CrmLeadScoringFrequency>();

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ICollection<CrmMergeOpportunity> CrmMergeOpportunities { get; set; } = new List<CrmMergeOpportunity>();

    public virtual ICollection<CrmStage> CrmStages { get; set; } = new List<CrmStage>();

    public virtual ICollection<CrmTeamMember> CrmTeamMembers { get; set; } = new List<CrmTeamMember>();

    public virtual ICollection<EventLeadRule> EventLeadRules { get; set; } = new List<EventLeadRule>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ResUser? User { get; set; }

    public virtual ICollection<Website> WebsiteCrmDefaultTeams { get; set; } = new List<Website>();

    public virtual ICollection<Website> WebsiteSalesteams { get; set; } = new List<Website>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> Users { get; set; } = new List<ResUser>();
}
