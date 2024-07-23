using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Bank setup manual config
/// </summary>
public partial class AccountSetupBankManualConfig
{
    public int Id { get; set; }

    /// <summary>
    /// Res Partner Bank
    /// </summary>
    public int ResPartnerBankId { get; set; }

    /// <summary>
    /// Num Journals Without Account
    /// </summary>
    public int? NumJournalsWithoutAccount { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// New Journal Name
    /// </summary>
    public string NewJournalName { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResPartnerBank ResPartnerBank { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
