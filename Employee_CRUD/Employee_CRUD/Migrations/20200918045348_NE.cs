using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee_CRUD.Migrations
{
    public partial class NE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nvarchar(250)",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "varchar(250)",
                table: "Employees",
                newName: "EmpCode");

            migrationBuilder.AddColumn<string>(
                name: "OfficeLocation",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfficeLocation",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "nvarchar(250)");

            migrationBuilder.RenameColumn(
                name: "EmpCode",
                table: "Employees",
                newName: "varchar(250)");
        }
    }
}
