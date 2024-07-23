using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Partial Reconcile
/// </summary>
public partial class AccountPartialReconcile
{
    public int Id { get; set; }

    /// <summary>
    /// Debit Move
    /// </summary>
    public int DebitMoveId { get; set; }

    /// <summary>
    /// Credit Move
    /// </summary>
    public int CreditMoveId { get; set; }

    /// <summary>
    /// Full Reconcile
    /// </summary>
    public int? FullReconcileId { get; set; }

    /// <summary>
    /// Exchange Move
    /// </summary>
    public int? ExchangeMoveId { get; set; }

    /// <summary>
    /// Currency of the debit journal item.
    /// </summary>
    public int? DebitCurrencyId { get; set; }

    /// <summary>
    /// Currency of the credit journal item.
    /// </summary>
    public int? CreditCurrencyId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Max Date of Matched Lines
    /// </summary>
    public DateOnly? MaxDate { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Debit Amount Currency
    /// </summary>
    public decimal? DebitAmountCurrency { get; set; }

    /// <summary>
    /// Credit Amount Currency
    /// </summary>
    public decimal? CreditAmountCurrency { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? CreditCurrency { get; set; }

    public virtual AccountMoveLine CreditMove { get; set; } = null!;

    public virtual ResCurrency? DebitCurrency { get; set; }

    public virtual AccountMoveLine DebitMove { get; set; } = null!;

    public virtual AccountMove? ExchangeMove { get; set; }

    public virtual AccountFullReconcile? FullReconcile { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
