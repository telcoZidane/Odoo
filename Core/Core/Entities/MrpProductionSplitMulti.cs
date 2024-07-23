﻿using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Wizard to Split Multiple Productions
/// </summary>
public partial class MrpProductionSplitMulti
{
    public int Id { get; set; }

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

    public virtual ICollection<MrpProductionSplit> MrpProductionSplits { get; set; } = new List<MrpProductionSplit>();

    public virtual ResUser? WriteU { get; set; }
}
