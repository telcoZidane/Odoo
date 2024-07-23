using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class LunchCashmoveReport
{
    public int? Id { get; set; }

    public double? Amount { get; set; }

    public DateOnly? Date { get; set; }

    public int? CurrencyId { get; set; }

    public int? UserId { get; set; }

    public string? Description { get; set; }
}
