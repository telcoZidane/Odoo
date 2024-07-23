using Core.Core.Entities;
using Core.Services;
using Odoo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace odooConsoleApp
{
    public class AssetFamilyService
    {
        private readonly ServiceInit serviceInit;
        private readonly LeociaAppContext _leociaAppContext;
        public AssetFamilyService(ServiceInit serviceInit, LeociaAppContext leociaAppContext)
        {
            this.serviceInit = serviceInit;
            _leociaAppContext = leociaAppContext;
        }
        public RpcConnection GetConnection()
        {
            var rpcConnnectionSettings = new RpcConnectionSetting
            {
                ServerUrl = "http://localhost:8069/",
                DbName = "gestionStock",
                DbUser = "teclosolution@gmail.com",
                DbPassword = "Admin123b",
                ImmediateLogin = true,
                ServerCertificateValidation = true,
            };
            //config.GetSection("OdooConnection").Bind(rpcConnnectionSettings);

            //Connection
            var odooConn = new RpcConnection(rpcConnnectionSettings);
            return odooConn;
        }

        public async Task processProductCategory()
        {
            try
            {
                RpcConnection odooconn = GetConnection();
                var OdooproductCategories = await serviceInit.Product_CategoryService.GetProductCategories(odooconn);
                var OdoocategorieswithoutParent = OdooproductCategories.Where(c => c.ParentId == null).ToList();
                foreach (var Odoocategory in OdoocategorieswithoutParent)
                {
                    await process(Odoocategory);

                    //Console.WriteLine($"ID: {Odoocategory.Id}, Name: {Odoocategory.Name}");
                }

                // mark IsDeleted as true if the assetfamily didn't exist in productCategory 
                //foreach (var assetFamily in assetFamilies)
                //{
                //    bool categoryExists = odooproductCategories.Any(pc => pc.Name == assetFamily.Name);
                //    if (!categoryExists)
                //    {
                //        assetFamily.IsDeleted = true;
                //        // Update the IsDeleted
                //        UpdateAssetFamily(assetFamily);
                //    }
                //}
                Console.WriteLine("Sync done");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
            

        }
        // get children
        public List<Assetfamily> getFamilies()
        {
            
                var assetfamilies = _leociaAppContext.Assetfamilies.ToList();
                foreach (var family in assetfamilies)
                {
                    Console.WriteLine("Id {0} , Name {1} ,Parent Asset Family Id {2} , Is Deleted {3}, External Asset Family Id {4} \n", family.AssetFamilyId, family.Name, family.ParentAssetFamilyId, family.IsDeleted, family.ExternalAssetFamilyId);
                }
                return assetfamilies;

            
        }
        public async Task<List<ProductCategory>> GetProductChildren(int id)
        {
            RpcConnection odooconn = GetConnection();
            EnumsOdoo model = EnumsOdoo.ProductCategory;

            var productCategories = await serviceInit.Product_CategoryService.GetProductCategories(odooconn);
            var productChildren = productCategories.Where(a => a.ParentId == id).ToList();
            return productChildren;
        }
        // insert the categories to leocia database
        public Assetfamily UpdateAssetFamily(Assetfamily newAssetfamily)
        {
            
                var existAssetFamily = _leociaAppContext.Assetfamilies.FirstOrDefault(a => a.AssetFamilyId == newAssetfamily.AssetFamilyId);
                if (existAssetFamily != null)
                {
                    existAssetFamily.Name = newAssetfamily.Name;
                    existAssetFamily.ParentAssetFamilyId = newAssetfamily.ParentAssetFamilyId;
                    existAssetFamily.ExternalAssetFamilyId = newAssetfamily.ExternalAssetFamilyId;
                    existAssetFamily.IsDeleted = newAssetfamily.IsDeleted;
                    _leociaAppContext.Assetfamilies.Update(existAssetFamily);
                    _leociaAppContext.SaveChanges();
                    return newAssetfamily;
                }

                throw new Exception("asset family not fount !");
            

        }
        public async Task process(ProductCategory odooCategory)
        {
            RpcConnection conn = GetConnection();
            var assetFamilyId = CreateorUpdateAssetFamily(odooCategory);

            // Retrieve children categories of the current category
            var odooCategoryChildren = await GetProductChildren(odooCategory.Id);

            // Recursively process children categories
            foreach (var child in odooCategoryChildren)
            {
                // Set ParentId to the newly inserted AssetFamilyId
                child.ParentId = assetFamilyId;

                // Recursively insert child category and its descendants
                await process(child);
            }

        }
        // insert the categories to leocia database
        public  int CreateorUpdateAssetFamily(ProductCategory odooCategory)
        {
            
                // Check if Assetfamily with the same name exists
                var existingAssetFamily = _leociaAppContext.Assetfamilies
                    .FirstOrDefault(a => a.ExternalAssetFamilyId == odooCategory.Id.ToString());

                if (existingAssetFamily != null)
                {
                    // Update the existing Assetfamily
                    existingAssetFamily.ParentAssetFamilyId = odooCategory.ParentId;
                    existingAssetFamily.ExternalAssetFamilyId = odooCategory.Id.ToString();
                    existingAssetFamily.IsDeleted = false; // Ensure it's not deleted
                    _leociaAppContext.SaveChanges();
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
                    _leociaAppContext.Assetfamilies.Add(assetfamily);
                    _leociaAppContext.SaveChanges();
                    return assetfamily.AssetFamilyId;
                }

        }
        
    }
}
