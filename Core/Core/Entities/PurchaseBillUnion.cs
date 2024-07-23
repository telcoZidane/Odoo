using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class PurchaseBillUnion
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Reference { get; set; }

    public int? PartnerId { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Amount { get; set; }

    public int? CurrencyId { get; set; }

    public int? CompanyId { get; set; }

    public int? VendorBillId { get; set; }

    public int? PurchaseOrderId { get; set; }
}
