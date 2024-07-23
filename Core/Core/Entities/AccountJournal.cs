using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Journal
/// </summary>
public partial class AccountJournal
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Default Account
    /// </summary>
    public int? DefaultAccountId { get; set; }

    /// <summary>
    /// Suspense Account
    /// </summary>
    public int? SuspenseAccountId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Profit Account
    /// </summary>
    public int? ProfitAccountId { get; set; }

    /// <summary>
    /// Loss Account
    /// </summary>
    public int? LossAccountId { get; set; }

    /// <summary>
    /// Bank Account
    /// </summary>
    public int? BankAccountId { get; set; }

    /// <summary>
    /// Schedule Activity
    /// </summary>
    public int? SaleActivityTypeId { get; set; }

    /// <summary>
    /// Activity User
    /// </summary>
    public int? SaleActivityUserId { get; set; }

    /// <summary>
    /// Email Alias
    /// </summary>
    public int? AliasId { get; set; }

    /// <summary>
    /// Secure Sequence
    /// </summary>
    public int? SecureSequenceId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Journal Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Short Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Communication Type
    /// </summary>
    public string InvoiceReferenceType { get; set; } = null!;

    /// <summary>
    /// Communication Standard
    /// </summary>
    public string InvoiceReferenceModel { get; set; } = null!;

    /// <summary>
    /// Bank Feeds
    /// </summary>
    public string? BankStatementsSource { get; set; }

    /// <summary>
    /// Sequence Override Regex
    /// </summary>
    public string? SequenceOverrideRegex { get; set; }

    /// <summary>
    /// Activity Summary
    /// </summary>
    public string? SaleActivityNote { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Lock Posted Entries with Hash
    /// </summary>
    public bool? RestrictModeHashTable { get; set; }

    /// <summary>
    /// Dedicated Credit Note Sequence
    /// </summary>
    public bool? RefundSequence { get; set; }

    /// <summary>
    /// Dedicated Payment Sequence
    /// </summary>
    public bool? PaymentSequence { get; set; }

    /// <summary>
    /// Show journal on dashboard
    /// </summary>
    public bool? ShowOnDashboard { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountBankStatement> AccountBankStatements { get; set; } = new List<AccountBankStatement>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMoveReversal> AccountMoveReversals { get; set; } = new List<AccountMoveReversal>();

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLines { get; set; } = new List<AccountPaymentMethodLine>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; set; } = new List<AccountReconcileModelLine>();

    public virtual MailAlias? Alias { get; set; }

    public virtual ResPartnerBank? BankAccount { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountAccount? DefaultAccount { get; set; }

    public virtual ICollection<HrExpenseSheet> HrExpenseSheetBankJournals { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheetJournals { get; set; } = new List<HrExpenseSheet>();

    public virtual AccountAccount? LossAccount { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<PosConfig> PosConfigInvoiceJournals { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosConfig> PosConfigJournals { get; set; } = new List<PosConfig>();

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ICollection<PosPaymentMethod> PosPaymentMethods { get; set; } = new List<PosPaymentMethod>();

    public virtual ICollection<PosSession> PosSessions { get; set; } = new List<PosSession>();

    public virtual AccountAccount? ProfitAccount { get; set; }

    public virtual ICollection<ResCompany> ResCompanyAutomaticEntryDefaultJournals { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyCompanyExpenseJournals { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyCurrencyExchangeJournals { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyExpenseJournals { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyTaxCashBasisJournals { get; set; } = new List<ResCompany>();

    public virtual MailActivityType? SaleActivityType { get; set; }

    public virtual ResUser? SaleActivityUser { get; set; }

    public virtual IrSequence? SecureSequence { get; set; }

    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; set; } = new List<StockValuationLayerRevaluation>();

    public virtual AccountAccount? SuspenseAccount { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccount> AccountAccounts { get; set; } = new List<AccountAccount>();

    public virtual ICollection<AccountEdiFormat> AccountEdiFormats { get; set; } = new List<AccountEdiFormat>();

    public virtual ICollection<AccountJournalGroup> AccountJournalGroups { get; set; } = new List<AccountJournalGroup>();

    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; set; } = new List<AccountReconcileModelTemplate>();

    public virtual ICollection<AccountReconcileModel> AccountReconcileModels { get; set; } = new List<AccountReconcileModel>();

    public virtual ICollection<AccountAccount> Accounts { get; set; } = new List<AccountAccount>();
}
