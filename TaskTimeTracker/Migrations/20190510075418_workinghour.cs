using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTimeTracker.Migrations
{
    public partial class workinghour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "workingHours",
                table: "Todo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "workingHours",
                table: "Todo");
        }
    }
}
