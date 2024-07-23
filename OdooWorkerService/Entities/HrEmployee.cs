using System;
using System.Collections.Generic;

namespace OdooWorkerService.Entities;

/// <summary>
/// Employee
/// </summary>
public partial class HrEmployee
{
    public int Id { get; set; }

    /// <summary>
    /// Resource
    /// </summary>

    public int IdOdoo { get; set; }

    /// <summary>
    /// Resource
    /// </summary>
    /// 
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
    public DateTime? SpouseBirthdate { get; set; }

    /// <summary>
    /// Date of Birth
    /// </summary>
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// Visa Expire Date
    /// </summary>
    public DateTime? VisaExpire { get; set; }

    /// <summary>
    /// Work Permit Expiration Date
    /// </summary>
    public DateTime? WorkPermitExpirationDate { get; set; }

    /// <summary>
    /// Departure Date
    /// </summary>
    public DateTime? DepartureDate { get; set; }

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
    public DateTime? FirstContractDate { get; set; }

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


}
