using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ResCurrency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Symbol { get; set; } = null!;

    /// <summary>
    /// Decimal Places
    /// </summary>
    public int? DecimalPlaces { get; set; }

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
    public string? FullName { get; set; }

    /// <summary>
    /// Symbol Position
    /// </summary>
    public string? Position { get; set; }

    /// <summary>
    /// Currency Unit
    /// </summary>
    public string? CurrencyUnitLabel { get; set; }

    /// <summary>
    /// Currency Subunit
    /// </summary>
    public string? CurrencySubunitLabel { get; set; }

    /// <summary>
    /// Rounding Factor
    /// </summary>
    public decimal? Rounding { get; set; }

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

    public virtual ICollection<AccountAccountTemplate> AccountAccountTemplates { get; set; } = new List<AccountAccountTemplate>();

    public virtual ICollection<AccountAccount> AccountAccounts { get; set; } = new List<AccountAccount>();

    public virtual ICollection<AccountAccruedOrdersWizard> AccountAccruedOrdersWizards { get; set; } = new List<AccountAccruedOrdersWizard>();

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineCurrencies { get; set; } = new List<AccountBankStatementLine>();

    public virtual ICollection<AccountBankStatementLine> AccountBankStatementLineForeignCurrencies { get; set; } = new List<AccountBankStatementLine>();

    public virtual ICollection<AccountChartTemplate> AccountChartTemplates { get; set; } = new List<AccountChartTemplate>();

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountMoveLine> AccountMoveLineCompanyCurrencies { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMoveLine> AccountMoveLineCurrencies { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileCreditCurrencies { get; set; } = new List<AccountPartialReconcile>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconcileDebitCurrencies { get; set; } = new List<AccountPartialReconcile>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterCurrencies { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisterSourceCurrencies { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual ICollection<BaseImportTestsModelsComplex> BaseImportTestsModelsComplexes { get; set; } = new List<BaseImportTestsModelsComplex>();

    public virtual ICollection<BaseImportTestsModelsFloat> BaseImportTestsModelsFloats { get; set; } = new List<BaseImportTestsModelsFloat>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; set; } = new List<HrExpenseSplit>();

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();

    public virtual ICollection<LunchCashmove> LunchCashmoves { get; set; } = new List<LunchCashmove>();

    public virtual ICollection<LunchOrder> LunchOrders { get; set; } = new List<LunchOrder>();

    public virtual ICollection<MailTrackingValue> MailTrackingValues { get; set; } = new List<MailTrackingValue>();

    public virtual ICollection<PaymentLinkWizard> PaymentLinkWizards { get; set; } = new List<PaymentLinkWizard>();

    public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new List<PaymentTransaction>();

    public virtual ICollection<ProductPricelistItem> ProductPricelistItems { get; set; } = new List<ProductPricelistItem>();

    public virtual ICollection<ProductPricelist> ProductPricelists { get; set; } = new List<ProductPricelist>();

    public virtual ICollection<ProductSupplierinfo> ProductSupplierinfos { get; set; } = new List<ProductSupplierinfo>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCountry> ResCountries { get; set; } = new List<ResCountry>();

    public virtual ICollection<ResCurrencyRate> ResCurrencyRates { get; set; } = new List<ResCurrencyRate>();

    public virtual ICollection<ResPartnerBank> ResPartnerBanks { get; set; } = new List<ResPartnerBank>();

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; set; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();

    public virtual ResUser? WriteU { get; set; }
}
