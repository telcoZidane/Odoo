using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Default Values
/// </summary>
public partial class IrDefault
{
    public int Id { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int FieldId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Condition
    /// </summary>
    public string? Condition { get; set; }

    /// <summary>
    /// Default Value (JSON format)
    /// </summary>
    public string JsonValue { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModelField Field { get; set; } = null!;

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
