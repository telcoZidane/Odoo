using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tests : Base Import Model Preview
/// </summary>
public partial class BaseImportTestsModelsPreview
{
    public int Id { get; set; }

    /// <summary>
    /// Some Value
    /// </summary>
    public int Somevalue { get; set; }

    /// <summary>
    /// Other Variable
    /// </summary>
    public int? Othervalue { get; set; }

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

    public virtual ResUser? WriteU { get; set; }
}
