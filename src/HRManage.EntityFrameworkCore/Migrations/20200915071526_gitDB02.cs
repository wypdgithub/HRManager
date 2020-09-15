using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HRManage.Migrations
{
    public partial class gitDB02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Extra_Work",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Dept_Id = table.Column<Guid>(nullable: false),
                    ApplyTime = table.Column<DateTime>(nullable: false),
                    Work_StartTime = table.Column<DateTime>(nullable: false),
                    Work_EndTime = table.Column<DateTime>(nullable: false),
                    Work_Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extra_Work", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Extra_Work");
        }
    }
}
