using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Line of issue consumption
/// </summary>
public partial class MrpConsumptionWarningLine
{
    public int Id { get; set; }

    /// <summary>
    /// Parent Wizard
    /// </summary>
    public int MrpConsumptionWarningId { get; set; }

    /// <summary>
    /// Manufacturing Order
    /// </summary>
    public int MrpProductionId { get; set; }

    /// <summary>
    /// Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Consumed
    /// </summary>
    public double? ProductConsumedQtyUom { get; set; }

    /// <summary>
    /// To Consume
    /// </summary>
    public double? ProductExpectedQtyUom { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual MrpConsumptionWarning MrpConsumptionWarning { get; set; } = null!;

    public virtual MrpProduction MrpProduction { get; set; } = null!;

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
