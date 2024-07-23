using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Accounts Mapping of Fiscal Position
/// </summary>
public partial class AccountFiscalPositionAccount
{
    public int Id { get; set; }

    /// <summary>
    /// Fiscal Position
    /// </summary>
    public int PositionId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Account on Product
    /// </summary>
    public int AccountSrcId { get; set; }

    /// <summary>
    /// Account to Use Instead
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

    public virtual AccountAccount AccountDest { get; set; } = null!;

    public virtual AccountAccount AccountSrc { get; set; } = null!;

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountFiscalPosition Position { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
