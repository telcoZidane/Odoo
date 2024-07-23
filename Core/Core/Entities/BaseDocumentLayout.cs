using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Company Document Layout
/// </summary>
public partial class BaseDocumentLayout
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Report Layout
    /// </summary>
    public int? ReportLayoutId { get; set; }

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

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ReportLayout? ReportLayout { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
