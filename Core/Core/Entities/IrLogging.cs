using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Logging
/// </summary>
public partial class IrLogging
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
    /// Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Database Name
    /// </summary>
    public string? Dbname { get; set; }

    /// <summary>
    /// Level
    /// </summary>
    public string? Level { get; set; }

    /// <summary>
    /// Path
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// Function
    /// </summary>
    public string Func { get; set; } = null!;

    /// <summary>
    /// Line
    /// </summary>
    public string Line { get; set; } = null!;

    /// <summary>
    /// Message
    /// </summary>
    public string Message { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }
}
