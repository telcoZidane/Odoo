using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// 2-Factor Setup Wizard
/// </summary>
public partial class AuthTotpWizard
{
    public int Id { get; set; }

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
    /// Secret
    /// </summary>
    public string Secret { get; set; } = null!;

    /// <summary>
    /// Url
    /// </summary>
    public string? Url { get; set; }

    /// <summary>
    /// Verification Code
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Qrcode
    /// </summary>
    public byte[]? Qrcode { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
