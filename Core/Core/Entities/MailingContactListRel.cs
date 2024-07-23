using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mass Mailing Subscription Information
/// </summary>
public partial class MailingContactListRel
{
    public int Id { get; set; }

    /// <summary>
    /// Contact
    /// </summary>
    public int ContactId { get; set; }

    /// <summary>
    /// Mailing List
    /// </summary>
    public int ListId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Opt Out
    /// </summary>
    public bool? OptOut { get; set; }

    /// <summary>
    /// Unsubscription Date
    /// </summary>
    public DateTime? UnsubscriptionDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual MailingContact Contact { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual MailingList List { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
