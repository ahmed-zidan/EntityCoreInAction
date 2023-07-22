using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entity.Project.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AttendanceDate",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AttendanceEmpID",
                table: "employees",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BranchId",
                table: "Department",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_AttendanceEmpID_AttendanceDate",
                table: "employees",
                columns: new[] { "AttendanceEmpID", "AttendanceDate" });

            migrationBuilder.CreateIndex(
                name: "IX_Department_BranchId",
                table: "Department",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_branches_BranchId",
                table: "Department",
                column: "BranchId",
                principalTable: "branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_employees_Attendance_AttendanceEmpID_AttendanceDate",
                table: "employees",
                columns: new[] { "AttendanceEmpID", "AttendanceDate" },
                principalTable: "Attendance",
                principalColumns: new[] { "EmpID", "Date" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_branches_BranchId",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_employees_Attendance_AttendanceEmpID_AttendanceDate",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_AttendanceEmpID_AttendanceDate",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_Department_BranchId",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "AttendanceDate",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "AttendanceEmpID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "BranchId",
                table: "Department");
        }
    }
}
