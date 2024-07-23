using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OdooWorkerService.Migrations
{
    /// <inheritdoc />
    public partial class addColumnOdooId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdOdoo",
                table: "hrEmployees",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdOdoo",
                table: "hrEmployees");
        }
    }
}
