using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ReportStockQuantity
{
    public int? Id { get; set; }

    public int? ProductId { get; set; }

    public int? ProductTmplId { get; set; }

    public string? State { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? ProductQty { get; set; }

    public int? CompanyId { get; set; }

    public int? WarehouseId { get; set; }
}
