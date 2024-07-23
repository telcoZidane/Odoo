using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Spreadsheet Dashboard
/// </summary>
public partial class SpreadsheetDashboard
{
    public int Id { get; set; }

    /// <summary>
    /// Dashboard Group
    /// </summary>
    public int DashboardGroupId { get; set; }

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

    public virtual SpreadsheetDashboardGroup DashboardGroup { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResGroup> ResGroups { get; set; } = new List<ResGroup>();
}
