using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Payment Transaction
/// </summary>
public partial class PaymentTransaction
{
    public int Id { get; set; }

    /// <summary>
    /// Provider
    /// </summary>
    public int ProviderId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Payment Token
    /// </summary>
    public int? TokenId { get; set; }

    /// <summary>
    /// Source Transaction
    /// </summary>
    public int? SourceTransactionId { get; set; }

    /// <summary>
    /// Callback Document Model
    /// </summary>
    public int? CallbackModelId { get; set; }

    /// <summary>
    /// Callback Record ID
    /// </summary>
    public int? CallbackResId { get; set; }

    /// <summary>
    /// Customer
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// State
    /// </summary>
    public int? PartnerStateId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? PartnerCountryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public string Reference { get; set; } = null!;

    /// <summary>
    /// Provider Reference
    /// </summary>
    public string? ProviderReference { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Operation
    /// </summary>
    public string? Operation { get; set; }

    /// <summary>
    /// Landing Route
    /// </summary>
    public string? LandingRoute { get; set; }

    /// <summary>
    /// Callback Method
    /// </summary>
    public string? CallbackMethod { get; set; }

    /// <summary>
    /// Callback Hash
    /// </summary>
    public string? CallbackHash { get; set; }

    /// <summary>
    /// Partner Name
    /// </summary>
    public string? PartnerName { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string? PartnerLang { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? PartnerEmail { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public string? PartnerAddress { get; set; }

    /// <summary>
    /// Zip
    /// </summary>
    public string? PartnerZip { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? PartnerCity { get; set; }

    /// <summary>
    /// Phone
    /// </summary>
    public string? PartnerPhone { get; set; }

    /// <summary>
    /// Message
    /// </summary>
    public string? StateMessage { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Fees
    /// </summary>
    public decimal? Fees { get; set; }

    /// <summary>
    /// Is Post-processed
    /// </summary>
    public bool? IsPostProcessed { get; set; }

    /// <summary>
    /// Create Token
    /// </summary>
    public bool? Tokenize { get; set; }

    /// <summary>
    /// Callback Done
    /// </summary>
    public bool? CallbackIsDone { get; set; }

    /// <summary>
    /// Last State Change Date
    /// </summary>
    public DateTime? LastStateChange { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Payment
    /// </summary>
    public int? PaymentId { get; set; }

    /// <summary>
    /// Is donation
    /// </summary>
    public bool? IsDonation { get; set; }

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual IrModel? CallbackModel { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual ICollection<PaymentTransaction> InverseSourceTransaction { get; set; } = new List<PaymentTransaction>();

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResCountry? PartnerCountry { get; set; }

    public virtual ResCountryState? PartnerState { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual PaymentProvider Provider { get; set; } = null!;

    public virtual PaymentTransaction? SourceTransaction { get; set; }

    public virtual PaymentToken? Token { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMove> Invoices { get; set; } = new List<AccountMove>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();
}
