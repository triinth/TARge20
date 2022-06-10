using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TARge20.Data.Migrations
{
    public partial class New2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsToRent_BranchOffices_BranchOfficeId",
                table: "ItemsToRent");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsToRent_Employee_EmployeeId",
                table: "ItemsToRent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsToRent",
                table: "ItemsToRent");

            migrationBuilder.RenameTable(
                name: "ItemsToRent",
                newName: "ItemsToRents");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsToRent_EmployeeId",
                table: "ItemsToRents",
                newName: "IX_ItemsToRents_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsToRent_BranchOfficeId",
                table: "ItemsToRents",
                newName: "IX_ItemsToRents_BranchOfficeId");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployeeId",
                table: "ItemsToRents",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsToRents",
                table: "ItemsToRents",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsToRents_BranchOffices_BranchOfficeId",
                table: "ItemsToRents",
                column: "BranchOfficeId",
                principalTable: "BranchOffices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ItemsToRents_Employee_EmployeeId",
                table: "ItemsToRents",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ItemsToRents_BranchOffices_BranchOfficeId",
                table: "ItemsToRents");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemsToRents_Employee_EmployeeId",
                table: "ItemsToRents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsToRents",
                table: "ItemsToRents");

            migrationBuilder.RenameTable(
                name: "ItemsToRents",
                newName: "ItemsToRent");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsToRents_EmployeeId",
                table: "ItemsToRent",
                newName: "IX_ItemsToRent_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_ItemsToRents_BranchOfficeId",
                table: "ItemsToRent",
                newName: "IX_ItemsToRent_BranchOfficeId");

            migrationBuilder.AlterColumn<Guid>(
                name: "EmployeeId",
                table: "ItemsToRent",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsToRent",
                table: "ItemsToRent",
                column: "Id");

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
        }
    }
}
