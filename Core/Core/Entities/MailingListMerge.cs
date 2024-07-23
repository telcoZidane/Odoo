using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Merge Mass Mailing List
/// </summary>
public partial class MailingListMerge
{
    public int Id { get; set; }

    /// <summary>
    /// Destination Mailing List
    /// </summary>
    public int? DestListId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Merge Option
    /// </summary>
    public string MergeOptions { get; set; } = null!;

    /// <summary>
    /// New Mailing List Name
    /// </summary>
    public string? NewListName { get; set; }

    /// <summary>
    /// Archive source mailing lists
    /// </summary>
    public bool? ArchiveSrcLists { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MailingList? DestList { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<MailingList> MailingLists { get; set; } = new List<MailingList>();
}
