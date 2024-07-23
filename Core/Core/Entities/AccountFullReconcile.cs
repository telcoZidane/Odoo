using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Full Reconcile
/// </summary>
public partial class AccountFullReconcile
{
    public int Id { get; set; }

    /// <summary>
    /// Exchange Move
    /// </summary>
    public int? ExchangeMoveId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Number
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

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountPartialReconcile> AccountPartialReconciles { get; set; } = new List<AccountPartialReconcile>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountMove? ExchangeMove { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
