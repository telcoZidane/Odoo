using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Wizard model to reavaluate a stock inventory for a product
/// </summary>
public partial class StockValuationLayerRevaluation
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Related product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Journal
    /// </summary>
    public int? AccountJournalId { get; set; }

    /// <summary>
    /// Counterpart Account
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
    /// Reason
    /// </summary>
    public string? Reason { get; set; }

    /// <summary>
    /// Accounting Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Added value
    /// </summary>
    public decimal AddedValue { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual AccountAccount? Account { get; set; }

    public virtual AccountJournal? AccountJournal { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ProductProduct Product { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
