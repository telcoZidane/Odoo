using Core.Core.Entities;
using Core.Core.Utility.EnumOdoo;
using Newtonsoft.Json;
using Odoo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Core.Services.Employees
{
    public class HrEmployeeCategoryService
    {
        private readonly ServiceMain serviceMain;
        private readonly HrEmployeeService _employeeService;

        public HrEmployeeCategoryService(ServiceMain serviceMain, HrEmployeeService employeeService)
        {
            this.serviceMain = serviceMain;
            _employeeService = employeeService;
        }

        public async Task<List<HrEmployeeCategory>> GetHrEmpCategories(RpcConnection conn)
        {
            var employees = await _employeeService.GetHrEmployees(conn);

            var requests = new RpcContext(conn, EnumsOdoo.HrEmployeeCategory.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<HrEmployeeCategory>>(jsonResault);

            var empCats = (from empcat in listObjects
                        select new HrEmployeeCategory()
                        {
                           Id= empcat.Id,
                           Name= empcat.Name,
                           Color= empcat.Color,
                           CreateUid= empcat.CreateUid,
                           WriteUid= empcat.WriteUid,
                           CreateDate= empcat.CreateDate,
                           WriteDate= empcat.WriteDate,
                           
                        }).ToList();
            return empCats;
        }
    }
}
