using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

public partial class IrAction
{
    public int Id { get; set; }

    /// <summary>
    /// Binding Model
    /// </summary>
    public int? BindingModelId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Action Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Binding Type
    /// </summary>
    public string BindingType { get; set; } = null!;

    /// <summary>
    /// Binding View Types
    /// </summary>
    public string? BindingViewTypes { get; set; }

    /// <summary>
    /// Action Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Action Description
    /// </summary>
    public string? Help { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual IrModel? BindingModel { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
