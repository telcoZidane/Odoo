using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Close Session Wizard
/// </summary>
public partial class PosCloseSessionWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Destination account
    /// </summary>
    public int? AccountId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Information message
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Destination account is readonly
    /// </summary>
    public bool? AccountReadonly { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Amount to balance
    /// </summary>
    public double? AmountToBalance { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
