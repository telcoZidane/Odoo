﻿using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tests : Base Import Model, Many to One required
/// </summary>
public partial class BaseImportTestsModelsM2oRequired
{
    public int Id { get; set; }

    /// <summary>
    /// Value
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual BaseImportTestsModelsM2oRequiredRelated ValueNavigation { get; set; } = null!;

    public virtual ResUser? WriteU { get; set; }
}
