using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Generate Payment Link
/// </summary>
public partial class PaymentLinkWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Related Document ID
    /// </summary>
    public int ResId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Related Document Model
    /// </summary>
    public string ResModel { get; set; } = null!;

    /// <summary>
    /// Payment Ref
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Allow Payment Provider
    /// </summary>
    public string PaymentProviderSelection { get; set; } = null!;

    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Amount Max
    /// </summary>
    public decimal? AmountMax { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
