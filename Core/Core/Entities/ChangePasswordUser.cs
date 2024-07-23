using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// User, Change Password Wizard
/// </summary>
public partial class ChangePasswordUser
{
    public int Id { get; set; }

    /// <summary>
    /// Wizard
    /// </summary>
    public int WizardId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int UserId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// User Login
    /// </summary>
    public string? UserLogin { get; set; }

    /// <summary>
    /// New Password
    /// </summary>
    public string? NewPasswd { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual ChangePasswordWizard Wizard { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
