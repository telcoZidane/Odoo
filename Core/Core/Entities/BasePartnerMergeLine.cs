using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Merge Partner Line
/// </summary>
public partial class BasePartnerMergeLine
{
    public int Id { get; set; }

    /// <summary>
    /// Wizard
    /// </summary>
    public int? WizardId { get; set; }

    /// <summary>
    /// MinID
    /// </summary>
    public int? MinId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Ids
    /// </summary>
    public string AggrIds { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<BasePartnerMergeAutomaticWizard> BasePartnerMergeAutomaticWizards { get; set; } = new List<BasePartnerMergeAutomaticWizard>();

    public virtual ResUser? CreateU { get; set; }

    public virtual BasePartnerMergeAutomaticWizard? Wizard { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
