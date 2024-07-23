using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accounting Report External Value
/// </summary>
public partial class AccountReportExternalValue
{
    public int Id { get; set; }

    /// <summary>
    /// Target Expression
    /// </summary>
    public int TargetReportExpressionId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Fiscal position
    /// </summary>
    public int? ForeignVatFiscalPositionId { get; set; }

    /// <summary>
    /// Origin Line
    /// </summary>
    public int? CarryoverOriginReportLineId { get; set; }

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
    /// Origin Expression Label
    /// </summary>
    public string? CarryoverOriginExpressionLabel { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public double Value { get; set; }

    public virtual AccountReportLine? CarryoverOriginReportLine { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition? ForeignVatFiscalPosition { get; set; }

    public virtual AccountReportExpression TargetReportExpression { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
