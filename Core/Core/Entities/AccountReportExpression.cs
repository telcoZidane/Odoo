using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accounting Report Expression
/// </summary>
public partial class AccountReportExpression
{
    public int Id { get; set; }

    /// <summary>
    /// Report Line
    /// </summary>
    public int ReportLineId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Label
    /// </summary>
    public string Label { get; set; } = null!;

    /// <summary>
    /// Computation Engine
    /// </summary>
    public string Engine { get; set; } = null!;

    /// <summary>
    /// Formula
    /// </summary>
    public string Formula { get; set; } = null!;

    /// <summary>
    /// Subformula
    /// </summary>
    public string? Subformula { get; set; }

    /// <summary>
    /// Date Scope
    /// </summary>
    public string DateScope { get; set; } = null!;

    /// <summary>
    /// Figure Type
    /// </summary>
    public string? FigureType { get; set; }

    /// <summary>
    /// Carry Over To
    /// </summary>
    public string? CarryoverTarget { get; set; }

    /// <summary>
    /// Is Growth Good when Positive
    /// </summary>
    public bool? GreenOnPositive { get; set; }

    /// <summary>
    /// Blank if Zero
    /// </summary>
    public bool? BlankIfZero { get; set; }

    /// <summary>
    /// Auditable
    /// </summary>
    public bool? Auditable { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountReportExternalValue> AccountReportExternalValues { get; set; } = new List<AccountReportExternalValue>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountReportLine ReportLine { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplates { get; set; } = new List<AccountTaxRepartitionLineTemplate>();

    public virtual ICollection<AccountTaxRepartitionLineTemplate> AccountTaxRepartitionLineTemplatesNavigation { get; set; } = new List<AccountTaxRepartitionLineTemplate>();
}
