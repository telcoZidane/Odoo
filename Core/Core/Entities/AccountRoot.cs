using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class AccountRoot
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public int? ParentId { get; set; }

    public int? CompanyId { get; set; }
}
