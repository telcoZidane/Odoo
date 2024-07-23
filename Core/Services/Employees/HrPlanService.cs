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

namespace Core.Services.Employees
{
    public class HrPlanService
    {
        private ServiceMain serviceMain;
        public HrPlanService(ServiceMain serviceMain)
        {

            this.serviceMain = serviceMain;

        }
        public async Task<List<HrPlan>> GetHrPlans(RpcConnection conn)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrPlan.Value()).Execute(true);
            var requestHrPlanActivityType = new RpcContext(conn, EnumsOdoo.HrPlanActivityType.Value()).Execute(true);

            var jsonResaultHrPlan = serviceMain.RpcContextToJson(requests);
            var jsonResaultHrPlanActivityType = serviceMain.RpcContextToJson(requestHrPlanActivityType);

            var listObjectHrPlan = JsonConvert.DeserializeObject<List<HrPlan>>(jsonResaultHrPlan);
            var listObjectHrPlanActivityType = JsonConvert.DeserializeObject<List<HrPlanActivityType>>(jsonResaultHrPlanActivityType);

            var list = (from HP in listObjectHrPlan
                       select new HrPlan()
                       {
                           Id = HP.Id,
                           CompanyId = HP.CompanyId,
                           DepartmentId = HP.DepartmentId,
                           CreateUid = HP.CreateUid,
                           CreateU = HP.CreateU,
                           CreateDate = HP.CreateDate,
                           WriteUid = HP.WriteUid,
                           WriteU = HP.WriteU,
                           WriteDate = HP.WriteDate,
                           Name = HP.Name,
                           Active = HP.Active,
                           Department = HP.Department,
                           Company = HP.Company,
                           HrPlanActivityTypes = listObjectHrPlanActivityType.Where(w=>w.PlanId == HP.Id).ToList(),
                           HrPlanWizards = HP.HrPlanWizards
                       }).ToList();

            return list.ToList();
        }

        public async Task<List<HrPlan>> GetPlans(RpcConnection conn)
        {
            var requests = new RpcContext(conn, EnumsOdoo.HrPlan.Value()).Execute(true);
            var jsonResault = serviceMain.RpcContextToJson(requests);
            var listObjects = JsonConvert.DeserializeObject<List<HrPlan>>(jsonResault);
            return listObjects.ToList();
        }
    }
}
