using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Account
/// </summary>
public partial class AccountAccount
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Account Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Root
    /// </summary>
    public int? RootId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Account Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string AccountType { get; set; } = null!;

    /// <summary>
    /// Internal Group
    /// </summary>
    public string? InternalGroup { get; set; }

    /// <summary>
    /// Internal Notes
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Deprecated
    /// </summary>
    public bool? Deprecated { get; set; }

    /// <summary>
    /// Bring Accounts Balance Forward
    /// </summary>
    public bool? IncludeInitialBalance { get; set; }

    /// <summary>
    /// Allow Reconciliation
    /// </summary>
    public bool? Reconcile { get; set; }

    /// <summary>
    /// Is Off Balance
    /// </summary>
    public bool? IsOffBalance { get; set; }

    /// <summary>
    /// Non Trade
    /// </summary>
    public bool? NonTrade { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizards { get; set; } = new List<AccountAccruedOrdersWizard>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountAutomaticEntryWizard> AccountAutomaticEntryWizards { get; set; } = new List<AccountAutomaticEntryWizard>();

    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountAccountDests { get; set; } = new List<AccountFiscalPositionAccount>();

    public virtual ICollection<AccountFiscalPositionAccount> AccountFiscalPositionAccountAccountSrcs { get; set; } = new List<AccountFiscalPositionAccount>();

    public virtual ICollection<AccountJournal> AccountJournalDefaultAccounts { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountJournal> AccountJournalLossAccounts { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountJournal> AccountJournalProfitAccounts { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountJournal> AccountJournalSuspenseAccounts { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountPayment> AccountPaymentDestinationAccounts { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountPayment> AccountPaymentForceOutstandingAccounts { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountPaymentMethodLine> AccountPaymentMethodLines { get; set; } = new List<AccountPaymentMethodLine>();

    public virtual ICollection<AccountPayment> AccountPaymentOutstandingAccounts { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; set; } = new List<AccountReconcileModelLine>();

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLines { get; set; } = new List<AccountTaxRepartitionLine>();

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountGroup? Group { get; set; }

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ICollection<PosCloseSessionWizard> PosCloseSessionWizards { get; set; } = new List<PosCloseSessionWizard>();

    public virtual ICollection<PosPaymentMethod> PosPaymentMethodOutstandingAccounts { get; set; } = new List<PosPaymentMethod>();

    public virtual ICollection<PosPaymentMethod> PosPaymentMethodReceivableAccounts { get; set; } = new List<PosPaymentMethod>();

    public virtual ICollection<ResCompany> ResCompanyAccountCashBasisBaseAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountDefaultPosReceivableAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalEarlyPayDiscountGainAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalEarlyPayDiscountLossAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalPaymentCreditAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalPaymentDebitAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountJournalSuspenseAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyDefaultCashDifferenceExpenseAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyDefaultCashDifferenceIncomeAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyExpenseAccrualAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyExpenseCurrencyExchangeAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyIncomeCurrencyExchangeAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyPropertyStockAccountInputCategs { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyPropertyStockAccountOutputCategs { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyPropertyStockValuationAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyRevenueAccrualAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyTransferAccounts { get; set; } = new List<ResCompany>();

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; set; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<StockLocation> StockLocationValuationInAccounts { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockLocation> StockLocationValuationOutAccounts { get; set; } = new List<StockLocation>();

    public virtual ICollection<StockValuationLayerRevaluation> StockValuationLayerRevaluations { get; set; } = new List<StockValuationLayerRevaluation>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccountTag> AccountAccountTags { get; set; } = new List<AccountAccountTag>();

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountJournal> Journals { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountTax> Taxes { get; set; } = new List<AccountTax>();
}
