using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Merge Partner Wizard
/// </summary>
public partial class BasePartnerMergeAutomaticWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Group of Contacts
    /// </summary>
    public int? NumberGroup { get; set; }

    /// <summary>
    /// Current Line
    /// </summary>
    public int? CurrentLineId { get; set; }

    /// <summary>
    /// Destination Contact
    /// </summary>
    public int? DstPartnerId { get; set; }

    /// <summary>
    /// Maximum of Group of Contacts
    /// </summary>
    public int? MaximumGroup { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Email
    /// </summary>
    public bool? GroupByEmail { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public bool? GroupByName { get; set; }

    /// <summary>
    /// Is Company
    /// </summary>
    public bool? GroupByIsCompany { get; set; }

    /// <summary>
    /// VAT
    /// </summary>
    public bool? GroupByVat { get; set; }

    /// <summary>
    /// Parent Company
    /// </summary>
    public bool? GroupByParentId { get; set; }

    /// <summary>
    /// A user associated to the contact
    /// </summary>
    public bool? ExcludeContact { get; set; }

    /// <summary>
    /// Journal Items associated to the contact
    /// </summary>
    public bool? ExcludeJournalItem { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<BasePartnerMergeLine> BasePartnerMergeLines { get; set; } = new List<BasePartnerMergeLine>();

    public virtual ResUser? CreateU { get; set; }

    public virtual BasePartnerMergeLine? CurrentLine { get; set; }

    public virtual ResPartner? DstPartner { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();
}
