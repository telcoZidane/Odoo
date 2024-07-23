using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Expense Split Wizard
/// </summary>
public partial class HrExpenseSplitWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Expense
    /// </summary>
    public int ExpenseId { get; set; }

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

    public virtual ResUser? CreateU { get; set; }

    public virtual HrExpense Expense { get; set; } = null!;

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; set; } = new List<HrExpenseSplit>();

    public virtual ResUser? WriteU { get; set; }
}
