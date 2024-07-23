using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product UoM Categories
/// </summary>
public partial class UomCategory
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
    /// Unit of Measure Category
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Group Products in POS
    /// </summary>
    public bool? IsPosGroupable { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<UomUom> UomUoms { get; set; } = new List<UomUom>();

    public virtual ResUser? WriteU { get; set; }
}
