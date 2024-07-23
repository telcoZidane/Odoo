using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mailing Contact Import
/// </summary>
public partial class MailingContactImport
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
    /// Contact List
    /// </summary>
    public string? ContactList { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MailingList> MailingLists { get; set; } = new List<MailingList>();
}
