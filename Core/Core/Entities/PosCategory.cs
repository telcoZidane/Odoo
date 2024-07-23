using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Point of Sale Category
/// </summary>
public partial class PosCategory
{
    public int Id { get; set; }

    /// <summary>
    /// Parent Category
    /// </summary>
    public int? ParentId { get; set; }

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
    /// Category Name
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

    public virtual ICollection<PosCategory> InverseParent { get; set; } = new List<PosCategory>();

    public virtual PosCategory? Parent { get; set; }

    public virtual ICollection<PosConfig> PosConfigsNavigation { get; set; } = new List<PosConfig>();

    public virtual ICollection<ProductTemplate> ProductTemplates { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ResConfigSetting> ResConfigSettingsNavigation { get; set; } = new List<ResConfigSetting>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual ICollection<ResConfigSetting> ResConfigSettings { get; set; } = new List<ResConfigSetting>();
}
