using Core.Services.Employees;
using Core.Services.Inventory;

namespace Core.Services
{
    public class ServiceInit
    {
        public ServiceInit
        (
            HrEmployeeService hrEmployeeService,
            HrDepartmentService hrDepartmentService,
            HrWorkLocationService hrWorkLocationService,
            HrDepartureReasonService hrDepartureReasonService,
            HrSkillService hrSkillService,
            HrJobService hrJobService,
            HrPlanService hrPlanService,
            HrEmployeeCategoryService hrEmployeeCategoryService,
            Product_CategoryService product_CategoryService
        )
        {
            this.hrEmployeeService = hrEmployeeService;
            this.hrDepartmentService = hrDepartmentService;
            this.hrWorkLocationService = hrWorkLocationService;
            this.hrDepartureReasonService = hrDepartureReasonService;
            this.hrSkillService = hrSkillService;
            this.hrJobService = hrJobService;
            this.hrPlanService = hrPlanService;
            this.hrEmployeeCategoryService = hrEmployeeCategoryService;
            this.Product_CategoryService = product_CategoryService;
        }
         
        public HrEmployeeService hrEmployeeService { get; set; }
        public HrDepartmentService hrDepartmentService { get; set; }
        public HrWorkLocationService hrWorkLocationService { get; set; }
        public HrDepartureReasonService hrDepartureReasonService { get; set; }
        public HrSkillService hrSkillService { get; set; }
        public HrJobService hrJobService { get; set; }
        public HrPlanService hrPlanService { get; set; }
        public HrEmployeeCategoryService hrEmployeeCategoryService { get; set; }
        public Product_CategoryService Product_CategoryService { get; set; }
    }
}
