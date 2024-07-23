using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accounting Report Column
/// </summary>
public partial class AccountReportColumn
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Report
    /// </summary>
    public int? ReportId { get; set; }

    /// <summary>
    /// Custom Audit Action
    /// </summary>
    public int? CustomAuditActionId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Expression Label
    /// </summary>
    public string ExpressionLabel { get; set; } = null!;

    /// <summary>
    /// Figure Type
    /// </summary>
    public string FigureType { get; set; } = null!;

    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Sortable
    /// </summary>
    public bool? Sortable { get; set; }

    /// <summary>
    /// Blank if Zero
    /// </summary>
    public bool? BlankIfZero { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrActWindow? CustomAuditAction { get; set; }

    public virtual AccountReport? Report { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
