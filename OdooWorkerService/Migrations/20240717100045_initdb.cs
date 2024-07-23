using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdooWorkerService.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hrEmployees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResourceId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    ResourceCalendarId = table.Column<int>(type: "int", nullable: true),
                    MessageMainAttachmentId = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: true),
                    WorkContactId = table.Column<int>(type: "int", nullable: true),
                    WorkLocationId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    CoachId = table.Column<int>(type: "int", nullable: true),
                    AddressHomeId = table.Column<int>(type: "int", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: true),
                    Children = table.Column<int>(type: "int", nullable: true),
                    CountryOfBirth = table.Column<int>(type: "int", nullable: true),
                    BankAccountId = table.Column<int>(type: "int", nullable: true),
                    KmHomeWork = table.Column<int>(type: "int", nullable: true),
                    DepartureReasonId = table.Column<int>(type: "int", nullable: true),
                    CreateUid = table.Column<int>(type: "int", nullable: true),
                    WriteUid = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobilePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marital = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpouseCompleteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ssnid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sinid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdentificationId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PassportId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PermitNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisaNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Certificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudyField = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudySchool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyContact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmergencyPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpouseBirthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VisaExpire = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WorkPermitExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DepartureDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdditionalNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartureDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Active = table.Column<bool>(type: "bit", nullable: true),
                    WorkPermitScheduledActivity = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    WriteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractId = table.Column<int>(type: "int", nullable: true),
                    Vehicle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstContractDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ContractWarning = table.Column<bool>(type: "bit", nullable: true),
                    ExpenseManagerId = table.Column<int>(type: "int", nullable: true),
                    LeaveManagerId = table.Column<int>(type: "int", nullable: true),
                    MobilityCard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastAttendanceId = table.Column<int>(type: "int", nullable: true),
                    LastCheckIn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastCheckOut = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hrEmployees", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "hrEmployees");
        }
    }
}
