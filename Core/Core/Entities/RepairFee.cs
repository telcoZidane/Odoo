using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Repair Fees
/// </summary>
public partial class RepairFee
{
    public int Id { get; set; }

    /// <summary>
    /// Repair Order Reference
    /// </summary>
    public int RepairId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int? ProductId { get; set; }

    /// <summary>
    /// Product Unit of Measure
    /// </summary>
    public int ProductUom { get; set; }

    /// <summary>
    /// Invoice Line
    /// </summary>
    public int? InvoiceLineId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal ProductUomQty { get; set; }

    /// <summary>
    /// Unit Price
    /// </summary>
    public decimal PriceUnit { get; set; }

    /// <summary>
    /// Subtotal
    /// </summary>
    public decimal? PriceSubtotal { get; set; }

    /// <summary>
    /// Total
    /// </summary>
    public decimal? PriceTotal { get; set; }

    /// <summary>
    /// Invoiced
    /// </summary>
    public bool? Invoiced { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMoveLine? InvoiceLine { get; set; }

    public virtual ProductProduct? Product { get; set; }

    public virtual UomUom ProductUomNavigation { get; set; } = null!;

    public virtual RepairOrder Repair { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTax> Taxes { get; set; } = new List<AccountTax>();
}
