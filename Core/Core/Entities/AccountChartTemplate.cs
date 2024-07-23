using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Account Chart Template
/// </summary>
public partial class AccountChartTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Parent Chart Template
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// # of Digits
    /// </summary>
    public int CodeDigits { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int CurrencyId { get; set; }

    /// <summary>
    /// Gain Exchange Rate Account
    /// </summary>
    public int? IncomeCurrencyExchangeAccountId { get; set; }

    /// <summary>
    /// Loss Exchange Rate Account
    /// </summary>
    public int? ExpenseCurrencyExchangeAccountId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Journal Suspense Account
    /// </summary>
    public int? AccountJournalSuspenseAccountId { get; set; }

    /// <summary>
    /// Journal Outstanding Receipts Account
    /// </summary>
    public int? AccountJournalPaymentDebitAccountId { get; set; }

    /// <summary>
    /// Journal Outstanding Payments Account
    /// </summary>
    public int? AccountJournalPaymentCreditAccountId { get; set; }

    /// <summary>
    /// Cash Difference Income Account
    /// </summary>
    public int? DefaultCashDifferenceIncomeAccountId { get; set; }

    /// <summary>
    /// Cash Difference Expense Account
    /// </summary>
    public int? DefaultCashDifferenceExpenseAccountId { get; set; }

    /// <summary>
    /// PoS receivable account
    /// </summary>
    public int? DefaultPosReceivableAccountId { get; set; }

    /// <summary>
    /// Cash Discount Write-Off Loss Account
    /// </summary>
    public int? AccountJournalEarlyPayDiscountLossAccountId { get; set; }

    /// <summary>
    /// Cash Discount Write-Off Gain Account
    /// </summary>
    public int? AccountJournalEarlyPayDiscountGainAccountId { get; set; }

    /// <summary>
    /// Receivable Account
    /// </summary>
    public int? PropertyAccountReceivableId { get; set; }

    /// <summary>
    /// Payable Account
    /// </summary>
    public int? PropertyAccountPayableId { get; set; }

    /// <summary>
    /// Category of Expense Account
    /// </summary>
    public int? PropertyAccountExpenseCategId { get; set; }

    /// <summary>
    /// Category of Income Account
    /// </summary>
    public int? PropertyAccountIncomeCategId { get; set; }

    /// <summary>
    /// Expense Account on Product Template
    /// </summary>
    public int? PropertyAccountExpenseId { get; set; }

    /// <summary>
    /// Income Account on Product Template
    /// </summary>
    public int? PropertyAccountIncomeId { get; set; }

    /// <summary>
    /// Input Account for Stock Valuation
    /// </summary>
    public int? PropertyStockAccountInputCategId { get; set; }

    /// <summary>
    /// Output Account for Stock Valuation
    /// </summary>
    public int? PropertyStockAccountOutputCategId { get; set; }

    /// <summary>
    /// Account Template for Stock Valuation
    /// </summary>
    public int? PropertyStockValuationAccountId { get; set; }

    /// <summary>
    /// Tax current account (payable)
    /// </summary>
    public int? PropertyTaxPayableAccountId { get; set; }

    /// <summary>
    /// Tax current account (receivable)
    /// </summary>
    public int? PropertyTaxReceivableAccountId { get; set; }

    /// <summary>
    /// Advance tax payment account
    /// </summary>
    public int? PropertyAdvanceTaxPaymentAccountId { get; set; }

    /// <summary>
    /// Base Tax Received Account
    /// </summary>
    public int? PropertyCashBasisBaseAccountId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Prefix of the bank accounts
    /// </summary>
    public string BankAccountCodePrefix { get; set; } = null!;

    /// <summary>
    /// Prefix of the main cash accounts
    /// </summary>
    public string CashAccountCodePrefix { get; set; } = null!;

    /// <summary>
    /// Prefix of the main transfer accounts
    /// </summary>
    public string TransferAccountCodePrefix { get; set; } = null!;

    /// <summary>
    /// Can be Visible?
    /// </summary>
    public bool? Visible { get; set; }

    /// <summary>
    /// Use Anglo-Saxon accounting
    /// </summary>
    public bool? UseAngloSaxon { get; set; }

    /// <summary>
    /// Use Storno accounting
    /// </summary>
    public bool? UseStornoAccounting { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; set; } = new List<AccountAccountTemplate>();

    public virtual ICollection<AccountFiscalPositionTemplate> AccountFiscalPositionTemplates { get; set; } = new List<AccountFiscalPositionTemplate>();

    public virtual ICollection<AccountGroupTemplate> AccountGroupTemplates { get; set; } = new List<AccountGroupTemplate>();

    public virtual AccountAccountTemplate? AccountJournalEarlyPayDiscountGainAccount { get; set; }

    public virtual AccountAccountTemplate? AccountJournalEarlyPayDiscountLossAccount { get; set; }

    public virtual AccountAccountTemplate? AccountJournalPaymentCreditAccount { get; set; }

    public virtual AccountAccountTemplate? AccountJournalPaymentDebitAccount { get; set; }

    public virtual AccountAccountTemplate? AccountJournalSuspenseAccount { get; set; }

    public virtual ICollection<AccountReconcileModelTemplate> AccountReconcileModelTemplates { get; set; } = new List<AccountReconcileModelTemplate>();

    public virtual ICollection<AccountReport> AccountReports { get; set; } = new List<AccountReport>();

    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; set; } = new List<AccountTaxTemplate>();

    public virtual ResCountry? Country { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency Currency { get; set; } = null!;

    public virtual AccountAccountTemplate? DefaultCashDifferenceExpenseAccount { get; set; }

    public virtual AccountAccountTemplate? DefaultCashDifferenceIncomeAccount { get; set; }

    public virtual AccountAccountTemplate? DefaultPosReceivableAccount { get; set; }

    public virtual AccountAccountTemplate? ExpenseCurrencyExchangeAccount { get; set; }

    public virtual AccountAccountTemplate? IncomeCurrencyExchangeAccount { get; set; }

    public virtual ICollection<AccountChartTemplate> InverseParent { get; set; } = new List<AccountChartTemplate>();

    public virtual AccountChartTemplate? Parent { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountExpense { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountExpenseCateg { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountIncome { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountIncomeCateg { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountPayable { get; set; }

    public virtual AccountAccountTemplate? PropertyAccountReceivable { get; set; }

    public virtual AccountAccountTemplate? PropertyAdvanceTaxPaymentAccount { get; set; }

    public virtual AccountAccountTemplate? PropertyCashBasisBaseAccount { get; set; }

    public virtual AccountAccountTemplate? PropertyStockAccountInputCateg { get; set; }

    public virtual AccountAccountTemplate? PropertyStockAccountOutputCateg { get; set; }

    public virtual AccountAccountTemplate? PropertyStockValuationAccount { get; set; }

    public virtual AccountAccountTemplate? PropertyTaxPayableAccount { get; set; }

    public virtual AccountAccountTemplate? PropertyTaxReceivableAccount { get; set; }

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();

    public virtual ResUser? WriteU { get; set; }
}
