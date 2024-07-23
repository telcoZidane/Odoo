using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mailing Contact
/// </summary>
public partial class MailingContact
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Bounce
    /// </summary>
    public int? MessageBounce { get; set; }

    /// <summary>
    /// Title
    /// </summary>
    public int? TitleId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Normalized Email
    /// </summary>
    public string? EmailNormalized { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Company Name
    /// </summary>
    public string? CompanyName { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Sanitized Number
    /// </summary>
    public string? PhoneSanitized { get; set; }

    /// <summary>
    /// Mobile
    /// </summary>
    public string? Mobile { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailingContactListRel> MailingContactListRels { get; set; } = new List<MailingContactListRel>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartnerTitle? Title { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MailingContactToList> MailingContactToLists { get; set; } = new List<MailingContactToList>();

    public virtual ICollection<ResPartnerCategory> ResPartnerCategories { get; set; } = new List<ResPartnerCategory>();
}
