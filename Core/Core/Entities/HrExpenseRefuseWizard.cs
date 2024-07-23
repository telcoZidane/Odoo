using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Expense Refuse Reason Wizard
/// </summary>
public partial class HrExpenseRefuseWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Hr Expense Sheet
    /// </summary>
    public int? HrExpenseSheetId { get; set; }

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
    public string Reason { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrExpenseSheet? HrExpenseSheet { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();
}
