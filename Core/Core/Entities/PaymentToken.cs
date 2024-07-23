using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Payment Token
/// </summary>
public partial class PaymentToken
{
    public int Id { get; set; }

    /// <summary>
    /// Provider
    /// </summary>
    public int ProviderId { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int PartnerId { get; set; }

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
    /// Payment Details
    /// </summary>
    public string? PaymentDetails { get; set; }

    /// <summary>
    /// Provider Reference
    /// </summary>
    public string ProviderRef { get; set; } = null!;

    /// <summary>
    /// Verified
    /// </summary>
    public bool? Verified { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual PaymentProvider Provider { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
