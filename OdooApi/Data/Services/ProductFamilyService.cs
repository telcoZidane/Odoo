using Core.Core.Entities;
using Core.Services;
using Microsoft.EntityFrameworkCore;
using Odoo.Concrete;
using OdooApi.Models;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace OdooApi.Data.Services
{
    public class ProductFamilyService
    {
        public readonly LeociaContext _context;
        public ServiceInit serviceInit;
        public ProductFamilyService(LeociaContext context, ServiceInit serviceInit)
        {
            _context = context;
            this.serviceInit = serviceInit;
        }
        public RpcConnection GetConnection()
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            var rpcConnnectionSettings = new RpcConnectionSetting();

            config.GetSection("OdooConnection").Bind(rpcConnnectionSettings);

            //Connection
            var conn = new RpcConnection(rpcConnnectionSettings);
            return conn;
        }
        // get children
        public async Task<List<Assetfamily>> GetProductfamilies()
        {
            var productCategories = await _context.Assetfamilies.ToListAsync();
            return productCategories;
        }
        // get children
        public async Task<List<ProductCategory>> GetProductChildren(RpcConnection conn,int id)
        {
            //RpcConnection conn = GetConnection();
            EnumsOdoo model = EnumsOdoo.ProductCategory;

            var productCategories = await serviceInit.Product_CategoryService.GetProductCategories(conn);
            var productChildren=productCategories.Where(a=>a.ParentId == id).ToList();
            return productChildren;
        }
        
        // insert the categories to leocia database
        public Assetfamily UpdateAssetFamily(Assetfamily newAssetfamily)
        {
            var existAssetFamily= _context.Assetfamilies.FirstOrDefault(a=>a.AssetFamilyId==newAssetfamily.AssetFamilyId);
            if (existAssetFamily != null)
            {
                existAssetFamily.Name=newAssetfamily.Name;
                existAssetFamily.ParentAssetFamilyId=newAssetfamily.ParentAssetFamilyId;
                existAssetFamily.ExternalAssetFamilyId=newAssetfamily.ExternalAssetFamilyId;
                _context.Assetfamilies.Update(existAssetFamily);
                _context.SaveChanges();
                return newAssetfamily;
            }

            throw new Exception("asset family not fount !");
        }
        public async void process(ProductCategory odooCategory)
        {
            RpcConnection conn = GetConnection();
            var assetFamilyId =CreateorUpdateAssetFamily(odooCategory);

            // Retrieve children categories of the current category
            var odooCategoryChildren =await GetProductChildren(conn,odooCategory.Id);

            // Recursively process children categories
            foreach (var child in odooCategoryChildren)
            {
                // Set ParentId to the newly inserted AssetFamilyId
                child.ParentId = assetFamilyId;

                // Recursively insert child category and its descendants
                process(child);
            }
        }
        // insert the categories to leocia database
        public int CreateorUpdateAssetFamily(ProductCategory odooCategory)
        {
            // Check if Assetfamily with the same name exists
            var existingAssetFamily = _context.Assetfamilies
                .FirstOrDefault(a => a.ExternalAssetFamilyId == odooCategory.Id.ToString());

            if (existingAssetFamily != null)
            {
                // Update the existing Assetfamily
                existingAssetFamily.ParentAssetFamilyId = odooCategory.ParentId;
                existingAssetFamily.ExternalAssetFamilyId = odooCategory.Id.ToString();
                existingAssetFamily.IsDeleted = false; // Ensure it's not deleted
                _context.SaveChanges();
                return existingAssetFamily.AssetFamilyId;
            }
            else
            {
                    // Create new
                    var assetfamily = new Assetfamily
                    {
                        Name = odooCategory.Name,
                        ParentAssetFamilyId = odooCategory.ParentId,
                        ExternalAssetFamilyId = odooCategory.Id.ToString(),
                        IsDeleted = false,
                    };
                    _context.Assetfamilies.Add(assetfamily);
                    _context.SaveChanges();
                    return assetfamily.AssetFamilyId;
            }





        }
    }
}
