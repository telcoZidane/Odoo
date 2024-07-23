namespace OdooApi.Data.Dtos.ProductCategory
{
    public class AssetfamilyDto
    {
        public string? Name { get; set; }

        public string? Type { get; set; }

        public int? ClientId { get; set; }

        public int? ParentAssetFamilyId { get; set; }

        public bool? IsDeleted { get; set; }

        public string? ExternalAssetFamilyId { get; set; }
    }
}
