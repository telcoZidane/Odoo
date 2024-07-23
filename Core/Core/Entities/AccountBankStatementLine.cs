using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Bank Statement Line
/// </summary>
public partial class AccountBankStatementLine
{
    public int Id { get; set; }

    /// <summary>
    /// Journal Entry
    /// </summary>
    public int MoveId { get; set; }

    /// <summary>
    /// Statement
    /// </summary>
    public int? StatementId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Journal Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Foreign Currency
    /// </summary>
    public int? ForeignCurrencyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Bank Account Number
    /// </summary>
    public string? AccountNumber { get; set; }

    /// <summary>
    /// Partner Name
    /// </summary>
    public string? PartnerName { get; set; }

    /// <summary>
    /// Transaction Type
    /// </summary>
    public string? TransactionType { get; set; }

    /// <summary>
    /// Label
    /// </summary>
    public string? PaymentRef { get; set; }

    /// <summary>
    /// Internal Reference
    /// </summary>
    public string? InternalIndex { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Amount in Currency
    /// </summary>
    public decimal? AmountCurrency { get; set; }

    /// <summary>
    /// Is Reconciled
    /// </summary>
    public bool? IsReconciled { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Residual Amount
    /// </summary>
    public double? AmountResidual { get; set; }

    /// <summary>
    /// Session
    /// </summary>
    public int? PosSessionId { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResCurrency? ForeignCurrency { get; set; }

    public virtual AccountMove Move { get; set; } = null!;

    public virtual ResPartner? Partner { get; set; }

    public virtual PosSession? PosSession { get; set; }

    public virtual AccountBankStatement? Statement { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();
}
