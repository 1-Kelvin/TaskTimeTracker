using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTimeTracker.Migrations
{
    public partial class tasktime2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectID",
                table: "Todo",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Todo_ProjectID",
                table: "Todo",
                column: "ProjectID");

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_Project_ProjectID",
                table: "Todo",
                column: "ProjectID",
                principalTable: "Project",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_Project_ProjectID",
                table: "Todo");

            migrationBuilder.DropIndex(
                name: "IX_Todo_ProjectID",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "ProjectID",
                table: "Todo");
        }
    }
}
