using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTimeTracker.Migrations
{
    public partial class testdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UserID = table.Column<int>(nullable: true),
                    Finished = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getdate()"),
                    Active = table.Column<bool>(nullable: false),
                    Level = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectUser",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectUser", x => new { x.UserId, x.ProjectId });
                    table.ForeignKey(
                        name: "FK_ProjectUser_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectUser_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ToFinish = table.Column<DateTime>(nullable: true),
                    WorkingHours = table.Column<int>(nullable: true),
                    EstimatedHours = table.Column<int>(nullable: true),
                    Finished = table.Column<bool>(nullable: false),
                    UserID = table.Column<int>(nullable: true),
                    ProjectID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todo_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Todo_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Description", "Finished", "Name", "UserID" },
                values: new object[,]
                {
                    { 1, "Tempore et quasi quo. Ut et dolor nam molestiae est. Facilis impedit consequatur accusantium dolore sunt.", false, "kölotzeikrug.de", null },
                    { 2, "Distinctio omnis soluta praesentium autem sint expedita fugiat tempora. Nulla velit ratione et est omnis illo voluptas architecto. Similique natus ipsa voluptatum id iure dolore et molestiae. Pariatur et sapiente ut ipsum mollitia quis voluptatem. Placeat voluptatem illum et aut eos mollitia debitis.", false, "gratzky.com", null },
                    { 3, "Sit voluptatem aspernatur quo velit est doloribus nam facere. Velit maiores non qui repudiandae et. Atque et non voluptas. Facere enim ut laborum eos molestias et. Saepe laborum asperiores nam itaque ut et rerum vitae.", false, "ummingerlienshöft.info", null },
                    { 4, "Qui facilis eos delectus illum accusamus quae exercitationem. Quidem ea excepturi repellendus rem. Culpa voluptatum et assumenda excepturi quibusdam asperiores. Sint rerum iste neque in voluptatum porro.", false, "schwennenbrehmer.net", null },
                    { 5, "Repellat perspiciatis voluptatibus aut voluptas ipsam nam accusantium non. Veniam voluptate dolores nulla sit numquam. Eveniet doloremque dolorem explicabo fuga sit quaerat nihil. Illum est iure ullam ipsum corporis ab.", false, "busse.net", null }
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "Description", "EstimatedHours", "Finished", "ProjectID", "Title", "ToFinish", "UserID", "WorkingHours" },
                values: new object[,]
                {
                    { 18, "Description18", 7, false, null, "Title18", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5677), null, 0 },
                    { 14, "Description14", 18, false, null, "Title14", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5405), null, 0 },
                    { 20, "Description20", 9, false, null, "Title20", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5824), null, 0 },
                    { 3, "Description3", 18, false, null, "Title3", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4491), null, 0 },
                    { 10, "Description10", 19, false, null, "Title10", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5133), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "Created", "Email", "Firstname", "Lastname", "Level", "Password" },
                values: new object[,]
                {
                    { 11, true, new DateTime(2019, 5, 19, 14, 11, 34, 299, DateTimeKind.Local).AddTicks(2747), "darius@sussmanngreithanner.org", "Dario", "Kurrat", 1, "1234" },
                    { 18, true, new DateTime(2019, 5, 19, 14, 11, 34, 302, DateTimeKind.Local).AddTicks(4055), "jasmine_rhoden@restorff.ch", "Christin", "Bogenrieder", 2, "1234" },
                    { 17, true, new DateTime(2019, 5, 19, 14, 11, 34, 301, DateTimeKind.Local).AddTicks(9438), "karl@leiteritz.info", "Victoria", "Brandt", 5, "1234" },
                    { 16, true, new DateTime(2019, 5, 19, 14, 11, 34, 301, DateTimeKind.Local).AddTicks(3877), "celia@lipske.de", "Amon", "Roth", 5, "1234" },
                    { 15, true, new DateTime(2019, 5, 19, 14, 11, 34, 301, DateTimeKind.Local).AddTicks(459), "ryan@poser.com", "Till", "Siebel", 5, "1234" },
                    { 14, true, new DateTime(2019, 5, 19, 14, 11, 34, 300, DateTimeKind.Local).AddTicks(7053), "mathilde.eplinius@mertens.de", "Mats", "Möldner", 5, "1234" },
                    { 13, true, new DateTime(2019, 5, 19, 14, 11, 34, 300, DateTimeKind.Local).AddTicks(465), "annabell_göckeritz@krämer.info", "Eileen", "Mebold", 2, "1234" },
                    { 12, true, new DateTime(2019, 5, 19, 14, 11, 34, 299, DateTimeKind.Local).AddTicks(6134), "eleni@kempe.net", "Furkan", "Franta", 1, "1234" },
                    { 10, true, new DateTime(2019, 5, 19, 14, 11, 34, 298, DateTimeKind.Local).AddTicks(8204), "tyron@urhigblum.info", "Louis", "Konieczny", 4, "1234" },
                    { 5, true, new DateTime(2019, 5, 19, 14, 11, 34, 296, DateTimeKind.Local).AddTicks(1373), "joris_kustermann@illing.info", "Max", "Tiedtke", 3, "1234" },
                    { 8, true, new DateTime(2019, 5, 19, 14, 11, 34, 297, DateTimeKind.Local).AddTicks(9385), "len_storp@lindenmayer.ch", "Patricia", "Klemme", 2, "1234" },
                    { 7, true, new DateTime(2019, 5, 19, 14, 11, 34, 297, DateTimeKind.Local).AddTicks(3045), "niclas.dienel@rieger.net", "Elea", "Herzenberg", 1, "1234" },
                    { 6, true, new DateTime(2019, 5, 19, 14, 11, 34, 296, DateTimeKind.Local).AddTicks(8498), "karl.wanner@tonnporth.info", "Aliya", "Balck", 1, "1234" },
                    { 19, true, new DateTime(2019, 5, 19, 14, 11, 34, 302, DateTimeKind.Local).AddTicks(7578), "chayenne@strohschank.info", "Lola", "Kelm", 2, "1234" },
                    { 4, true, new DateTime(2019, 5, 19, 14, 11, 34, 295, DateTimeKind.Local).AddTicks(5015), "martha@metzger.com", "Juna", "Byrd", 5, "1234" },
                    { 3, true, new DateTime(2019, 5, 19, 14, 11, 34, 295, DateTimeKind.Local).AddTicks(80), "joanna.muckenthaler@strutzgeisler.de", "Henrike", "Beutelspacher", 5, "1234" },
                    { 2, true, new DateTime(2019, 5, 19, 14, 11, 34, 293, DateTimeKind.Local).AddTicks(5472), "lindsay@hirt.de", "Friedrich", "Hess", 4, "1234" },
                    { 1, true, new DateTime(2019, 5, 19, 14, 11, 34, 292, DateTimeKind.Local).AddTicks(1656), "logan@barylla.org", "Marleen", "Frantz", 1, "1234" },
                    { 9, true, new DateTime(2019, 5, 19, 14, 11, 34, 298, DateTimeKind.Local).AddTicks(3885), "stina_decker@weber.org", "Marten", "Reus", 1, "1234" },
                    { 20, true, new DateTime(2019, 5, 19, 14, 11, 34, 303, DateTimeKind.Local).AddTicks(4213), "ina_rädler@friess.info", "Evelyn", "Allgeyer", 4, "1234" }
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "Description", "EstimatedHours", "Finished", "ProjectID", "Title", "ToFinish", "UserID", "WorkingHours" },
                values: new object[,]
                {
                    { 21, "Description21", 12, false, 1, "Title21", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5888), null, 0 },
                    { 11, "Description11", 10, false, null, "Title11", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5205), 14, 0 },
                    { 25, "Description25", 14, false, null, "Title25", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6156), 12, 0 },
                    { 22, "Description22", 17, false, null, "Title22", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5956), 12, 0 },
                    { 19, "Description19", 9, false, null, "Title19", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5749), 9, 0 },
                    { 12, "Description12", 6, false, null, "Title12", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5273), 8, 0 },
                    { 29, "Description29", 2, false, null, "Title29", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6417), 5, 0 },
                    { 15, "Description15", 12, false, null, "Title15", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5481), 2, 0 },
                    { 27, "Description27", 4, false, null, "Title27", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6289), 1, 0 },
                    { 26, "Description26", 8, false, 5, "Title26", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6224), null, 0 },
                    { 24, "Description24", 10, false, 5, "Title24", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6085), null, 0 },
                    { 6, "Description6", 13, false, null, "Title6", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4718), 19, 0 },
                    { 17, "Description17", 1, false, 5, "Title17", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5613), null, 0 },
                    { 5, "Description5", 13, false, 5, "Title5", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4650), null, 0 },
                    { 2, "Description2", 12, false, 5, "Title2", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4393), null, 0 },
                    { 30, "Description30", 13, false, 4, "Title30", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6492), null, 0 },
                    { 16, "Description16", 8, false, 3, "Title16", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5545), null, 0 },
                    { 13, "Description13", 15, false, 3, "Title13", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5337), null, 0 },
                    { 1, "Description1", 12, false, 3, "Title1", new DateTime(2019, 6, 18, 14, 11, 34, 332, DateTimeKind.Local).AddTicks(7197), null, 0 },
                    { 28, "Description28", 10, false, 2, "Title28", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6353), null, 0 },
                    { 23, "Description23", 8, false, 2, "Title23", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6020), null, 0 },
                    { 7, "Description7", 10, false, 2, "Title7", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4786), null, 0 },
                    { 4, "Description4", 17, false, 2, "Title4", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4555), null, 0 },
                    { 8, "Description8", 7, false, 5, "Title8", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4850), null, 0 },
                    { 9, "Description9", 10, false, null, "Title9", new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4918), 19, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectUser_ProjectId",
                table: "ProjectUser",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Todo_ProjectID",
                table: "Todo",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Todo_UserID",
                table: "Todo",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectUser");

            migrationBuilder.DropTable(
                name: "Todo");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
