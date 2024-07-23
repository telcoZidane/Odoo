using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class IrActUrl
{
    public int Id { get; set; }

    public int? BindingModelId { get; set; }

    public int? CreateUid { get; set; }

    public int? WriteUid { get; set; }

    public string Type { get; set; } = null!;

    public string BindingType { get; set; } = null!;

    public string? BindingViewTypes { get; set; }

    public string Name { get; set; } = null!;

    public string? Help { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Action Target
    /// </summary>
    public string Target { get; set; } = null!;

    /// <summary>
    /// Action URL
    /// </summary>
    public string Url { get; set; } = null!;

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
