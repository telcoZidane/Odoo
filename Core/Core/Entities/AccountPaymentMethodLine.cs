using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Payment Methods
/// </summary>
public partial class AccountPaymentMethodLine
{
    public int Id { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Payment Method
    /// </summary>
    public int PaymentMethodId { get; set; }

    /// <summary>
    /// Payment Account
    /// </summary>
    public int? PaymentAccountId { get; set; }

    /// <summary>
    /// Journal
    /// </summary>
    public int? JournalId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Payment Provider
    /// </summary>
    public int? PaymentProviderId { get; set; }

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual ResUser? CreateU { get; set; }

    public virtual AccountJournal? Journal { get; set; }

    public virtual AccountAccount? PaymentAccount { get; set; }

    public virtual AccountPaymentMethod PaymentMethod { get; set; } = null!;

    public virtual PaymentProvider? PaymentProvider { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
