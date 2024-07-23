using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// User, change own password wizard
/// </summary>
public partial class ChangePasswordOwn
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
    /// New Password
    /// </summary>
    public string? NewPassword { get; set; }

    /// <summary>
    /// New Password (Confirmation)
    /// </summary>
    public string? ConfirmPassword { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
