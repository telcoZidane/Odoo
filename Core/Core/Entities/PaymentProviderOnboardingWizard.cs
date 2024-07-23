using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Payment provider onboarding wizard
/// </summary>
public partial class PaymentProviderOnboardingWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Payment Method
    /// </summary>
    public string? PaymentMethod { get; set; }

    /// <summary>
    /// Paypal User Type
    /// </summary>
    public string? PaypalUserType { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? PaypalEmailAccount { get; set; }

    /// <summary>
    /// Merchant Account ID
    /// </summary>
    public string? PaypalSellerAccount { get; set; }

    /// <summary>
    /// PDT Identity Token
    /// </summary>
    public string? PaypalPdtToken { get; set; }

    /// <summary>
    /// Method
    /// </summary>
    public string? ManualName { get; set; }

    /// <summary>
    /// Bank Name
    /// </summary>
    public string? JournalName { get; set; }

    /// <summary>
    /// Account Number
    /// </summary>
    public string? AccNumber { get; set; }

    /// <summary>
    /// Payment Instructions
    /// </summary>
    public string? ManualPostMsg { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
