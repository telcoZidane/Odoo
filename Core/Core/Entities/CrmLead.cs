using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Lead/Opportunity
/// </summary>
public partial class CrmLead
{
    public int Id { get; set; }

    /// <summary>
    /// Campaign
    /// </summary>
    public int? CampaignId { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public int? SourceId { get; set; }

    /// <summary>
    /// Medium
    /// </summary>
    public int? MediumId { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Bounce
    /// </summary>
    public int? MessageBounce { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? TeamId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Stage
    /// </summary>
    public int? StageId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Recurring Plan
    /// </summary>
    public int? RecurringPlan { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public int? Title { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public int? LangId { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public int? StateId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

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
    /// Sanitized Number
    /// </summary>
    public string? PhoneSanitized { get; set; }

    /// <summary>
    /// Normalized Email
    /// </summary>
    public string? EmailNormalized { get; set; }

    /// <summary>
    /// Email cc
    /// </summary>
    public string? EmailCc { get; set; }

    /// <summary>
    /// Opportunity
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Referred By
    /// </summary>
    public string? Referred { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Contact Name
    /// </summary>
    public string? ContactName { get; set; }

    /// <summary>
    /// Company Name
    /// </summary>
    public string? PartnerName { get; set; }

    /// <summary>
    /// Job Position
    /// </summary>
    public string? Function { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? EmailFrom { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? Phone { get; set; }

    /// <summary>
    /// Mobile
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// Phone Quality
    /// </summary>
    public string? PhoneState { get; set; }

    /// <summary>
    /// Email Quality
    /// </summary>
    public string? EmailState { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public string? Website { get; set; }

    /// <summary>
    /// Street
    /// </summary>
    public string? Street { get; set; }

    /// <summary>
    /// Street2
    /// </summary>
    public string? Street2 { get; set; }

    /// <summary>
    /// Zip
    /// </summary>
    public string? Zip { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Expected Closing
    /// </summary>
    public DateOnly? DateDeadline { get; set; }

    /// <summary>
    /// Properties
    /// </summary>
    public string? LeadProperties { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Expected Revenue
    /// </summary>
    public decimal? ExpectedRevenue { get; set; }

    /// <summary>
    /// Prorated Revenue
    /// </summary>
    public decimal? ProratedRevenue { get; set; }

    /// <summary>
    /// Recurring Revenues
    /// </summary>
    public decimal? RecurringRevenue { get; set; }

    /// <summary>
    /// Expected MRR
    /// </summary>
    public decimal? RecurringRevenueMonthly { get; set; }

    /// <summary>
    /// Prorated MRR
    /// </summary>
    public decimal? RecurringRevenueMonthlyProrated { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Closed Date
    /// </summary>
    public DateTime? DateClosed { get; set; }

    /// <summary>
    /// Last Action
    /// </summary>
    public DateTime? DateActionLast { get; set; }

    /// <summary>
    /// Assignment Date
    /// </summary>
    public DateTime? DateOpen { get; set; }

    /// <summary>
    /// Last Stage Update
    /// </summary>
    public DateTime? DateLastStageUpdate { get; set; }

    /// <summary>
    /// Conversion Date
    /// </summary>
    public DateTime? DateConversion { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Days to Assign
    /// </summary>
    public double? DayOpen { get; set; }

    /// <summary>
    /// Days to Close
    /// </summary>
    public double? DayClose { get; set; }

    /// <summary>
    /// Probability
    /// </summary>
    public double? Probability { get; set; }

    /// <summary>
    /// Automated Probability
    /// </summary>
    public double? AutomatedProbability { get; set; }

    /// <summary>
    /// Reveal ID
    /// </summary>
    public string? RevealId { get; set; }

    /// <summary>
    /// Enrichment done
    /// </summary>
    public bool? IapEnrichDone { get; set; }

    /// <summary>
    /// Lead Mining Request
    /// </summary>
    public int? LeadMiningRequestId { get; set; }

    /// <summary>
    /// Registration Rule
    /// </summary>
    public int? EventLeadRuleId { get; set; }

    /// <summary>
    /// Source Event
    /// </summary>
    public int? EventId { get; set; }

    public virtual ICollection<CalendarEvent> CalendarEvents { get; set; } = new List<CalendarEvent>();

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMassesNavigation { get; set; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartners { get; set; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<CrmQuotationPartner> CrmQuotationPartners { get; set; } = new List<CrmQuotationPartner>();

    public virtual EventEvent? Event { get; set; }

    public virtual EventLeadRule? EventLeadRule { get; set; }

    public virtual ResLang? Lang { get; set; }

    public virtual CrmIapLeadMiningRequest? LeadMiningRequest { get; set; }

    public virtual CrmLostReason? LostReason { get; set; }

    public virtual UtmMedium? Medium { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual CrmRecurringPlan? RecurringPlanNavigation { get; set; }

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual UtmSource? Source { get; set; }

    public virtual CrmStage? Stage { get; set; }

    public virtual ResCountryState? State { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual ResPartnerTitle? TitleNavigation { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses { get; set; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartnerMass> CrmLead2opportunityPartnerMasses1 { get; set; } = new List<CrmLead2opportunityPartnerMass>();

    public virtual ICollection<CrmLead2opportunityPartner> CrmLead2opportunityPartnersNavigation { get; set; } = new List<CrmLead2opportunityPartner>();

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual ICollection<CrmMergeOpportunity> Merges { get; set; } = new List<CrmMergeOpportunity>();

    public virtual ICollection<CrmTag> Tags { get; set; } = new List<CrmTag>();

    public virtual ICollection<WebsiteVisitor> WebsiteVisitors { get; set; } = new List<WebsiteVisitor>();
}
