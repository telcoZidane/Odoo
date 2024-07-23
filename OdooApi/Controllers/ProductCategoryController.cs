using Core.Core.Context;
using Core.Core.Entities;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Odoo.Concrete;
using OdooApi.Data.Dtos.ProductCategory;
using OdooApi.Data.Services;
using OdooApi.Models;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace OdooApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        public ServiceInit serviceInit;
        private readonly LeociaContext _context;
        private readonly ProductFamilyService _productFamilyService;

        public ProductCategoryController(ServiceInit serviceInit, LeociaContext context, ProductFamilyService productFamilyService)
        {
            this.serviceInit = serviceInit;
            _context = context;
            _productFamilyService = productFamilyService;
        }

        //Get connection
        [HttpGet("connection")]
        public RpcConnection GetConnection()
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            var rpcConnnectionSettings = new RpcConnectionSetting();

            config.GetSection("OdooConnection").Bind(rpcConnnectionSettings);

            //Connection
            var conn = new RpcConnection(rpcConnnectionSettings);
            return conn;
        }
        //Get employee
        [HttpGet("GetProductCategories")]
        public async Task<IActionResult> GetProductCategories()
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.ProductCategory;

                var productCategories = await serviceInit.Product_CategoryService.GetProductCategories(conn);
                return Ok(productCategories);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
 
        //Get employee
        [HttpGet("GetProductCategory/{id}")]
        public async Task<IActionResult> GetProductCategory(int id)
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.ProductCategory;

                var productCategoryChildren = await _productFamilyService.GetProductChildren(conn,id);
                return Ok(productCategoryChildren);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        //Get employee
        [HttpGet("GetFamilies")]
        public async Task<IActionResult> GetFamilies()
        {
            try
            {
                var productCategories = await _context.Assetfamilies.ToListAsync();
                return Ok(productCategories);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        [HttpPost("CreateFamilies")]
        public async Task<IActionResult> CreateAssetFamilyAndChildren()
        {
            try
            {
                RpcConnection conn = GetConnection();
                EnumsOdoo model = EnumsOdoo.ProductCategory;

                //AssetFamily list
                var assetFamilies = await _context.Assetfamilies.ToListAsync();

                var productCategories = await serviceInit.Product_CategoryService.GetProductCategories(conn);
                var categorieswithoutParent= productCategories.Where(c => c.ParentId ==null).ToList();
                foreach(var category in categorieswithoutParent)
                {
                    _productFamilyService.process(category);
                }  
                // mark IsDeleted as true if the assetfamily didn't exist in productCategory 
                foreach (var assetFamily in assetFamilies)
                {
                    bool categoryExists = productCategories.Any(pc => pc.Name == assetFamily.Name);
                    if (!categoryExists)
                    {
                        assetFamily.IsDeleted = true;
                        // Update the IsDeleted
                        _productFamilyService.UpdateAssetFamily(assetFamily);
                    }
                }
                return Ok("Categories inserted successfully.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
        // Get products categories and asign them to assetsfamilies in LEOCIA
        //[HttpPost("CreateFamilies")]
        //public async Task<IActionResult> CreateFamilies()
        //{
        //    try
        //    {
        //        //AssetFamily list
        //        var assetFamilies = await _context.Assetfamilies.ToListAsync();

        //        // product Category list
        //        RpcConnection conn = GetConnection();
        //        EnumsOdoo model = EnumsOdoo.ProductCategory;
        //        var productCategories = await serviceInit.Product_CategoryService.GetProductCategories(conn);

        //        // loop productCatgories , asign them to assetsfamilies in LEOCIA
        //        foreach (var productCategory in productCategories)
        //        {
        //            // see if the category exist in assetfamily to avoid duplicate category
        //            bool categoryExists = assetFamilies.Any(a => a.Name == productCategory.Name && a.ParentAssetFamilyId == productCategory.ParentId);
        //            // if category didn't exist , create new 
        //            if (!categoryExists)
        //            {
        //                var newAssetFamily = new Assetfamily
        //                {
        //                    Name = productCategory.Name,
        //                    ParentAssetFamilyId = productCategory.ParentId,
        //                    ExternalAssetFamilyId = productCategory.Id.ToString(),
        //                    IsDeleted= false,
        //                };
        //                _productFamilyService.CreateAssetFamily(newAssetFamily);
        //            }
        //            // if category already exist , update it 
        //            else
        //            {
        //                var existingAssetFamily = assetFamilies.FirstOrDefault(a => a.Name == productCategory.Name && a.ParentAssetFamilyId==productCategory.ParentId);
        //                if (existingAssetFamily != null)
        //                {
        //                    // update properties
        //                    existingAssetFamily.Name = productCategory.Name;
        //                    existingAssetFamily.ParentAssetFamilyId = productCategory.ParentId;
        //                    existingAssetFamily.ExternalAssetFamilyId = productCategory.Id.ToString();
        //                    existingAssetFamily.IsDeleted = false;
        //                    // Call update method from service to update the Assetfamily
        //                    _productFamilyService.UpdateAssetFamily(existingAssetFamily);
        //                }
        //                else
        //                {
        //                    return BadRequest("Not found");
        //                }
        //            }
        //        }
        //        // mark IsDeleted as true if the assetfamily didn't exist in productCategory 
        //        foreach (var assetFamily in assetFamilies)
        //        {
        //            bool categoryExists = productCategories.Any(pc => pc.Name == assetFamily.Name && pc.ParentId == assetFamily.ParentAssetFamilyId);
        //            if (!categoryExists)
        //            {
        //                assetFamily.IsDeleted = true;
        //                // Update the IsDeleted
        //                _productFamilyService.UpdateAssetFamily(assetFamily); 
        //            }
        //        }
        //        return Ok(assetFamilies);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message, ex);
        //    }
        //}
    }
}
