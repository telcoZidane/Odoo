using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// UTM Campaign
/// </summary>
public partial class UtmCampaign
{
    public int Id { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Stage
    /// </summary>
    public int StageId { get; set; }

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
    /// Campaign Identifier
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Campaign Name
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// Automatically Generated Campaign
    /// </summary>
    public bool? IsAutoCampaign { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Total A/B test percentage
    /// </summary>
    public int? AbTestingTotalPc { get; set; }

    /// <summary>
    /// Winner Selection
    /// </summary>
    public string? AbTestingWinnerSelection { get; set; }

    /// <summary>
    /// A/B Testing Campaign Finished
    /// </summary>
    public bool? AbTestingCompleted { get; set; }

    /// <summary>
    /// Send Final On
    /// </summary>
    public DateTime? AbTestingScheduleDatetime { get; set; }

    /// <summary>
    /// SMS Winner Selection
    /// </summary>
    public string? AbTestingSmsWinnerSelection { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual ICollection<LinkTrackerClick> LinkTrackerClicks { get; set; } = new List<LinkTrackerClick>();

    public virtual ICollection<LinkTracker> LinkTrackers { get; set; } = new List<LinkTracker>();

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailingMailing> MailingMailings { get; set; } = new List<MailingMailing>();

    public virtual ICollection<MailingTrace> MailingTraces { get; set; } = new List<MailingTrace>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ICollection<SmsComposer> SmsComposers { get; set; } = new List<SmsComposer>();

    public virtual UtmStage Stage { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<UtmTag> Campaigns { get; set; } = new List<UtmTag>();
}
