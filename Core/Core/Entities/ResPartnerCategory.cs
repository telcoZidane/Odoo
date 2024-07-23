using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Partner Tags
/// </summary>
public partial class ResPartnerCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Color
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Parent Category
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Parent Path
    /// </summary>
    public string? ParentPath { get; set; }

    /// <summary>
    /// Tag Name
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

    public virtual ICollection<AccountAnalyticDistributionModel> AccountAnalyticDistributionModels { get; set; } = new List<AccountAnalyticDistributionModel>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResPartnerCategory> InverseParent { get; set; } = new List<ResPartnerCategory>();

    public virtual ResPartnerCategory? Parent { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; set; } = new List<AccountReconcileModelTemplate>();

    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; set; } = new List<AccountReconcileModel>();

    public virtual ICollection<MailingContact> MailingContacts { get; set; } = new List<MailingContact>();

    public virtual ICollection<ResPartner> Partners { get; set; } = new List<ResPartner>();
}
