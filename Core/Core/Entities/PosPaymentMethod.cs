using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Point of Sale Payment Methods
/// </summary>
public partial class PosPaymentMethod
{
    public int Id { get; set; }

    /// <summary>
    /// Outstanding Account
    /// </summary>
    public int? OutstandingAccountId { get; set; }

    /// <summary>
    /// Intermediary Account
    /// </summary>
    public int? ReceivableAccountId { get; set; }

    /// <summary>
    /// Journal
    /// </summary>
    public int? JournalId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Use a Payment Terminal
    /// </summary>
    public string? UsePaymentTerminal { get; set; }

    /// <summary>
    /// Method
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Cash
    /// </summary>
    public bool? IsCashCount { get; set; }

    /// <summary>
    /// Identify Customer
    /// </summary>
    public bool? SplitTransactions { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountAccount? OutstandingAccount { get; set; }

    public virtual ICollection<PosMakePayment> PosMakePayments { get; set; } = new List<PosMakePayment>();

    public virtual ICollection<PosPayment> PosPayments { get; set; } = new List<PosPayment>();

    public virtual AccountAccount? ReceivableAccount { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();
}
