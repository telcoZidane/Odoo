using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Point of Sale Make Payment Wizard
/// </summary>
public partial class PosMakePayment
{
    public int Id { get; set; }

    /// <summary>
    /// Point of Sale Configuration
    /// </summary>
    public int ConfigId { get; set; }

    /// <summary>
    /// Payment Method
    /// </summary>
    public int PaymentMethodId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Payment Reference
    /// </summary>
    public string? PaymentName { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Payment Date
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

    public virtual PosConfig Config { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual PosPaymentMethod PaymentMethod { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
