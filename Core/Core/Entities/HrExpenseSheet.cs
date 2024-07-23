using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Expense Report
/// </summary>
public partial class HrExpenseSheet
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Employee
    /// </summary>
    public int EmployeeId { get; set; }

    /// <summary>
    /// Employee Home Address
    /// </summary>
    public int? AddressId { get; set; }

    /// <summary>
    /// Manager
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

    /// <summary>
    /// Expense Journal
    /// </summary>
    public int? JournalId { get; set; }

    /// <summary>
    /// Bank Journal
    /// </summary>
    public int? BankJournalId { get; set; }

    /// <summary>
    /// Journal Entry
    /// </summary>
    public int? AccountMoveId { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Expense Report Summary
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// Payment Status
    /// </summary>
    public string? PaymentState { get; set; }

    /// <summary>
    /// Accounting Date
    /// </summary>
    public DateOnly? AccountingDate { get; set; }

    /// <summary>
    /// Total Amount
    /// </summary>
    public decimal? TotalAmount { get; set; }

    /// <summary>
    /// Untaxed Amount
    /// </summary>
    public decimal? UntaxedAmount { get; set; }

    /// <summary>
    /// Taxes
    /// </summary>
    public decimal? TotalAmountTaxes { get; set; }

    /// <summary>
    /// Amount Due
    /// </summary>
    public decimal? AmountResidual { get; set; }

    /// <summary>
    /// Approval Date
    /// </summary>
    public DateTime? ApprovalDate { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual AccountMove? AccountMove { get; set; }

    public virtual ResPartner? Address { get; set; }

    public virtual AccountJournal? BankJournal { get; set; }

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual HrDepartment? Department { get; set; }

    public virtual HrEmployee Employee { get; set; } = null!;

    public virtual ICollection<HrExpenseRefuseWizard> HrExpenseRefuseWizards { get; set; } = new List<HrExpenseRefuseWizard>();

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();

    public virtual AccountJournal? Journal { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? User { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrExpenseApproveDuplicate> HrExpenseApproveDuplicates { get; set; } = new List<HrExpenseApproveDuplicate>();
}
