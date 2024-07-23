using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Mailing List
/// </summary>
public partial class MailingList
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
    /// Mailing List
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Show In Preferences
    /// </summary>
    public bool? IsPublic { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<MailingContactListRel> MailingContactListRels { get; set; } = new List<MailingContactListRel>();

    public virtual ICollection<MailingContactToList> MailingContactToLists { get; set; } = new List<MailingContactToList>();

    public virtual ICollection<MailingListMerge> MailingListMergesNavigation { get; set; } = new List<MailingListMerge>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MailComposeMessage> MailComposeMessages { get; set; } = new List<MailComposeMessage>();

    public virtual ICollection<MailingContactImport> MailingContactImports { get; set; } = new List<MailingContactImport>();

    public virtual ICollection<MailingListMerge> MailingListMerges { get; set; } = new List<MailingListMerge>();

    public virtual ICollection<MailingMailing> MailingMailings { get; set; } = new List<MailingMailing>();
}
