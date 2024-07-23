using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Bank Statement
/// </summary>
public partial class AccountBankStatement
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Journal
    /// </summary>
    public int? JournalId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// External Reference
    /// </summary>
    public string? Reference { get; set; }

    /// <summary>
    /// First Line Index
    /// </summary>
    public string? FirstLineIndex { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Starting Balance
    /// </summary>
    public decimal? BalanceStart { get; set; }

    /// <summary>
    /// Computed Balance
    /// </summary>
    public decimal? BalanceEnd { get; set; }

    /// <summary>
    /// Ending Balance
    /// </summary>
    public decimal? BalanceEndReal { get; set; }

    /// <summary>
    /// Is Complete
    /// </summary>
    public bool? IsComplete { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; set; } = new List<AccountBankStatementLine>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrAttachment> IrAttachments { get; set; } = new List<IrAttachment>();
}
