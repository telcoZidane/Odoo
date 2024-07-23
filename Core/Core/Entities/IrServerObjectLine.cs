using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Server Action value mapping
/// </summary>
public partial class IrServerObjectLine
{
    public int Id { get; set; }

    /// <summary>
    /// Related Server Action
    /// </summary>
    public int? ServerId { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int Col1 { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Evaluation Type
    /// </summary>
    public string EvaluationType { get; set; } = null!;

    /// <summary>
    /// Value
    /// </summary>
    public string Value { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual IrModelField Col1Navigation { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual IrActServer? Server { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
