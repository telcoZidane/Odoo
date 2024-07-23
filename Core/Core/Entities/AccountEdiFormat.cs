using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// EDI format
/// </summary>
public partial class AccountEdiFormat
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
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountEdiDocument> AccountEdiDocuments { get; set; } = new List<AccountEdiDocument>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();
}
