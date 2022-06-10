using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Vacations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "Requests",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "JobTitles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BranchOfficeId",
                table: "ItemsToRent",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "ItemsToRent",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "Hints",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "AccessPermitions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vacations_EmployeeId",
                table: "Vacations",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CompanyId",
                table: "Requests",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitles_EmployeeId",
                table: "JobTitles",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsToRent_BranchOfficeId",
                table: "ItemsToRent",
                column: "BranchOfficeId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemsToRent_EmployeeId",
                table: "ItemsToRent",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hints_CompanyId",
                table: "Hints",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AccessPermitions_CompanyId",
                table: "AccessPermitions",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccessPermitions_Companies_CompanyId",
                table: "AccessPermitions",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hints_Companies_CompanyId",
                table: "Hints",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsToRent_BranchOffices_BranchOfficeId",
                table: "ItemsToRent",
                column: "BranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsToRent_Employee_EmployeeId",
                table: "ItemsToRent",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTitles_Employee_EmployeeId",
                table: "JobTitles",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Requests_Companies_CompanyId",
                table: "Requests",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vacations_Employee_EmployeeId",
                table: "Vacations",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccessPermitions_Companies_CompanyId",
                table: "AccessPermitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Hints_Companies_CompanyId",
                table: "Hints");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsToRent_BranchOffices_BranchOfficeId",
                table: "ItemsToRent");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsToRent_Employee_EmployeeId",
                table: "ItemsToRent");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTitles_Employee_EmployeeId",
                table: "JobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_Requests_Companies_CompanyId",
                table: "Requests");

            migrationBuilder.DropForeignKey(
                name: "FK_Vacations_Employee_EmployeeId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Vacations_EmployeeId",
                table: "Vacations");

            migrationBuilder.DropIndex(
                name: "IX_Requests_CompanyId",
                table: "Requests");

            migrationBuilder.DropIndex(
                name: "IX_JobTitles_EmployeeId",
                table: "JobTitles");

            migrationBuilder.DropIndex(
                name: "IX_ItemsToRent_BranchOfficeId",
                table: "ItemsToRent");

            migrationBuilder.DropIndex(
                name: "IX_ItemsToRent_EmployeeId",
                table: "ItemsToRent");

            migrationBuilder.DropIndex(
                name: "IX_Hints_CompanyId",
                table: "Hints");

            migrationBuilder.DropIndex(
                name: "IX_AccessPermitions_CompanyId",
                table: "AccessPermitions");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Vacations");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "JobTitles");

            migrationBuilder.DropColumn(
                name: "BranchOfficeId",
                table: "ItemsToRent");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "ItemsToRent");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Hints");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "AccessPermitions");
        }
    }
}
