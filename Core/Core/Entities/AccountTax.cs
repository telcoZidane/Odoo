using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tax
/// </summary>
public partial class AccountTax
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Tax Group
    /// </summary>
    public int TaxGroupId { get; set; }

    /// <summary>
    /// Cash Basis Transition Account
    /// </summary>
    public int? CashBasisTransitionAccountId { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public int CountryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Tax Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Tax Type
    /// </summary>
    public string TypeTaxUse { get; set; } = null!;

    /// <summary>
    /// Tax Scope
    /// </summary>
    public string? TaxScope { get; set; }

    /// <summary>
    /// Tax Computation
    /// </summary>
    public string AmountType { get; set; } = null!;

    /// <summary>
    /// Label on Invoices
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Tax Exigibility
    /// </summary>
    public string? TaxExigibility { get; set; }

    /// <summary>
    /// Amount
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Included in Price
    /// </summary>
    public bool? PriceInclude { get; set; }

    /// <summary>
    /// Affect Base of Subsequent Taxes
    /// </summary>
    public bool? IncludeBaseAmount { get; set; }

    /// <summary>
    /// Base Affected by Previous Taxes
    /// </summary>
    public bool? IsBaseAffected { get; set; }

    /// <summary>
    /// Include in Analytic Cost
    /// </summary>
    public bool? Analytic { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Real amount to apply
    /// </summary>
    public double? RealAmount { get; set; }

    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxTaxDests { get; set; } = new List<AccountFiscalPositionTax>();

    public virtual ICollection<AccountFiscalPositionTax> AccountFiscalPositionTaxTaxSrcs { get; set; } = new List<AccountFiscalPositionTax>();

    public virtual ICollection<AccountMoveLine> AccountMoveLineGroupTaxes { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountMoveLine> AccountMoveLineTaxLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineInvoiceTaxes { get; set; } = new List<AccountTaxRepartitionLine>();

    public virtual ICollection<AccountTaxRepartitionLine> AccountTaxRepartitionLineRefundTaxes { get; set; } = new List<AccountTaxRepartitionLine>();

    public virtual AccountAccount? CashBasisTransitionAccount { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResCountry Country { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResCompany> ResCompanyAccountPurchaseTaxes { get; set; } = new List<ResCompany>();

    public virtual ICollection<ResCompany> ResCompanyAccountSaleTaxes { get; set; } = new List<ResCompany>();

    public virtual AccountTaxGroup TaxGroup { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; set; } = new List<AccountReconcileModelLine>();

    public virtual ICollection<AccountAccount> Accounts { get; set; } = new List<AccountAccount>();

    public virtual ICollection<AccountTax> ChildTaxes { get; set; } = new List<AccountTax>();

    public virtual ICollection<HrExpense> Expenses { get; set; } = new List<HrExpense>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; set; } = new List<HrExpenseSplit>();

    public virtual ICollection<AccountTax> ParentTaxes { get; set; } = new List<AccountTax>();

    public virtual ICollection<PosOrderLine> PosOrderLines { get; set; } = new List<PosOrderLine>();

    public virtual ICollection<ProductTemplate> Prods { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> ProdsNavigation { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<RepairFee> RepairFeeLines { get; set; } = new List<RepairFee>();

    public virtual ICollection<RepairLine> RepairOperationLines { get; set; } = new List<RepairLine>();

    public virtual ICollection<SaleAdvancePaymentInv> SaleAdvancePaymentInvs { get; set; } = new List<SaleAdvancePaymentInv>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();
}
