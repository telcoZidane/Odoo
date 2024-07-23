using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Employee
/// </summary>
public partial class HrEmployee
{
    public int Id { get; set; }

    /// <summary>
    /// Resource
    /// </summary>
    public int ResourceId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int CompanyId { get; set; }

    /// <summary>
    /// Working Hours
    /// </summary>
    public int? ResourceCalendarId { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Color Index
    /// </summary>
    public int? Color { get; set; }

    /// <summary>
    /// Department
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// Job Position
    /// </summary>
    public int? JobId { get; set; }

    /// <summary>
    /// Work Address
    /// </summary>
    public int? AddressId { get; set; }

    /// <summary>
    /// Work Contact
    /// </summary>
    public int? WorkContactId { get; set; }

    /// <summary>
    /// Work Location
    /// </summary>
    public int? WorkLocationId { get; set; }

    /// <summary>
    /// User
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Manager
    /// </summary>
    public int? ParentId { get; set; }

    /// <summary>
    /// Coach
    /// </summary>
    public int? CoachId { get; set; }

    /// <summary>
    /// Address
    /// </summary>
    public int? AddressHomeId { get; set; }

    /// <summary>
    /// Nationality (Country)
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// Number of Dependent Children
    /// </summary>
    public int? Children { get; set; }

    /// <summary>
    /// Country of Birth
    /// </summary>
    public int? CountryOfBirth { get; set; }

    /// <summary>
    /// Bank Account Number
    /// </summary>
    public int? BankAccountId { get; set; }

    /// <summary>
    /// Home-Work Distance
    /// </summary>
    public int? KmHomeWork { get; set; }

    /// <summary>
    /// Departure Reason
    /// </summary>
    public int? DepartureReasonId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Employee Name
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Job Title
    /// </summary>
    public string? JobTitle { get; set; }

    /// <summary>
    /// Work Phone
    /// </summary>
    public string? WorkPhone { get; set; }

    /// <summary>
    /// Work Mobile
    /// </summary>
    public string? MobilePhone { get; set; }

    /// <summary>
    /// Work Email
    /// </summary>
    public string? WorkEmail { get; set; }

    /// <summary>
    /// Employee Type
    /// </summary>
    public string EmployeeType { get; set; } = null!;

    /// <summary>
    /// Gender
    /// </summary>
    public string? Gender { get; set; }

    /// <summary>
    /// Marital Status
    /// </summary>
    public string? Marital { get; set; }

    /// <summary>
    /// Spouse Complete Name
    /// </summary>
    public string? SpouseCompleteName { get; set; }

    /// <summary>
    /// Place of Birth
    /// </summary>
    public string? PlaceOfBirth { get; set; }

    /// <summary>
    /// SSN No
    /// </summary>
    public string? Ssnid { get; set; }

    /// <summary>
    /// SIN No
    /// </summary>
    public string? Sinid { get; set; }

    /// <summary>
    /// Identification No
    /// </summary>
    public string? IdentificationId { get; set; }

    /// <summary>
    /// Passport No
    /// </summary>
    public string? PassportId { get; set; }

    /// <summary>
    /// Work Permit No
    /// </summary>
    public string? PermitNo { get; set; }

    /// <summary>
    /// Visa No
    /// </summary>
    public string? VisaNo { get; set; }

    /// <summary>
    /// Certificate Level
    /// </summary>
    public string? Certificate { get; set; }

    /// <summary>
    /// Field of Study
    /// </summary>
    public string? StudyField { get; set; }

    /// <summary>
    /// School
    /// </summary>
    public string? StudySchool { get; set; }

    /// <summary>
    /// Contact Name
    /// </summary>
    public string? EmergencyContact { get; set; }

    /// <summary>
    /// Contact Phone
    /// </summary>
    public string? EmergencyPhone { get; set; }

    /// <summary>
    /// Badge ID
    /// </summary>
    public string? Barcode { get; set; }

    /// <summary>
    /// PIN
    /// </summary>
    public string? Pin { get; set; }

    /// <summary>
    /// Spouse Birthdate
    /// </summary>
    public DateOnly? SpouseBirthdate { get; set; }

    /// <summary>
    /// Date of Birth
    /// </summary>
    public DateOnly? Birthday { get; set; }

    /// <summary>
    /// Visa Expire Date
    /// </summary>
    public DateOnly? VisaExpire { get; set; }

    /// <summary>
    /// Work Permit Expiration Date
    /// </summary>
    public DateOnly? WorkPermitExpirationDate { get; set; }

    /// <summary>
    /// Departure Date
    /// </summary>
    public DateOnly? DepartureDate { get; set; }

    /// <summary>
    /// Additional Note
    /// </summary>
    public string? AdditionalNote { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// Additional Information
    /// </summary>
    public string? DepartureDescription { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Work Permit Scheduled Activity
    /// </summary>
    public bool? WorkPermitScheduledActivity { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Current Contract
    /// </summary>
    public int? ContractId { get; set; }

    /// <summary>
    /// Company Vehicle
    /// </summary>
    public string? Vehicle { get; set; }

    /// <summary>
    /// First Contract Date
    /// </summary>
    public DateOnly? FirstContractDate { get; set; }

    /// <summary>
    /// Contract Warning
    /// </summary>
    public bool? ContractWarning { get; set; }

    /// <summary>
    /// Expense
    /// </summary>
    public int? ExpenseManagerId { get; set; }

    /// <summary>
    /// Time Off
    /// </summary>
    public int? LeaveManagerId { get; set; }

    /// <summary>
    /// Mobility Card
    /// </summary>
    public string? MobilityCard { get; set; }

    /// <summary>
    /// Last Attendance
    /// </summary>
    public int? LastAttendanceId { get; set; }

    /// <summary>
    /// Check In
    /// </summary>
    public DateTime? LastCheckIn { get; set; }

    /// <summary>
    /// Check Out
    /// </summary>
    public DateTime? LastCheckOut { get; set; }

    public virtual ResPartner? Address { get; set; }//this Work Address

    public virtual ResPartner? AddressHome { get; set; }//this

    public virtual ResPartnerBank? BankAccount { get; set; }

    public virtual HrEmployee? Coach { get; set; }//this

    public virtual ResCompany Company { get; set; } = null!;

    public virtual HrContract? Contract { get; set; }

    public virtual ResCountry? Country { get; set; }

    public virtual ResCountry? CountryOfBirthNavigation { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual HrDepartment? Department { get; set; }//this

    public virtual HrDepartureReason? DepartureReason { get; set; }

    public virtual ResUser? ExpenseManager { get; set; }//this

    public virtual ICollection<FleetVehicleAssignationLog> FleetVehicleAssignationLogs { get; set; } = new List<FleetVehicleAssignationLog>();

    public virtual ICollection<FleetVehicle> FleetVehicleDriverEmployees { get; set; } = new List<FleetVehicle>();

    public virtual ICollection<FleetVehicle> FleetVehicleFutureDriverEmployees { get; set; } = new List<FleetVehicle>();

    public virtual ICollection<FleetVehicleLogService> FleetVehicleLogServices { get; set; } = new List<FleetVehicleLogService>();

    public virtual ICollection<GamificationBadgeUserWizard> GamificationBadgeUserWizards { get; set; } = new List<GamificationBadgeUserWizard>();

    public virtual ICollection<GamificationBadgeUser> GamificationBadgeUsers { get; set; } = new List<GamificationBadgeUser>();

    public virtual ICollection<HrApplicant> HrApplicants { get; set; } = new List<HrApplicant>();

    public virtual ICollection<HrAttendanceOvertime> HrAttendanceOvertimes { get; set; } = new List<HrAttendanceOvertime>();

    public virtual ICollection<HrAttendance> HrAttendances { get; set; } = new List<HrAttendance>();

    public virtual ICollection<HrContract> HrContracts { get; set; } = new List<HrContract>();

    public virtual ICollection<HrDepartment> HrDepartments { get; set; } = new List<HrDepartment>();

    public virtual ICollection<HrDepartureWizard> HrDepartureWizards { get; set; } = new List<HrDepartureWizard>();

    public virtual ICollection<HrEmployeeSkillLog> HrEmployeeSkillLogs { get; set; } = new List<HrEmployeeSkillLog>();

    public virtual ICollection<HrEmployeeSkill> HrEmployeeSkills { get; set; } = new List<HrEmployeeSkill>();

    public virtual ICollection<HrExpenseSheet> HrExpenseSheets { get; set; } = new List<HrExpenseSheet>();

    public virtual ICollection<HrExpenseSplit> HrExpenseSplits { get; set; } = new List<HrExpenseSplit>();

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();

    public virtual ICollection<HrJob> HrJobs { get; set; } = new List<HrJob>();//this

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationApprovers { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationEmployees { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocationManagers { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaveEmployees { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrLeave> HrLeaveFirstApprovers { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrLeave> HrLeaveManagers { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrLeave> HrLeaveSecondApprovers { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrResumeLine> HrResumeLines { get; set; } = new List<HrResumeLine>();//this Resume

    public virtual ICollection<HrEmployee> InverseCoach { get; set; } = new List<HrEmployee>();

    public virtual ICollection<HrEmployee> InverseParent { get; set; } = new List<HrEmployee>();

    public virtual HrJob? Job { get; set; }

    public virtual HrAttendance? LastAttendance { get; set; }

    public virtual ResUser? LeaveManager { get; set; }//this

    public virtual ICollection<MaintenanceEquipment> MaintenanceEquipments { get; set; } = new List<MaintenanceEquipment>();

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual HrEmployee? Parent { get; set; }//this

    public virtual ICollection<PosOrder> PosOrders { get; set; } = new List<PosOrder>();

    public virtual ResourceResource Resource { get; set; } = null!;

    public virtual ResourceCalendar? ResourceCalendar { get; set; }//this

    public virtual ResUser? User { get; set; }

    public virtual ResPartner? WorkContact { get; set; }

    public virtual HrWorkLocation? WorkLocation { get; set; }//this

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<HrEmployeeCategory> Categories { get; set; } = new List<HrEmployeeCategory>();

    public virtual ICollection<HrPlanWizard> Employees { get; set; } = new List<HrPlanWizard>();

    public virtual ICollection<HrLeaveAllocation> HrLeaveAllocations { get; set; } = new List<HrLeaveAllocation>();

    public virtual ICollection<HrLeave> HrLeaves { get; set; } = new List<HrLeave>();

    public virtual ICollection<HrSkill> HrSkills { get; set; } = new List<HrSkill>();//this skills

    public virtual ICollection<PosConfig> PosConfigs { get; set; } = new List<PosConfig>();

    public virtual ICollection<HrHolidaysSummaryEmployee> Sums { get; set; } = new List<HrHolidaysSummaryEmployee>();
}
