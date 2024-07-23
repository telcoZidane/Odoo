using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Point of Sale Session
/// </summary>
public partial class PosSession
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Point of Sale
    /// </summary>
    public int ConfigId { get; set; }

    /// <summary>
    /// Opened By
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Order Sequence Number
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Login Sequence Number
    /// </summary>
    public int? LoginNumber { get; set; }

    /// <summary>
    /// Cash Journal
    /// </summary>
    public int? CashJournalId { get; set; }

    /// <summary>
    /// Journal Entry
    /// </summary>
    public int? MoveId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Session ID
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Opening Notes
    /// </summary>
    public string? OpeningNotes { get; set; }

    /// <summary>
    /// Ending Balance
    /// </summary>
    public decimal? CashRegisterBalanceEndReal { get; set; }

    /// <summary>
    /// Starting Balance
    /// </summary>
    public decimal? CashRegisterBalanceStart { get; set; }

    /// <summary>
    /// Transaction
    /// </summary>
    public decimal? CashRealTransaction { get; set; }

    /// <summary>
    /// Recovery Session
    /// </summary>
    public bool? Rescue { get; set; }

    /// <summary>
    /// Stock should be updated at closing
    /// </summary>
    public bool? UpdateStockAtClosing { get; set; }

    /// <summary>
    /// Opening Date
    /// </summary>
    public DateTime? StartAt { get; set; }

    /// <summary>
    /// Closing Date
    /// </summary>
    public DateTime? StopAt { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; set; } = new List<AccountBankStatementLine>();

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual AccountJournal? CashJournal { get; set; }

    public virtual PosConfig Config { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual AccountMove? Move { get; set; }

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<PosPayment> PosPayments { get; set; } = new List<PosPayment>();

    public virtual ICollection<StockPicking> StockPickings { get; set; } = new List<StockPicking>();

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
