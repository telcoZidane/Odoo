using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Fields Selection
/// </summary>
public partial class IrModelFieldsSelection
{
    public int Id { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int FieldId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public string Value { get; set; } = null!;

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField Field { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
