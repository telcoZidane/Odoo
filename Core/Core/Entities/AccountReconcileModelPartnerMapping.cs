using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Partner mapping for reconciliation models
/// </summary>
public partial class AccountReconcileModelPartnerMapping
{
    public int Id { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int ModelId { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Find Text in Label
    /// </summary>
    public string? PaymentRefRegex { get; set; }

    /// <summary>
    /// Find Text in Notes
    /// </summary>
    public string? NarrationRegex { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountReconcileModel Model { get; set; } = null!;

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
