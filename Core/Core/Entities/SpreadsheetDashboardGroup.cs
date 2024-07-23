﻿using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Group of dashboards
/// </summary>
public partial class SpreadsheetDashboardGroup
{
    public int Id { get; set; }

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

    public virtual ICollection<SpreadsheetDashboard> SpreadsheetDashboards { get; set; } = new List<SpreadsheetDashboard>();

    public virtual ResUser? WriteU { get; set; }
}
