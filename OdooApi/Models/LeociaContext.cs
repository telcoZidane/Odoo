using System;
using System.Collections.Generic;
using Core.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace OdooApi.Models;

public partial class LeociaContext : DbContext
{
    public LeociaContext()
    {
    }

    public LeociaContext(DbContextOptions<LeociaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Assetfamily> Assetfamilies { get; set; }
    public virtual DbSet<HrEmployee> HrEmployees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Assetfamily>(entity =>
        {
            entity.ToTable("ASSETFAMILY");

            entity.Property(e => e.AssetFamilyId).HasColumnName("AssetFamilyID");
            entity.Property(e => e.ClientId).HasColumnName("ClientID");
            entity.Property(e => e.ExternalAssetFamilyId).HasColumnName("ExternalAssetFamilyID");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.ParentAssetFamilyId).HasColumnName("ParentAssetFamilyID");
            entity.Property(e => e.Type).HasMaxLength(50);

            entity.HasOne(d => d.ParentAssetFamily).WithMany(p => p.InverseParentAssetFamily)
                .HasForeignKey(d => d.ParentAssetFamilyId)
                .HasConstraintName("FK_ASSETFAMILY_ASSETFAMILY");
        });
        modelBuilder.Entity<HrEmployee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hr_employee_pkey");

            entity.ToTable("hr_employee", tb => tb.HasComment("Employee"));

            entity.HasIndex(e => e.Barcode, "hr_employee_barcode_uniq").IsUnique();

            entity.HasIndex(e => e.CompanyId, "hr_employee_company_id_index");

            entity.HasIndex(e => e.ResourceCalendarId, "hr_employee_resource_calendar_id_index");

            entity.HasIndex(e => e.ResourceId, "hr_employee_resource_id_index");

            entity.HasIndex(e => new { e.UserId, e.CompanyId }, "hr_employee_user_uniq").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active)
                .HasComment("Active")
                .HasColumnName("active");
            entity.Property(e => e.AdditionalNote)
                .HasComment("Additional Note")
                .HasColumnName("additional_note");
            entity.Property(e => e.AddressHomeId)
                .HasComment("Address")
                .HasColumnName("address_home_id");
            entity.Property(e => e.AddressId)
                .HasComment("Work Address")
                .HasColumnName("address_id");
            entity.Property(e => e.BankAccountId)
                .HasComment("Bank Account Number")
                .HasColumnName("bank_account_id");
            entity.Property(e => e.Barcode)
                .HasComment("Badge ID")
                .HasColumnType("character varying")
                .HasColumnName("barcode");
            entity.Property(e => e.Birthday)
                .HasComment("Date of Birth")
                .HasColumnName("birthday");
            entity.Property(e => e.Certificate)
                .HasComment("Certificate Level")
                .HasColumnType("character varying")
                .HasColumnName("certificate");
            entity.Property(e => e.Children)
                .HasComment("Number of Dependent Children")
                .HasColumnName("children");
            entity.Property(e => e.CoachId)
                .HasComment("Coach")
                .HasColumnName("coach_id");
            entity.Property(e => e.Color)
                .HasComment("Color Index")
                .HasColumnName("color");
            entity.Property(e => e.CompanyId)
                .HasComment("Company")
                .HasColumnName("company_id");
            entity.Property(e => e.ContractId)
                .HasComment("Current Contract")
                .HasColumnName("contract_id");
            entity.Property(e => e.ContractWarning)
                .HasComment("Contract Warning")
                .HasColumnName("contract_warning");
            entity.Property(e => e.CountryId)
                .HasComment("Nationality (Country)")
                .HasColumnName("country_id");
            entity.Property(e => e.CountryOfBirth)
                .HasComment("Country of Birth")
                .HasColumnName("country_of_birth");
            entity.Property(e => e.CreateDate)
                .HasComment("Created on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("create_date");
            entity.Property(e => e.CreateUid)
                .HasComment("Created by")
                .HasColumnName("create_uid");
            entity.Property(e => e.DepartmentId)
                .HasComment("Department")
                .HasColumnName("department_id");
            entity.Property(e => e.DepartureDate)
                .HasComment("Departure Date")
                .HasColumnName("departure_date");
            entity.Property(e => e.DepartureDescription)
                .HasComment("Additional Information")
                .HasColumnName("departure_description");
            entity.Property(e => e.DepartureReasonId)
                .HasComment("Departure Reason")
                .HasColumnName("departure_reason_id");
            entity.Property(e => e.EmergencyContact)
                .HasComment("Contact Name")
                .HasColumnType("character varying")
                .HasColumnName("emergency_contact");
            entity.Property(e => e.EmergencyPhone)
                .HasComment("Contact Phone")
                .HasColumnType("character varying")
                .HasColumnName("emergency_phone");
            entity.Property(e => e.EmployeeType)
                .HasComment("Employee Type")
                .HasColumnType("character varying")
                .HasColumnName("employee_type");
            entity.Property(e => e.ExpenseManagerId)
                .HasComment("Expense")
                .HasColumnName("expense_manager_id");
            entity.Property(e => e.FirstContractDate)
                .HasComment("First Contract Date")
                .HasColumnName("first_contract_date");
            entity.Property(e => e.Gender)
                .HasComment("Gender")
                .HasColumnType("character varying")
                .HasColumnName("gender");
            entity.Property(e => e.IdentificationId)
                .HasComment("Identification No")
                .HasColumnType("character varying")
                .HasColumnName("identification_id");
            entity.Property(e => e.JobId)
                .HasComment("Job Position")
                .HasColumnName("job_id");
            entity.Property(e => e.JobTitle)
                .HasComment("Job Title")
                .HasColumnType("character varying")
                .HasColumnName("job_title");
            entity.Property(e => e.KmHomeWork)
                .HasComment("Home-Work Distance")
                .HasColumnName("km_home_work");
            entity.Property(e => e.LastAttendanceId)
                .HasComment("Last Attendance")
                .HasColumnName("last_attendance_id");
            entity.Property(e => e.LastCheckIn)
                .HasComment("Check In")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_check_in");
            entity.Property(e => e.LastCheckOut)
                .HasComment("Check Out")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("last_check_out");
            entity.Property(e => e.LeaveManagerId)
                .HasComment("Time Off")
                .HasColumnName("leave_manager_id");
            entity.Property(e => e.Marital)
                .HasComment("Marital Status")
                .HasColumnType("character varying")
                .HasColumnName("marital");
            entity.Property(e => e.MessageMainAttachmentId)
                .HasComment("Main Attachment")
                .HasColumnName("message_main_attachment_id");
            entity.Property(e => e.MobilePhone)
                .HasComment("Work Mobile")
                .HasColumnType("character varying")
                .HasColumnName("mobile_phone");
            entity.Property(e => e.MobilityCard)
                .HasComment("Mobility Card")
                .HasColumnType("character varying")
                .HasColumnName("mobility_card");
            entity.Property(e => e.Name)
                .HasComment("Employee Name")
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Notes)
                .HasComment("Notes")
                .HasColumnName("notes");
            entity.Property(e => e.ParentId)
                .HasComment("Manager")
                .HasColumnName("parent_id");
            entity.Property(e => e.PassportId)
                .HasComment("Passport No")
                .HasColumnType("character varying")
                .HasColumnName("passport_id");
            entity.Property(e => e.PermitNo)
                .HasComment("Work Permit No")
                .HasColumnType("character varying")
                .HasColumnName("permit_no");
            entity.Property(e => e.Pin)
                .HasComment("PIN")
                .HasColumnType("character varying")
                .HasColumnName("pin");
            entity.Property(e => e.PlaceOfBirth)
                .HasComment("Place of Birth")
                .HasColumnType("character varying")
                .HasColumnName("place_of_birth");
            entity.Property(e => e.ResourceCalendarId)
                .HasComment("Working Hours")
                .HasColumnName("resource_calendar_id");
            entity.Property(e => e.ResourceId)
                .HasComment("Resource")
                .HasColumnName("resource_id");
            entity.Property(e => e.Sinid)
                .HasComment("SIN No")
                .HasColumnType("character varying")
                .HasColumnName("sinid");
            entity.Property(e => e.SpouseBirthdate)
                .HasComment("Spouse Birthdate")
                .HasColumnName("spouse_birthdate");
            entity.Property(e => e.SpouseCompleteName)
                .HasComment("Spouse Complete Name")
                .HasColumnType("character varying")
                .HasColumnName("spouse_complete_name");
            entity.Property(e => e.Ssnid)
                .HasComment("SSN No")
                .HasColumnType("character varying")
                .HasColumnName("ssnid");
            entity.Property(e => e.StudyField)
                .HasComment("Field of Study")
                .HasColumnType("character varying")
                .HasColumnName("study_field");
            entity.Property(e => e.StudySchool)
                .HasComment("School")
                .HasColumnType("character varying")
                .HasColumnName("study_school");
            entity.Property(e => e.UserId)
                .HasComment("User")
                .HasColumnName("user_id");
            entity.Property(e => e.Vehicle)
                .HasComment("Company Vehicle")
                .HasColumnType("character varying")
                .HasColumnName("vehicle");
            entity.Property(e => e.VisaExpire)
                .HasComment("Visa Expire Date")
                .HasColumnName("visa_expire");
            entity.Property(e => e.VisaNo)
                .HasComment("Visa No")
                .HasColumnType("character varying")
                .HasColumnName("visa_no");
            entity.Property(e => e.WorkContactId)
                .HasComment("Work Contact")
                .HasColumnName("work_contact_id");
            entity.Property(e => e.WorkEmail)
                .HasComment("Work Email")
                .HasColumnType("character varying")
                .HasColumnName("work_email");
            entity.Property(e => e.WorkLocationId)
                .HasComment("Work Location")
                .HasColumnName("work_location_id");
            entity.Property(e => e.WorkPermitExpirationDate)
                .HasComment("Work Permit Expiration Date")
                .HasColumnName("work_permit_expiration_date");
            entity.Property(e => e.WorkPermitScheduledActivity)
                .HasComment("Work Permit Scheduled Activity")
                .HasColumnName("work_permit_scheduled_activity");
            entity.Property(e => e.WorkPhone)
                .HasComment("Work Phone")
                .HasColumnType("character varying")
                .HasColumnName("work_phone");
            entity.Property(e => e.WriteDate)
                .HasComment("Last Updated on")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("write_date");
            entity.Property(e => e.WriteUid)
                .HasComment("Last Updated by")
                .HasColumnName("write_uid");

            entity.HasOne(d => d.AddressHome).WithMany(p => p.HrEmployeeAddressHomes)
                .HasForeignKey(d => d.AddressHomeId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_address_home_id_fkey");

            entity.HasOne(d => d.Address).WithMany(p => p.HrEmployeeAddresses)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_address_id_fkey");

            entity.HasOne(d => d.BankAccount).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.BankAccountId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_bank_account_id_fkey");

            entity.HasOne(d => d.Coach).WithMany(p => p.InverseCoach)
                .HasForeignKey(d => d.CoachId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_coach_id_fkey");

            entity.HasOne(d => d.Company).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_company_id_fkey");

            entity.HasOne(d => d.Contract).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.ContractId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_contract_id_fkey");

            entity.HasOne(d => d.Country).WithMany(p => p.HrEmployeeCountries)
                .HasForeignKey(d => d.CountryId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_country_id_fkey");

            entity.HasOne(d => d.CountryOfBirthNavigation).WithMany(p => p.HrEmployeeCountryOfBirthNavigations)
                .HasForeignKey(d => d.CountryOfBirth)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_country_of_birth_fkey");

            entity.HasOne(d => d.CreateU).WithMany(p => p.HrEmployeeCreateUs)
                .HasForeignKey(d => d.CreateUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_create_uid_fkey");

            entity.HasOne(d => d.Department).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_department_id_fkey");

            entity.HasOne(d => d.DepartureReason).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.DepartureReasonId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_departure_reason_id_fkey");

            entity.HasOne(d => d.ExpenseManager).WithMany(p => p.HrEmployeeExpenseManagers)
                .HasForeignKey(d => d.ExpenseManagerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_expense_manager_id_fkey");

            entity.HasOne(d => d.Job).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.JobId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_job_id_fkey");

            entity.HasOne(d => d.LastAttendance).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.LastAttendanceId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_last_attendance_id_fkey");

            entity.HasOne(d => d.LeaveManager).WithMany(p => p.HrEmployeeLeaveManagers)
                .HasForeignKey(d => d.LeaveManagerId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_leave_manager_id_fkey");

            entity.HasOne(d => d.MessageMainAttachment).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.MessageMainAttachmentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_message_main_attachment_id_fkey");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_parent_id_fkey");

            entity.HasOne(d => d.ResourceCalendar).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.ResourceCalendarId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_resource_calendar_id_fkey");

            entity.HasOne(d => d.Resource).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.ResourceId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("hr_employee_resource_id_fkey");

            entity.HasOne(d => d.User).WithMany(p => p.HrEmployeeUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_user_id_fkey");

            entity.HasOne(d => d.WorkContact).WithMany(p => p.HrEmployeeWorkContacts)
                .HasForeignKey(d => d.WorkContactId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_work_contact_id_fkey");

            entity.HasOne(d => d.WorkLocation).WithMany(p => p.HrEmployees)
                .HasForeignKey(d => d.WorkLocationId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_work_location_id_fkey");

            entity.HasOne(d => d.WriteU).WithMany(p => p.HrEmployeeWriteUs)
                .HasForeignKey(d => d.WriteUid)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("hr_employee_write_uid_fkey");

            entity.HasMany(d => d.Categories).WithMany(p => p.Emps)
                .UsingEntity<Dictionary<string, object>>(
                    "EmployeeCategoryRel",
                    r => r.HasOne<HrEmployeeCategory>().WithMany()
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("employee_category_rel_category_id_fkey"),
                    l => l.HasOne<HrEmployee>().WithMany()
                        .HasForeignKey("EmpId")
                        .HasConstraintName("employee_category_rel_emp_id_fkey"),
                    j =>
                    {
                        j.HasKey("EmpId", "CategoryId").HasName("employee_category_rel_pkey");
                        j.ToTable("employee_category_rel", tb => tb.HasComment("RELATION BETWEEN hr_employee AND hr_employee_category"));
                        j.HasIndex(new[] { "CategoryId", "EmpId" }, "employee_category_rel_category_id_emp_id_idx");
                        j.IndexerProperty<int>("EmpId").HasColumnName("emp_id");
                        j.IndexerProperty<int>("CategoryId").HasColumnName("category_id");
                    });

            entity.HasMany(d => d.HrSkills).WithMany(p => p.HrEmployees)
                .UsingEntity<Dictionary<string, object>>(
                    "HrEmployeeHrSkillRel",
                    r => r.HasOne<HrSkill>().WithMany()
                        .HasForeignKey("HrSkillId")
                        .HasConstraintName("hr_employee_hr_skill_rel_hr_skill_id_fkey"),
                    l => l.HasOne<HrEmployee>().WithMany()
                        .HasForeignKey("HrEmployeeId")
                        .HasConstraintName("hr_employee_hr_skill_rel_hr_employee_id_fkey"),
                    j =>
                    {
                        j.HasKey("HrEmployeeId", "HrSkillId").HasName("hr_employee_hr_skill_rel_pkey");
                        j.ToTable("hr_employee_hr_skill_rel", tb => tb.HasComment("RELATION BETWEEN hr_employee AND hr_skill"));
                        j.HasIndex(new[] { "HrSkillId", "HrEmployeeId" }, "hr_employee_hr_skill_rel_hr_skill_id_hr_employee_id_idx");
                        j.IndexerProperty<int>("HrEmployeeId").HasColumnName("hr_employee_id");
                        j.IndexerProperty<int>("HrSkillId").HasColumnName("hr_skill_id");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
