using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Barcode Rule
/// </summary>
public partial class BarcodeRule
{
    public int Id { get; set; }

    /// <summary>
    /// Barcode Nomenclature
    /// </summary>
    public int? BarcodeNomenclatureId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Rule Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Encoding
    /// </summary>
    public string Encoding { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// Barcode Pattern
    /// </summary>
    public string Pattern { get; set; } = null!;

    /// <summary>
    /// Alias
    /// </summary>
    public string Alias { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Associated Uom
    /// </summary>
    public int? AssociatedUomId { get; set; }

    /// <summary>
    /// GS1 Content Type
    /// </summary>
    public string? Gs1ContentType { get; set; }

    /// <summary>
    /// Decimal
    /// </summary>
    public bool? Gs1DecimalUsage { get; set; }

    public virtual UomUom? AssociatedUom { get; set; }

    public virtual BarcodeNomenclature? BarcodeNomenclature { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
