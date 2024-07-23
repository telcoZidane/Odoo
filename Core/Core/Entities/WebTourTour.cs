using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Tours
/// </summary>
public partial class WebTourTour
{
    public int Id { get; set; }

    /// <summary>
    /// Consumed by
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Tour name
    /// </summary>
    public string Name { get; set; } = null!;

    public virtual ResUser? User { get; set; }
}
