using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManage.Migrations
{
    public partial class gitDB01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Detailed",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    sign_In_Id = table.Column<Guid>(nullable: false),
                    beLate = table.Column<int>(nullable: false),
                    leaveEarly = table.Column<int>(nullable: false),
                    sickLeave = table.Column<int>(nullable: false),
                    absenteeism = table.Column<int>(nullable: false),
                    marriage_Leave = table.Column<int>(nullable: false),
                    funeral_leave = table.Column<int>(nullable: false),
                    maternity_Leave = table.Column<int>(nullable: false),
                    affair_Leave = table.Column<int>(nullable: false),
                    official_Business = table.Column<int>(nullable: false),
                    ShouldBe = table.Column<DateTime>(nullable: false),
                    RealBe = table.Column<DateTime>(nullable: false),
                    forget = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detailed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evection",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Proposer = table.Column<string>(nullable: true),
                    ApplyTime = table.Column<DateTime>(nullable: false),
                    Site = table.Column<string>(maxLength: 50, nullable: true),
                    Business_StartTime = table.Column<DateTime>(nullable: false),
                    Business_EndTime = table.Column<DateTime>(nullable: false),
                    Business_Content = table.Column<string>(nullable: true),
                    Vehicle = table.Column<bool>(nullable: false),
                    Dept_Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evection", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Please_Leave",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Proposer = table.Column<string>(maxLength: 30, nullable: true),
                    ApplyTime = table.Column<DateTime>(nullable: false),
                    Please_leave_SatrtTime = table.Column<DateTime>(nullable: false),
                    Please_leave_EndTime = table.Column<DateTime>(nullable: false),
                    Please_leave_TypeId = table.Column<Guid>(nullable: false),
                    Dept_Id = table.Column<Guid>(nullable: false),
                    Business_Reason = table.Column<string>(nullable: true),
                    States = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Please_Leave", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Please_Leave_Type",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Please_leave_Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Please_Leave_Type", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sign_In_Tb",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(maxLength: 30, nullable: true),
                    sign_In_Number = table.Column<string>(maxLength: 50, nullable: true),
                    sign_In_Date = table.Column<DateTime>(nullable: false),
                    sign_In_Day = table.Column<string>(maxLength: 50, nullable: true),
                    sign_In_Shift_Name = table.Column<string>(maxLength: 50, nullable: true),
                    sign_In_Mor_StartTime = table.Column<DateTime>(nullable: false),
                    sign_In_Mor_EndTime = table.Column<DateTime>(nullable: false),
                    sign_In_Aft_StartTime = table.Column<DateTime>(nullable: false),
                    sign_In_Aft_EndTime = table.Column<DateTime>(nullable: false),
                    department = table.Column<string>(maxLength: 50, nullable: true),
                    sign_In_Mor_States = table.Column<int>(nullable: false),
                    sign_In_Aft_States = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sign_In_Tb", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detailed");

            migrationBuilder.DropTable(
                name: "Evection");

            migrationBuilder.DropTable(
                name: "Please_Leave");

            migrationBuilder.DropTable(
                name: "Please_Leave_Type");

            migrationBuilder.DropTable(
                name: "Sign_In_Tb");
        }
    }
}
