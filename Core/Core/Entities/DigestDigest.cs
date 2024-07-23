using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Digest
/// </summary>
public partial class DigestDigest
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Periodicity
    /// </summary>
    public string Periodicity { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Next Mailing Date
    /// </summary>
    public DateOnly? NextRunDate { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Connected Users
    /// </summary>
    public bool? KpiResUsersConnected { get; set; }

    /// <summary>
    /// Messages Sent
    /// </summary>
    public bool? KpiMailMessageTotal { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Revenue
    /// </summary>
    public bool? KpiAccountTotalRevenue { get; set; }

    /// <summary>
    /// All Sales
    /// </summary>
    public bool? KpiAllSaleTotal { get; set; }

    /// <summary>
    /// Open Tasks
    /// </summary>
    public bool? KpiProjectTaskOpened { get; set; }

    /// <summary>
    /// New Leads
    /// </summary>
    public bool? KpiCrmLeadCreated { get; set; }

    /// <summary>
    /// Opportunities Won
    /// </summary>
    public bool? KpiCrmOpportunitiesWon { get; set; }

    /// <summary>
    /// New Employees
    /// </summary>
    public bool? KpiHrRecruitmentNewColleagues { get; set; }

    /// <summary>
    /// POS Sales
    /// </summary>
    public bool? KpiPosTotal { get; set; }

    /// <summary>
    /// eCommerce Sales
    /// </summary>
    public bool? KpiWebsiteSaleTotal { get; set; }

    /// <summary>
    /// % of Happiness
    /// </summary>
    public bool? KpiLivechatRating { get; set; }

    /// <summary>
    /// Conversations handled
    /// </summary>
    public bool? KpiLivechatConversations { get; set; }

    /// <summary>
    /// Time to answer (sec)
    /// </summary>
    public bool? KpiLivechatResponse { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResUser> ResUsers { get; set; } = new List<ResUser>();
}
