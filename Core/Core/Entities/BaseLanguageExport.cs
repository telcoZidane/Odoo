using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Language Export
/// </summary>
public partial class BaseLanguageExport
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
    /// File Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Language
    /// </summary>
    public string Lang { get; set; } = null!;

    /// <summary>
    /// File Format
    /// </summary>
    public string Format { get; set; } = null!;

    /// <summary>
    /// State
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// File
    /// </summary>
    public byte[]? Data { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<IrModuleModule> Modules { get; set; } = new List<IrModuleModule>();
}
