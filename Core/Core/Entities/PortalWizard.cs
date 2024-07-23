using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Grant Portal Access
/// </summary>
public partial class PortalWizard
{
    public int Id { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Invitation Message
    /// </summary>
    public string? WelcomeMessage { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<PortalWizardUser> PortalWizardUsers { get; set; } = new List<PortalWizardUser>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResPartner> ResPartners { get; set; } = new List<ResPartner>();
}
