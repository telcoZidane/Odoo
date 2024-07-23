using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Language Import
/// </summary>
public partial class BaseLanguageImport
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
    /// Language Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// ISO Code
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// File Name
    /// </summary>
    public string Filename { get; set; } = null!;

    /// <summary>
    /// Overwrite Existing Terms
    /// </summary>
    public bool? Overwrite { get; set; }

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
    public byte[] Data { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
