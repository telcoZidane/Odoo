using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Profiling results
/// </summary>
public partial class IrProfile
{
    public int Id { get; set; }

    /// <summary>
    /// Queries Count
    /// </summary>
    public int? SqlCount { get; set; }

    /// <summary>
    /// Entry count
    /// </summary>
    public int? EntryCount { get; set; }

    /// <summary>
    /// Session
    /// </summary>
    public string? Session { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Initial stack trace
    /// </summary>
    public string? InitStackTrace { get; set; }

    /// <summary>
    /// Sql
    /// </summary>
    public string? Sql { get; set; }

    /// <summary>
    /// Traces Async
    /// </summary>
    public string? TracesAsync { get; set; }

    /// <summary>
    /// Traces Sync
    /// </summary>
    public string? TracesSync { get; set; }

    /// <summary>
    /// Qweb
    /// </summary>
    public string? Qweb { get; set; }

    /// <summary>
    /// Creation Date
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Duration
    /// </summary>
    public double? Duration { get; set; }
}
