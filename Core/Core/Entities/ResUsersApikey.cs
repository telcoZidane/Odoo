using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class ResUsersApikey
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public string? Scope { get; set; }

    public string? Index { get; set; }

    public string? Key { get; set; }

    public DateTime? CreateDate { get; set; }

    public virtual ResUser User { get; set; } = null!;
}
