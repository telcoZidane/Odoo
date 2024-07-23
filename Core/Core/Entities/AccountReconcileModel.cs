using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Preset to create journal entries during a invoices and payments matching
/// </summary>
public partial class AccountReconcileModel
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Sequence
    /// </summary>
    public int Sequence { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Search Months Limit
    /// </summary>
    public int? PastMonthsLimit { get; set; }

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
    public string Name { get; set; } = null!;

    /// <summary>
    /// Type
    /// </summary>
    public string RuleType { get; set; } = null!;

    /// <summary>
    /// Matching Order
    /// </summary>
    public string MatchingOrder { get; set; } = null!;

    /// <summary>
    /// Amount Type
    /// </summary>
    public string MatchNature { get; set; } = null!;

    /// <summary>
    /// Amount Condition
    /// </summary>
    public string? MatchAmount { get; set; }

    /// <summary>
    /// Label
    /// </summary>
    public string? MatchLabel { get; set; }

    /// <summary>
    /// Label Parameter
    /// </summary>
    public string? MatchLabelParam { get; set; }

    /// <summary>
    /// Note
    /// </summary>
    public string? MatchNote { get; set; }

    /// <summary>
    /// Note Parameter
    /// </summary>
    public string? MatchNoteParam { get; set; }

    /// <summary>
    /// Transaction Type
    /// </summary>
    public string? MatchTransactionType { get; set; }

    /// <summary>
    /// Transaction Type Parameter
    /// </summary>
    public string? MatchTransactionTypeParam { get; set; }

    /// <summary>
    /// Payment Tolerance Type
    /// </summary>
    public string PaymentToleranceType { get; set; } = null!;

    /// <summary>
    /// Decimal Separator
    /// </summary>
    public string? DecimalSeparator { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Auto-validate
    /// </summary>
    public bool? AutoReconcile { get; set; }

    /// <summary>
    /// To Check
    /// </summary>
    public bool? ToCheck { get; set; }

    /// <summary>
    /// Match Text Location Label
    /// </summary>
    public bool? MatchTextLocationLabel { get; set; }

    /// <summary>
    /// Match Text Location Note
    /// </summary>
    public bool? MatchTextLocationNote { get; set; }

    /// <summary>
    /// Match Text Location Reference
    /// </summary>
    public bool? MatchTextLocationReference { get; set; }

    /// <summary>
    /// Same Currency
    /// </summary>
    public bool? MatchSameCurrency { get; set; }

    /// <summary>
    /// Payment Tolerance
    /// </summary>
    public bool? AllowPaymentTolerance { get; set; }

    /// <summary>
    /// Partner is Set
    /// </summary>
    public bool? MatchPartner { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Amount Min Parameter
    /// </summary>
    public double? MatchAmountMin { get; set; }

    /// <summary>
    /// Amount Max Parameter
    /// </summary>
    public double? MatchAmountMax { get; set; }

    /// <summary>
    /// Gap
    /// </summary>
    public double? PaymentToleranceParam { get; set; }

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<AccountReconcileModelLine> AccountReconcileModelLines { get; set; } = new List<AccountReconcileModelLine>();

    public virtual ICollection<AccountReconcileModelPartnerMapping> AccountReconcileModelPartnerMappings { get; set; } = new List<AccountReconcileModelPartnerMapping>();

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<AccountJournal> AccountJournals { get; set; } = new List<AccountJournal>();

    public virtual ICollection<ResPartnerCategory> ResPartnerCategories { get; set; } = new List<ResPartnerCategory>();

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();
}
