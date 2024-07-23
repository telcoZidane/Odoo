﻿using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Create Menu Wizard
/// </summary>
public partial class WizardIrModelMenuCreate
{
    public int Id { get; set; }

    /// <summary>
    /// Parent Menu
    /// </summary>
    public int MenuId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Menu Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual IrUiMenu Menu { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
