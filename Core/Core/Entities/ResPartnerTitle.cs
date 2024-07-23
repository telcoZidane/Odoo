using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Partner Title
/// </summary>
public partial class ResPartnerTitle
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
    /// Title
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Abbreviation
    /// </summary>
    public string? Shortcut { get; set; }

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

    public virtual ICollection<MailingContact> MailingContacts { get; set; } = new List<MailingContact>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();

    public virtual ResUser? WriteU { get; set; }
}
