using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Fields that can be used for predictive lead scoring computation
/// </summary>
public partial class CrmLeadScoringFrequencyField
{
    public int Id { get; set; }

    /// <summary>
    /// Field
    /// </summary>
    public int FieldId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

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

    public virtual ICollection<CrmLeadPlsUpdate> CrmLeadPlsUpdates { get; set; } = new List<CrmLeadPlsUpdate>();
}
