using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ReportPosOrder
{
    public int? Id { get; set; }

    public long? NbrLines { get; set; }

    public DateTime? Date { get; set; }

    public decimal? ProductQty { get; set; }

    public decimal? PriceSubTotal { get; set; }

    public decimal? PriceTotal { get; set; }

    public decimal? TotalDiscount { get; set; }

    public decimal? AveragePrice { get; set; }

    public long? DelayValidation { get; set; }

    public int? OrderId { get; set; }

    public int? PartnerId { get; set; }

    public string? State { get; set; }

    public int? UserId { get; set; }

    public int? CompanyId { get; set; }

    public int? JournalId { get; set; }

    public int? ProductId { get; set; }

    public int? ProductCategId { get; set; }

    public int? ProductTmplId { get; set; }

    public int? ConfigId { get; set; }

    public int? PosCategId { get; set; }

    public int? PricelistId { get; set; }

    public int? SessionId { get; set; }

    public bool? Invoiced { get; set; }

    public decimal? Margin { get; set; }

    public int? EmployeeId { get; set; }
}
