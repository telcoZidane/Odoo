using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Barcode Nomenclature
/// </summary>
public partial class BarcodeNomenclature
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
    /// Barcode Nomenclature
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// UPC/EAN Conversion
    /// </summary>
    public string UpcEanConv { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// FNC1 Separator
    /// </summary>
    public string? Gs1SeparatorFnc1 { get; set; }

    /// <summary>
    /// Is GS1 Nomenclature
    /// </summary>
    public bool? IsGs1Nomenclature { get; set; }

    public virtual ICollection<BarcodeRule> BarcodeRules { get; set; } = new List<BarcodeRule>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<ResCompany> ResCompanies { get; set; } = new List<ResCompany>();

    public virtual ResUser? WriteU { get; set; }
}
