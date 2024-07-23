using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Point of Sale Payments
/// </summary>
public partial class PosPayment
{
    public int Id { get; set; }

    /// <summary>
    /// Order
    /// </summary>
    public int PosOrderId { get; set; }

    /// <summary>
    /// Payment Method
    /// </summary>
    public int PaymentMethodId { get; set; }

    /// <summary>
    /// Session
    /// </summary>
    public int? SessionId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Account Move
    /// </summary>
    public int? AccountMoveId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Label
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Type of card used
    /// </summary>
    public string? CardType { get; set; }

    /// <summary>
    /// Cardholder Name
    /// </summary>
    public string? CardholderName { get; set; }

    /// <summary>
    /// Payment Transaction ID
    /// </summary>
    public string? TransactionId { get; set; }

    /// <summary>
    /// Payment Status
    /// </summary>
    public string? PaymentStatus { get; set; }

    /// <summary>
    /// Payment Receipt Info
    /// </summary>
    public string? Ticket { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Is this payment change?
    /// </summary>
    public bool? IsChange { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateTime PaymentDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual AccountMove? AccountMove { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual PosPaymentMethod PaymentMethod { get; set; } = null!;

    public virtual PosOrder PosOrder { get; set; } = null!;

    public virtual PosSession? Session { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
