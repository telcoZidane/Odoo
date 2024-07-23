using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accounts Mapping Template of Fiscal Position
/// </summary>
public partial class AccountFiscalPositionAccountTemplate
{
    public int Id { get; set; }

    /// <summary>
    /// Fiscal Mapping
    /// </summary>
    public int PositionId { get; set; }

    /// <summary>
    /// Account Source
    /// </summary>
    public int AccountSrcId { get; set; }

    /// <summary>
    /// Account Destination
    /// </summary>
    public int AccountDestId { get; set; }

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

    public virtual AccountAccountTemplate AccountDest { get; set; } = null!;

    public virtual AccountAccountTemplate AccountSrc { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPositionTemplate Position { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
