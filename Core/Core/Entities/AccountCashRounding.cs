using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Account Cash Rounding
/// </summary>
public partial class AccountCashRounding
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
    /// Rounding Strategy
    /// </summary>
    public string Strategy { get; set; } = null!;

    /// <summary>
    /// Rounding Method
    /// </summary>
    public string RoundingMethod { get; set; } = null!;

    /// <summary>
    /// Name
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
    /// Rounding Precision
    /// </summary>
    public double Rounding { get; set; }

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual ResUser? WriteU { get; set; }
}
