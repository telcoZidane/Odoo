using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Add Contacts to Mailing List
/// </summary>
public partial class MailingContactToList
{
    public int Id { get; set; }

    /// <summary>
    /// Mailing List
    /// </summary>
    public int MailingListId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailingList MailingList { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MailingContact> MailingContacts { get; set; } = new List<MailingContact>();
}
