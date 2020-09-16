using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManage.Migrations
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    UserRoleId = table.Column<string>(nullable: true),
                    Smonery = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yearleads",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Duty = table.Column<int>(nullable: false),
                    AssessType = table.Column<int>(nullable: false),
                    Adjunct = table.Column<int>(nullable: false),
                    Fidelity = table.Column<int>(nullable: false),
                    Approve = table.Column<int>(nullable: false),
                    Executes = table.Column<int>(nullable: false),
                    Passion = table.Column<int>(nullable: false),
                    Integrity = table.Column<int>(nullable: false),
                    Familiar = table.Column<int>(nullable: false),
                    Learn = table.Column<int>(nullable: false),
                    Organization = table.Column<int>(nullable: false),
                    Coopertion = table.Column<int>(nullable: false),
                    Communicate = table.Column<int>(nullable: false),
                    Accomplish = table.Column<int>(nullable: false),
                    Importanc = table.Column<int>(nullable: false),
                    Satisfaction = table.Column<int>(nullable: false),
                    Complaint = table.Column<int>(nullable: false),
                    Figureout = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    Selfassessment = table.Column<int>(nullable: false),
                    Leadevaluaction = table.Column<int>(nullable: false),
                    UserDepartment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yearleads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Yearstaffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationTime = table.Column<DateTime>(nullable: false),
                    CreatorUserId = table.Column<long>(nullable: true),
                    LastModificationTime = table.Column<DateTime>(nullable: true),
                    LastModifierUserId = table.Column<long>(nullable: true),
                    Duty = table.Column<int>(nullable: false),
                    AssessType = table.Column<int>(nullable: false),
                    Adjunct = table.Column<int>(nullable: false),
                    Fidelity = table.Column<int>(nullable: false),
                    Approve = table.Column<int>(nullable: false),
                    Executes = table.Column<int>(nullable: false),
                    Passion = table.Column<int>(nullable: false),
                    Integrity = table.Column<int>(nullable: false),
                    Familiar = table.Column<int>(nullable: false),
                    Learn = table.Column<int>(nullable: false),
                    Organization = table.Column<int>(nullable: false),
                    Coopertion = table.Column<int>(nullable: false),
                    Communicate = table.Column<int>(nullable: false),
                    Accomplish = table.Column<int>(nullable: false),
                    Importanc = table.Column<int>(nullable: false),
                    Satisfaction = table.Column<int>(nullable: false),
                    Complaint = table.Column<int>(nullable: false),
                    Figureout = table.Column<int>(nullable: false),
                    Total = table.Column<int>(nullable: false),
                    Selfassessment = table.Column<int>(nullable: false),
                    Leadevaluaction = table.Column<int>(nullable: false),
                    UserDepartment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yearstaffs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "Yearleads");

            migrationBuilder.DropTable(
                name: "Yearstaffs");
        }
    }
}
