using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTimeTracker.Migrations
{
    public partial class estimatedhours : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "workingHours",
                table: "Todo",
                newName: "WorkingHours");

            migrationBuilder.AddColumn<int>(
                name: "EstimatedHours",
                table: "Todo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimatedHours",
                table: "Todo");

            migrationBuilder.RenameColumn(
                name: "WorkingHours",
                table: "Todo",
                newName: "workingHours");
        }
    }
}
