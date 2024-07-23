using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// UTM Source
/// </summary>
public partial class UtmSource
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
    /// Source Name
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

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ICollection<ChatbotScript> ChatbotScripts { get; set; } = new List<ChatbotScript>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLead> CrmLeads { get; set; } = new List<CrmLead>();

    public virtual ICollection<EventRegistration> EventRegistrations { get; set; } = new List<EventRegistration>();

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrRecruitmentSource> HrRecruitmentSources { get; set; } = new List<HrRecruitmentSource>();

    public virtual ICollection<LinkTracker> LinkTrackers { get; set; } = new List<LinkTracker>();

    public virtual ICollection<MailingMailing> MailingMailings { get; set; } = new List<MailingMailing>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }
}
