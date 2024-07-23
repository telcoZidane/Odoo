using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Module Activation Request
/// </summary>
public partial class BaseModuleInstallRequest
{
    public int Id { get; set; }

    /// <summary>
    /// Module
    /// </summary>
    public int ModuleId { get; set; }

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
    /// Body
    /// </summary>
    public string? BodyHtml { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrModuleModule Module { get; set; } = null!;

    public virtual ResUser User { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
