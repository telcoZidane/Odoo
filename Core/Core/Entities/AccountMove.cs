using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Journal Entry
/// </summary>
public partial class AccountMove
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence Number
    /// </summary>
    public int? SequenceNumber { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Journal
    /// </summary>
    public int JournalId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Payment
    /// </summary>
    public int? PaymentId { get; set; }

    /// <summary>
    /// Statement Line
    /// </summary>
    public int? StatementLineId { get; set; }

    /// <summary>
    /// Tax Cash Basis Entry of
    /// </summary>
    public int? TaxCashBasisRecId { get; set; }

    /// <summary>
    /// Cash Basis Origin
    /// </summary>
    public int? TaxCashBasisOriginMoveId { get; set; }

    /// <summary>
    /// First recurring entry
    /// </summary>
    public int? AutoPostOriginId { get; set; }

    /// <summary>
    /// Inalteralbility No Gap Sequence #
    /// </summary>
    public int? SecureSequenceNumber { get; set; }

    /// <summary>
    /// Payment Terms
    /// </summary>
    public int? InvoicePaymentTermId { get; set; }

    /// <summary>
    /// Partner
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Commercial Entity
    /// </summary>
    public int? CommercialPartnerId { get; set; }

    /// <summary>
    /// Delivery Address
    /// </summary>
    public int? PartnerShippingId { get; set; }

    /// <summary>
    /// Recipient Bank
    /// </summary>
    public int? PartnerBankId { get; set; }

    /// <summary>
    /// Fiscal Position
    /// </summary>
    public int? FiscalPositionId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Reversal of
    /// </summary>
    public int? ReversedEntryId { get; set; }

    /// <summary>
    /// Salesperson
    /// </summary>
    public int? InvoiceUserId { get; set; }

    /// <summary>
    /// Incoterm
    /// </summary>
    public int? InvoiceIncotermId { get; set; }

    /// <summary>
    /// Cash Rounding Method
    /// </summary>
    public int? InvoiceCashRoundingId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Sequence Prefix
    /// </summary>
    public string? SequencePrefix { get; set; }

    /// <summary>
    /// Security Token
    /// </summary>
    public string? AccessToken { get; set; }

    /// <summary>
    /// Number
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public string? Ref { get; set; }

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string MoveType { get; set; } = null!;

    /// <summary>
    /// Auto-post
    /// </summary>
    public string AutoPost { get; set; } = null!;

    /// <summary>
    /// Inalterability Hash
    /// </summary>
    public string? InalterableHash { get; set; }

    /// <summary>
    /// Payment Reference
    /// </summary>
    public string? PaymentReference { get; set; }

    /// <summary>
    /// Payment QR-code
    /// </summary>
    public string? QrCodeMethod { get; set; }

    /// <summary>
    /// Payment Status
    /// </summary>
    public string? PaymentState { get; set; }

    /// <summary>
    /// Source Email
    /// </summary>
    public string? InvoiceSourceEmail { get; set; }

    /// <summary>
    /// Invoice Partner Display Name
    /// </summary>
    public string? InvoicePartnerDisplayName { get; set; }

    /// <summary>
    /// Origin
    /// </summary>
    public string? InvoiceOrigin { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Auto-post until
    /// </summary>
    public DateOnly? AutoPostUntil { get; set; }

    /// <summary>
    /// Invoice/Bill Date
    /// </summary>
    public DateOnly? InvoiceDate { get; set; }

    /// <summary>
    /// Due Date
    /// </summary>
    public DateOnly? InvoiceDateDue { get; set; }

    /// <summary>
    /// Terms and Conditions
    /// </summary>
    public string? Narration { get; set; }

    /// <summary>
    /// Untaxed Amount
    /// </summary>
    public decimal? AmountUntaxed { get; set; }

    /// <summary>
    /// Tax
    /// </summary>
    public decimal? AmountTax { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public decimal? AmountTotal { get; set; }

    /// <summary>
    /// Amount Due
    /// </summary>
    public decimal? AmountResidual { get; set; }

    /// <summary>
    /// Untaxed Amount Signed
    /// </summary>
    public decimal? AmountUntaxedSigned { get; set; }

    /// <summary>
    /// Tax Signed
    /// </summary>
    public decimal? AmountTaxSigned { get; set; }

    /// <summary>
    /// Total Signed
    /// </summary>
    public decimal? AmountTotalSigned { get; set; }

    /// <summary>
    /// Total in Currency Signed
    /// </summary>
    public decimal? AmountTotalInCurrencySigned { get; set; }

    /// <summary>
    /// Amount Due Signed
    /// </summary>
    public decimal? AmountResidualSigned { get; set; }

    /// <summary>
    /// Total (Tax inc.)
    /// </summary>
    public decimal? QuickEditTotalAmount { get; set; }

    /// <summary>
    /// Is Storno
    /// </summary>
    public bool? IsStorno { get; set; }

    /// <summary>
    /// Always Tax Exigible
    /// </summary>
    public bool? AlwaysTaxExigible { get; set; }

    /// <summary>
    /// To Check
    /// </summary>
    public bool? ToCheck { get; set; }

    /// <summary>
    /// Posted Before
    /// </summary>
    public bool? PostedBefore { get; set; }

    /// <summary>
    /// Is Move Sent
    /// </summary>
    public bool? IsMoveSent { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Electronic invoicing
    /// </summary>
    public string? EdiState { get; set; }

    /// <summary>
    /// Campaign
    /// </summary>
    public int? CampaignId { get; set; }

    /// <summary>
    /// Source
    /// </summary>
    public int? SourceId { get; set; }

    /// <summary>
    /// Medium
    /// </summary>
    public int? MediumId { get; set; }

    /// <summary>
    /// Sales Team
    /// </summary>
    public int? TeamId { get; set; }

    /// <summary>
    /// Stock Move
    /// </summary>
    public int? StockMoveId { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLines { get; set; } = new List<AccountBankStatementLine>();

    public virtual ICollection<AccountEdiDocument> AccountEdiDocuments { get; set; } = new List<AccountEdiDocument>();

    public virtual ICollection<AccountFullReconcile> AccountFullReconciles { get; set; } = new List<AccountFullReconcile>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; set; } = new List<AccountPartialReconcile>();

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual AccountMove? AutoPostOrigin { get; set; }

    public virtual UtmCampaign? Campaign { get; set; }

    public virtual ResPartner? CommercialPartner { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual AccountFiscalPosition? FiscalPosition { get; set; }

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<AccountMove> InverseAutoPostOrigin { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountMove> InverseReversedEntry { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountMove> InverseTaxCashBasisOriginMove { get; set; } = new List<AccountMove>();

    public virtual AccountCashRounding? InvoiceCashRounding { get; set; }

    public virtual AccountIncoterm? InvoiceIncoterm { get; set; }

    public virtual AccountPaymentTerm? InvoicePaymentTerm { get; set; }

    public virtual ResUser? InvoiceUser { get; set; }

    public virtual AccountJournal Journal { get; set; } = null!;

    public virtual UtmMedium? Medium { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual ResPartnerBank? PartnerBank { get; set; }

    public virtual ResPartner? PartnerShipping { get; set; }

    public virtual AccountPayment? Payment { get; set; }

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<PosPayment> PosPayments { get; set; } = new List<PosPayment>();

    public virtual ICollection<PosSession> PosSessions { get; set; } = new List<PosSession>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual AccountMove? ReversedEntry { get; set; }

    public virtual UtmSource? Source { get; set; }

    public virtual AccountBankStatementLine? StatementLine { get; set; }

    public virtual StockMove? StockMove { get; set; }

    public virtual ICollection<StockValuationLayer> StockValuationLayers { get; set; } = new List<StockValuationLayer>();

    public virtual AccountMove? TaxCashBasisOriginMove { get; set; }

    public virtual AccountPartialReconcile? TaxCashBasisRec { get; set; }

    public virtual CrmTeam? Team { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountInvoiceSend> AccountInvoiceSends { get; set; } = new List<AccountInvoiceSend>();

    public virtual ICollection<AccountResequenceWizard> AccountResequenceWizards { get; set; } = new List<AccountResequenceWizard>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<AccountMoveReversal> Reversals { get; set; } = new List<AccountMoveReversal>();

    public virtual ICollection<AccountMoveReversal> ReversalsNavigation { get; set; } = new List<AccountMoveReversal>();

    public virtual ICollection<PaymentTransaction> Transactions { get; set; } = new List<PaymentTransaction>();
}
