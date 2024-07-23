using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tests : Base Import Model, One to Many
/// </summary>
public partial class BaseImportTestsModelsO2m
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
    public string? Name { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<BaseImportTestsModelsO2mChild> BaseImportTestsModelsO2mChildren { get; set; } = new List<BaseImportTestsModelsO2mChild>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
