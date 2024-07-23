using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Register Payment
/// </summary>
public partial class AccountPaymentRegister
{
    public int Id { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Journal
    /// </summary>
    public int? JournalId { get; set; }

    /// <summary>
    /// Recipient Bank Account
    /// </summary>
    public int? PartnerBankId { get; set; }

    /// <summary>
    /// Source Currency
    /// </summary>
    public int? SourceCurrencyId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Customer/Vendor
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Payment Method
    /// </summary>
    public int? PaymentMethodLineId { get; set; }

    /// <summary>
    /// Difference Account
    /// </summary>
    public int? WriteoffAccountId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Memo
    /// </summary>
    public string? Communication { get; set; }

    /// <summary>
    /// Payment Type
    /// </summary>
    public string? PaymentType { get; set; }

    /// <summary>
    /// Partner Type
    /// </summary>
    public string? PartnerType { get; set; }

    /// <summary>
    /// Payment Difference Handling
    /// </summary>
    public string? PaymentDifferenceHandling { get; set; }

    /// <summary>
    /// Journal Item Label
    /// </summary>
    public string? WriteoffLabel { get; set; }

    /// <summary>
    /// Payment Date
    /// </summary>
    public DateOnly PaymentDate { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Amount to Pay (company currency)
    /// </summary>
    public decimal? SourceAmount { get; set; }

    /// <summary>
    /// Amount to Pay (foreign currency)
    /// </summary>
    public decimal? SourceAmountCurrency { get; set; }

    /// <summary>
    /// Group Payments
    /// </summary>
    public bool? GroupPayment { get; set; }

    /// <summary>
    /// Can Edit Wizard
    /// </summary>
    public bool? CanEditWizard { get; set; }

    /// <summary>
    /// Can Group Payments
    /// </summary>
    public bool? CanGroupPayments { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Saved payment token
    /// </summary>
    public int? PaymentTokenId { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartnerBank? PartnerBank { get; set; }

    public virtual AccountPaymentMethodLine? PaymentMethodLine { get; set; }

    public virtual PaymentToken? PaymentToken { get; set; }

    public virtual ResCurrency? SourceCurrency { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual AccountAccount? WriteoffAccount { get; set; }

    public virtual ICollection<AccountMoveLine> Lines { get; set; } = new List<AccountMoveLine>();
}
