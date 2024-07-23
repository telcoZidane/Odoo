using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class IrActClient
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
    /// Client action tag
    /// </summary>
    public string Tag { get; set; } = null!;

    /// <summary>
    /// Target Window
    /// </summary>
    public string? Target { get; set; }

    /// <summary>
    /// Destination Model
    /// </summary>
    public string? ResModel { get; set; }

    /// <summary>
    /// Context Value
    /// </summary>
    public string Context { get; set; } = null!;

    /// <summary>
    /// Params storage
    /// </summary>
    public byte[]? ParamsStore { get; set; }

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
