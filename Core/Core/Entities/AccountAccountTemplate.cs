using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Templates for Accounts
/// </summary>
public partial class AccountAccountTemplate
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
    /// Chart Template
    /// </summary>
    public int? ChartTemplateId { get; set; }

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
    /// Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string? AccountType { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Allow Invoices &amp; payments Matching
    /// </summary>
    public bool? Reconcile { get; set; }

    /// <summary>
    /// Optional Create
    /// </summary>
    public bool? Nocreate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalEarlyPayDiscountGainAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalEarlyPayDiscountLossAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalPaymentCreditAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalPaymentDebitAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateAccountJournalSuspenseAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateDefaultCashDifferenceExpenseAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateDefaultCashDifferenceIncomeAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateDefaultPosReceivableAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateExpenseCurrencyExchangeAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplateIncomeCurrencyExchangeAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountExpenseCategs { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountExpenses { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountIncomeCategs { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountIncomes { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountPayables { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAccountReceivables { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyAdvanceTaxPaymentAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyCashBasisBaseAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyStockAccountInputCategs { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyStockAccountOutputCategs { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyStockValuationAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyTaxPayableAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplatePropertyTaxReceivableAccounts { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateAccountDests { get; set; } = new List<AccountFiscalPositionAccountTemplate>();

    public virtual ICollection<AccountFiscalPositionAccountTemplate> AccountFiscalPositionAccountTemplateAccountSrcs { get; set; } = new List<AccountFiscalPositionAccountTemplate>();

    public virtual ICollection<AccountReconcileModelLineTemplate> AccountReconcileModelLineTemplates { get; set; } = new List<AccountReconcileModelLineTemplate>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplates { get; set; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual ICollection<AccountTaxTemplate> AccountTaxTemplates { get; set; } = new List<AccountTaxTemplate>();

    public virtual AccountChartTemplate? ChartTemplate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountAccountTag> AccountAccountTags { get; set; } = new List<AccountAccountTag>();

    public virtual ICollection<AccountTaxTemplate> Taxes { get; set; } = new List<AccountTaxTemplate>();
}
