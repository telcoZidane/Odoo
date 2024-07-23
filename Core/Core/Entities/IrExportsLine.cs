using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Exports Line
/// </summary>
public partial class IrExportsLine
{
    public int Id { get; set; }

    /// <summary>
    /// Export
    /// </summary>
    public int? ExportId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Field Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrExport? Export { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
