using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accounting Report Line
/// </summary>
public partial class AccountReportLine
{
    public int Id { get; set; }

    /// <summary>
    /// Parent Report
    /// </summary>
    public int ReportId { get; set; }

    /// <summary>
    /// Level
    /// </summary>
    public int HierarchyLevel { get; set; }

    /// <summary>
    /// Parent Line
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public int? ActionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Group By
    /// </summary>
    public string? Groupby { get; set; }

    /// <summary>
    /// Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Foldable
    /// </summary>
    public bool? Foldable { get; set; }

    /// <summary>
    /// Print On New Page
    /// </summary>
    public bool? PrintOnNewPage { get; set; }

    /// <summary>
    /// Hide if Zero
    /// </summary>
    public bool? HideIfZero { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountReportExpression> AccountReportExpressions { get; set; } = new List<AccountReportExpression>();

    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; set; } = new List<AccountReportExternalValue>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<AccountReportLine> InverseParent { get; set; } = new List<AccountReportLine>();

    public virtual AccountReportLine? Parent { get; set; }

    public virtual AccountReport Report { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
