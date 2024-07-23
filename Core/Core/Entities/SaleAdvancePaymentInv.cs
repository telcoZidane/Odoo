using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Sales Advance Payment Invoice
/// </summary>
public partial class SaleAdvancePaymentInv
{
    public int Id { get; set; }

    /// <summary>
    /// Down Payment Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Income Account
    /// </summary>
    public int? DepositAccountId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Create Invoice
    /// </summary>
    public string AdvancePaymentMethod { get; set; } = null!;

    /// <summary>
    /// Down Payment Amount (Fixed)
    /// </summary>
    public decimal? FixedAmount { get; set; }

    /// <summary>
    /// Deduct down payments
    /// </summary>
    public bool? DeductDownPayments { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Down Payment Amount
    /// </summary>
    public double? Amount { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual AccountAccount? DepositAccount { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> AccountTaxes { get; set; } = new List<AccountTax>();

    public virtual ICollection<SaleOrder> SaleOrders { get; set; } = new List<SaleOrder>();
}
