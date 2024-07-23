using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Paper Format Config
/// </summary>
public partial class ReportPaperformat
{
    public int Id { get; set; }

    /// <summary>
    /// Page height (mm)
    /// </summary>
    public int? PageHeight { get; set; }

    /// <summary>
    /// Page width (mm)
    /// </summary>
    public int? PageWidth { get; set; }

    /// <summary>
    /// Header spacing
    /// </summary>
    public int? HeaderSpacing { get; set; }

    /// <summary>
    /// Output DPI
    /// </summary>
    public int Dpi { get; set; }

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
    /// Paper size
    /// </summary>
    public string? Format { get; set; }

    /// <summary>
    /// Orientation
    /// </summary>
    public string? Orientation { get; set; }

    /// <summary>
    /// Default paper format ?
    /// </summary>
    public bool? Default { get; set; }

    /// <summary>
    /// Display a header line
    /// </summary>
    public bool? HeaderLine { get; set; }

    /// <summary>
    /// Disable smart shrinking
    /// </summary>
    public bool? DisableShrinking { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Top Margin (mm)
    /// </summary>
    public double? MarginTop { get; set; }

    /// <summary>
    /// Bottom Margin (mm)
    /// </summary>
    public double? MarginBottom { get; set; }

    /// <summary>
    /// Left Margin (mm)
    /// </summary>
    public double? MarginLeft { get; set; }

    /// <summary>
    /// Right Margin (mm)
    /// </summary>
    public double? MarginRight { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<IrActReportXml> IrActReportXmls { get; set; } = new List<IrActReportXml>();

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ResUser? WriteU { get; set; }
}
