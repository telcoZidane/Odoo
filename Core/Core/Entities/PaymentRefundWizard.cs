using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Payment Refund Wizard
/// </summary>
public partial class PaymentRefundWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Payment
    /// </summary>
    public int? PaymentId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Refund Amount
    /// </summary>
    public decimal? AmountToRefund { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
