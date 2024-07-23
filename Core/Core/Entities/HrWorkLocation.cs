using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Work Location
/// </summary>
public partial class HrWorkLocation
{
    public int Id { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Work Address
    /// </summary>
    public int AddressId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Work Location
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Location Number
    /// </summary>
    public string? LocationNumber { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ResPartner Address { get; set; } = null!;

    public virtual ResCompany Company { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrEmployee> HrEmployees { get; set; } = new List<HrEmployee>();

    public virtual ResUser? WriteU { get; set; }
}
