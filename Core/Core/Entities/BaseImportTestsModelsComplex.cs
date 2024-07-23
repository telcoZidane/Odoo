using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tests: Base Import Model Complex
/// </summary>
public partial class BaseImportTestsModelsComplex
{
    public int Id { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// C
    /// </summary>
    public string? C { get; set; }

    /// <summary>
    /// D
    /// </summary>
    public DateOnly? D { get; set; }

    /// <summary>
    /// M
    /// </summary>
    public decimal? M { get; set; }

    /// <summary>
    /// Dt
    /// </summary>
    public DateTime? Dt { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// F
    /// </summary>
    public double? F { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
