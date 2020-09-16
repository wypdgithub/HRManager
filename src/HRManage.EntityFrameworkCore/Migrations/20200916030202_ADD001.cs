using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManage.Migrations
{
    public partial class ADD001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Gradess",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GradeAll = table.Column<int>(nullable: false),
                    Attenddance = table.Column<int>(nullable: false),
                    Leave = table.Column<int>(nullable: false),
                    Score = table.Column<int>(nullable: false),
                    ChuId = table.Column<int>(nullable: false),
                    QingId = table.Column<string>(nullable: true),
                    MonthId = table.Column<string>(nullable: true),
                    YearId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gradess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monthleads",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Duty = table.Column<string>(nullable: true),
                    AssessType = table.Column<string>(nullable: true),
                    Adjunct = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_Monthleads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monthstaffs",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
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
                    table.PrimaryKey("PK_Monthstaffs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gradess");

            migrationBuilder.DropTable(
                name: "Monthleads");

            migrationBuilder.DropTable(
                name: "Monthstaffs");
        }
    }
}
