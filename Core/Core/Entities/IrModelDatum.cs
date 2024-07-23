using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class IrModelDatum
{
    public int Id { get; set; }

    public int? CreateUid { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    public int? WriteUid { get; set; }

    public int? ResId { get; set; }

    public bool? Noupdate { get; set; }

    public string Name { get; set; } = null!;

    public string Module { get; set; } = null!;

    public string Model { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
