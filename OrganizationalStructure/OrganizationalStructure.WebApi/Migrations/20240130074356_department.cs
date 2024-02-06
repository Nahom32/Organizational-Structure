using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrganizationalStructure.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class department : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Departments_ManagingDepartmentId",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "department");

            migrationBuilder.RenameColumn(
                name: "ManagingDepartmentId",
                table: "department",
                newName: "managing_dept_id");

            migrationBuilder.RenameColumn(
                name: "DepartmentName",
                table: "department",
                newName: "department_name");

            migrationBuilder.RenameIndex(
                name: "IX_Departments_ManagingDepartmentId",
                table: "department",
                newName: "IX_department_managing_dept_id");

            migrationBuilder.AlterColumn<string>(
                name: "department_name",
                table: "department",
                type: "character varying(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_department",
                table: "department",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_department_department_managing_dept_id",
                table: "department",
                column: "managing_dept_id",
                principalTable: "department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_department_managing_dept_id",
                table: "department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_department",
                table: "department");

            migrationBuilder.RenameTable(
                name: "department",
                newName: "Departments");

            migrationBuilder.RenameColumn(
                name: "managing_dept_id",
                table: "Departments",
                newName: "ManagingDepartmentId");

            migrationBuilder.RenameColumn(
                name: "department_name",
                table: "Departments",
                newName: "DepartmentName");

            migrationBuilder.RenameIndex(
                name: "IX_department_managing_dept_id",
                table: "Departments",
                newName: "IX_Departments_ManagingDepartmentId");

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Departments",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(10)",
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Departments_ManagingDepartmentId",
                table: "Departments",
                column: "ManagingDepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
