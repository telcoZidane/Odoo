using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Remake the sequence of Journal Entries.
/// </summary>
public partial class AccountResequenceWizard
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
    /// First New Sequence
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Ordering
    /// </summary>
    public string Ordering { get; set; } = null!;

    /// <summary>
    /// First Date
    /// </summary>
    public DateOnly? FirstDate { get; set; }

    /// <summary>
    /// End Date
    /// </summary>
    public DateOnly? EndDate { get; set; }

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

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();
}
