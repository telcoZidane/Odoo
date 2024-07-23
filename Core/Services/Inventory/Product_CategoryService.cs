using Core.Core.Entities;
using Core.Core.Utility.EnumOdoo;
using Core.Services.Employees;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Odoo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace Core.Services.Inventory
{
    public class Product_CategoryService
    {
       
        private ServiceMain serviceMain;
        public Product_CategoryService(ServiceMain serviceMain)
        {
            this.serviceMain = serviceMain;

        }
        // Fetch product categories list
        public async Task<List<ProductCategory>> GetProductCategories(RpcConnection conn)
        {
            var requests = new RpcContext(conn, EnumsOdoo.ProductCategory.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<ProductCategory>>(jsonResault);
            return listObjects.ToList();
        }

        // get department by id
        public async Task<ProductCategory> GetById(RpcConnection conn, int Id)
        {
            var requests = new RpcContext(conn, EnumsOdoo.ProductCategory.Value());
            requests.RpcFilter.Equal("id", Id);

            requests.AddField("id")
                .AddField("name")
                .AddField("parent_id");

            var data = requests.Execute(true, limit: 1);
            var result = data.FirstOrDefault();
            // mapping result with employee
            var productCategory = new ProductCategory
            {
                Id = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "id")),
                Name = serviceMain.GetFieldArrayValue(result, "name").ToString(),
                ParentId = Convert.ToInt32(serviceMain.GetFieldArrayValue(result, "parent_id")),
            };
            return productCategory;
        }
    }
}
