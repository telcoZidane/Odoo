using System;
using System.Collections.Generic;

namespace OdooApi.Models;

public partial class Assetfamily
{
    public int AssetFamilyId { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public int? ClientId { get; set; }

    public int? ParentAssetFamilyId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ExternalAssetFamilyId { get; set; }

    public virtual ICollection<Assetfamily> InverseParentAssetFamily { get; set; } = new List<Assetfamily>();

    public virtual Assetfamily? ParentAssetFamily { get; set; }
}
