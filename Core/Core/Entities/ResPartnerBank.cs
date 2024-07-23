using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Bank Accounts
/// </summary>
public partial class ResPartnerBank
{
    public int Id { get; set; }

    /// <summary>
    /// Account Holder
    /// </summary>
    public int PartnerId { get; set; }

    /// <summary>
    /// Bank
    /// </summary>
    public int? BankId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// Currency
    /// </summary>
    public int? CurrencyId { get; set; }

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
    /// Account Number
    /// </summary>
    public string AccNumber { get; set; } = null!;

    /// <summary>
    /// Sanitized Account Number
    /// </summary>
    public string? SanitizedAccNumber { get; set; }

    /// <summary>
    /// Account Holder Name
    /// </summary>
    public string? AccHolderName { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Send Money
    /// </summary>
    public bool? AllowOutPayment { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();

    public virtual ICollection<AccountMove> AccountMoves { get; set; } = new List<AccountMove>();

    public virtual ICollection<AccountPaymentRegister> AccountPaymentRegisters { get; set; } = new List<AccountPaymentRegister>();

    public virtual ICollection<AccountPayment> AccountPayments { get; set; } = new List<AccountPayment>();

    public virtual ICollection<AccountSetupBankManualConfig> AccountSetupBankManualConfigs { get; set; } = new List<AccountSetupBankManualConfig>();

    public virtual ResBank? Bank { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResCurrency? Currency { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner Partner { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
