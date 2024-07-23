using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class VendorDelayReport
{
    public int? Id { get; set; }

    public DateTime? Date { get; set; }

    public int? PurchaseLineId { get; set; }

    public int? ProductId { get; set; }

    public int? CategoryId { get; set; }

    public int? PartnerId { get; set; }

    public decimal? QtyTotal { get; set; }

    public decimal? QtyOnTime { get; set; }
}
