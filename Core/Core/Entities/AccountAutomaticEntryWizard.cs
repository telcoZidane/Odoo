using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Create Automatic Entries
/// </summary>
public partial class AccountAutomaticEntryWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// To
    /// </summary>
    public int? DestinationAccountId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Action
    /// </summary>
    public string Action { get; set; } = null!;

    /// <summary>
    /// Account Type
    /// </summary>
    public string? AccountType { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// Total Amount
    /// </summary>
    public decimal? TotalAmount { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Percentage
    /// </summary>
    public double? Percentage { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountAccount? DestinationAccount { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();
}
