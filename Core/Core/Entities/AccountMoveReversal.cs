using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Account Move Reversal
/// </summary>
public partial class AccountMoveReversal
{
    public int Id { get; set; }

    /// <summary>
    /// Use Specific Journal
    /// </summary>
    public int JournalId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Date Mode
    /// </summary>
    public string DateMode { get; set; } = null!;

    /// <summary>
    /// Reason
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// Credit Method
    /// </summary>
    public string RefundMethod { get; set; } = null!;

    /// <summary>
    /// Reversal date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal Journal { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMove> Moves { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountMove> NewMoves { get; set; } = new List<AccountMove>();
}
