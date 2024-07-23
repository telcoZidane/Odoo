using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Payments
/// </summary>
public partial class AccountPayment
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Journal Entry
    /// </summary>
    public int MoveId { get; set; }

    /// <summary>
    /// Recipient Bank Account
    /// </summary>
    public int? PartnerBankId { get; set; }

    /// <summary>
    /// Paired Internal Transfer Payment
    /// </summary>
    public int? PairedInternalTransferPaymentId { get; set; }

    /// <summary>
    /// Payment Method
    /// </summary>
    public int? PaymentMethodLineId { get; set; }

    /// <summary>
    /// Method
    /// </summary>
    public int? PaymentMethodId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Customer/Vendor
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Outstanding Account
    /// </summary>
    public int? OutstandingAccountId { get; set; }

    /// <summary>
    /// Destination Account
    /// </summary>
    public int? DestinationAccountId { get; set; }

    /// <summary>
    /// Destination Journal
    /// </summary>
    public int? DestinationJournalId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Payment Type
    /// </summary>
    public string PaymentType { get; set; } = null!;

    /// <summary>
    /// Partner Type
    /// </summary>
    public string PartnerType { get; set; } = null!;

    /// <summary>
    /// Payment Reference
    /// </summary>
    public string? PaymentReference { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Amount Company Currency Signed
    /// </summary>
    public decimal? AmountCompanyCurrencySigned { get; set; }

    /// <summary>
    /// Is Reconciled
    /// </summary>
    public bool? IsReconciled { get; set; }

    /// <summary>
    /// Is Matched With a Bank Statement
    /// </summary>
    public bool? IsMatched { get; set; }

    /// <summary>
    /// Internal Transfer
    /// </summary>
    public bool? IsInternalTransfer { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Payment Transaction
    /// </summary>
    public int? PaymentTransactionId { get; set; }

    /// <summary>
    /// Saved Payment Token
    /// </summary>
    public int? PaymentTokenId { get; set; }

    /// <summary>
    /// Source Payment
    /// </summary>
    public int? SourcePaymentId { get; set; }

    /// <summary>
    /// POS Payment Method
    /// </summary>
    public int? PosPaymentMethodId { get; set; }

    /// <summary>
    /// Forced Outstanding Account
    /// </summary>
    public int? ForceOutstandingAccountId { get; set; }

    /// <summary>
    /// POS Session
    /// </summary>
    public int? PosSessionId { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountAccount? DestinationAccount { get; set; }

    public virtual AccountJournal? DestinationJournal { get; set; }

    public virtual AccountAccount? ForceOutstandingAccount { get; set; }

    public virtual ICollection<AccountPayment> InversePairedInternalTransferPayment { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountPayment> InverseSourcePayment { get; set; } = new List<AccountPayment>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual AccountMove Move { get; set; } = null!;

    public virtual AccountAccount? OutstandingAccount { get; set; }

    public virtual AccountPayment? PairedInternalTransferPayment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartnerBank? PartnerBank { get; set; }

    public virtual AccountPaymentMethod? PaymentMethod { get; set; }

    public virtual AccountPaymentMethodLine? PaymentMethodLine { get; set; }

    public virtual ICollection<PaymentRefundWizard> PaymentRefundWizards { get; set; } = new List<PaymentRefundWizard>();

    public virtual PaymentToken? PaymentToken { get; set; }

    public virtual PaymentTransaction? PaymentTransaction { get; set; }

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual PosPaymentMethod? PosPaymentMethod { get; set; }

    public virtual PosSession? PosSession { get; set; }

    public virtual AccountPayment? SourcePayment { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; set; } = new List<AccountBankStatementLine>();
}
