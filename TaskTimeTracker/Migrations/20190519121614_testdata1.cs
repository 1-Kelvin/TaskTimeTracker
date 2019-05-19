using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskTimeTracker.Migrations
{
    public partial class testdata1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Necessitatibus aut quod earum. Officia culpa voluptas totam expedita sequi et. Occaecati impedit perspiciatis culpa ratione est ut est.", "gabler.ch" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Et consequatur perspiciatis atque impedit et non. Dolores voluptatem consequatur quod nam molestiae dolore magni quo. Mollitia harum et et est facilis id quis id.", "kern.org" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Asperiores omnis a et ipsum dignissimos. Aut distinctio sunt iure sunt voluptate voluptatibus laborum. Aut nihil vel explicabo id est.", "stregepöge.com" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Blanditiis maiores ducimus quia voluptas consequatur tempore ratione quis. Sed qui autem placeat labore. Sit et consectetur nemo sed aut doloribus voluptatibus non. Voluptas ullam rem officiis.", "brettschneider.ch" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sed quaerat aut aperiam nemo laudantium et libero. Ea corporis at dignissimos. Placeat eum est odit assumenda laboriosam. Totam repudiandae dolorum id consequatur cum esse amet dolore.", "hackelbusch.ch" });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 9, null, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(4468), 5 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 17, 2, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(4694) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 7, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(4774), 8 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 11, 1, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 16, 2, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 2, 2, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(4974), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 6, 1, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5046) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 3, 3, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5117) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 1, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5182), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EstimatedHours", "ToFinish" },
                values: new object[] { 13, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 1, 1, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5317), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 7, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5385), 9 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 16, null, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5457), 10 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 17, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5521), 4 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 16, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5586), 1 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 18, null, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5653), 1 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 17, 4, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 2, 4, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 3, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5857), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 4, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5922), 15 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProjectID", "ToFinish" },
                values: new object[] { 2, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 18, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(6054), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 3, null, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(6125), 15 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 2, 1, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ToFinish", "UserID" },
                values: new object[] { new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(6258), 10 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EstimatedHours", "ToFinish" },
                values: new object[] { 13, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(6322) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 7, 2, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(6386), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EstimatedHours", "ToFinish" },
                values: new object[] { 4, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(6462) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 9, 2, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(6529), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 18, null, new DateTime(2019, 6, 18, 14, 16, 13, 902, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 866, DateTimeKind.Local).AddTicks(2364), "josua@bönisch.info", "Tamino", "Huth", 4 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 868, DateTimeKind.Local).AddTicks(2422), "cedric_thieke@bayer.net", "Jari", "Loska", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 868, DateTimeKind.Local).AddTicks(8319), "hamza@sürth.name", "Juna", "Kempter", 4 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 869, DateTimeKind.Local).AddTicks(5681), "lotte@goldfusswühn.net", "Kim", "Dietz", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Email", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 870, DateTimeKind.Local).AddTicks(329), "elena.hillard@kochan.net", "Alena", "Sladek" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 870, DateTimeKind.Local).AddTicks(6205), "burak@weber.name", "Emilia", "Leimbach", 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 870, DateTimeKind.Local).AddTicks(9743), "steven@köhler.info", "Zeynep", "Fust", 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 871, DateTimeKind.Local).AddTicks(6422), "bela.brandis@schwarthoff.ch", "Cara", "Beyer", 3 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 872, DateTimeKind.Local).AddTicks(976), "filip_volkmann@burkhardt.name", "Moritz", "Kofferschlager", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 872, DateTimeKind.Local).AddTicks(8112), "elisa_eifert@smieja.net", "Jordan", "Sujew", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 873, DateTimeKind.Local).AddTicks(4637), "johann@wessinghage.info", "Raul", "Neumair", 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Email", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 874, DateTimeKind.Local).AddTicks(361), "rené.mehlorn@lichtenhagenbrunner.de", "Letizia", "Obergföll" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 874, DateTimeKind.Local).AddTicks(7433), "yves@blumeniklaus.com", "Giuliano", "Schmidt", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 875, DateTimeKind.Local).AddTicks(2444), "angelina_könig@roloff.com", "Jule", "Erdmann", 3 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 880, DateTimeKind.Local).AddTicks(4947), "elia_sokolowski@stepanov.info", "Emilie", "Onnen", 4 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 880, DateTimeKind.Local).AddTicks(8972), "laurin_herschmann@lange.org", "Ilja", "Riediger", 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 881, DateTimeKind.Local).AddTicks(2253), "kerem_schwarzkopf@sewaldgruber.ch", "Elisa", "Mockenhaupt", 3 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 881, DateTimeKind.Local).AddTicks(6206), "boris_nagel@schielke.com", "Angelique", "Köpernick", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 881, DateTimeKind.Local).AddTicks(9494), "francesca@arendt.ch", "Darian", "Schimmer", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 16, 13, 882, DateTimeKind.Local).AddTicks(2485), "andre_hübner@bauer.net", "Milo", "Gottschalk", 2 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Active", "Created", "Email", "Firstname", "Lastname", "Level", "Password" },
                values: new object[] { 777, true, new DateTime(2019, 5, 19, 14, 16, 13, 882, DateTimeKind.Local).AddTicks(2609), "k@s.eu", "Kelvin", "Sparr", 0, "password" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Tempore et quasi quo. Ut et dolor nam molestiae est. Facilis impedit consequatur accusantium dolore sunt.", "kölotzeikrug.de" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Distinctio omnis soluta praesentium autem sint expedita fugiat tempora. Nulla velit ratione et est omnis illo voluptas architecto. Similique natus ipsa voluptatum id iure dolore et molestiae. Pariatur et sapiente ut ipsum mollitia quis voluptatem. Placeat voluptatem illum et aut eos mollitia debitis.", "gratzky.com" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Sit voluptatem aspernatur quo velit est doloribus nam facere. Velit maiores non qui repudiandae et. Atque et non voluptas. Facere enim ut laborum eos molestias et. Saepe laborum asperiores nam itaque ut et rerum vitae.", "ummingerlienshöft.info" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Qui facilis eos delectus illum accusamus quae exercitationem. Quidem ea excepturi repellendus rem. Culpa voluptatum et assumenda excepturi quibusdam asperiores. Sint rerum iste neque in voluptatum porro.", "schwennenbrehmer.net" });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Repellat perspiciatis voluptatibus aut voluptas ipsam nam accusantium non. Veniam voluptate dolores nulla sit numquam. Eveniet doloremque dolorem explicabo fuga sit quaerat nihil. Illum est iure ullam ipsum corporis ab.", "busse.net" });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 12, 3, new DateTime(2019, 6, 18, 14, 11, 34, 332, DateTimeKind.Local).AddTicks(7197), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 12, 5, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 18, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4491), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 17, 2, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4555) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 13, 5, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 13, null, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4718), 19 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 10, 2, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 7, 5, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4850) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 10, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(4918), 19 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "EstimatedHours", "ToFinish" },
                values: new object[] { 19, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 10, null, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5205), 14 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 6, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5273), 8 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 15, 3, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5337), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 18, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5405), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 12, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5481), 2 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 8, 3, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5545), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 1, 5, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5613) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 7, null, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5749), 9 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 9, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5824), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ProjectID", "ToFinish" },
                values: new object[] { 1, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "EstimatedHours", "ToFinish", "UserID" },
                values: new object[] { 17, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(5956), 12 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 8, 2, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6020), null });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 10, 5, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ToFinish", "UserID" },
                values: new object[] { new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6156), 12 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "EstimatedHours", "ToFinish" },
                values: new object[] { 8, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 4, null, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6289), 1 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "EstimatedHours", "ToFinish" },
                values: new object[] { 10, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish", "UserID" },
                values: new object[] { 2, null, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6417), 5 });

            migrationBuilder.UpdateData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "EstimatedHours", "ProjectID", "ToFinish" },
                values: new object[] { 13, 4, new DateTime(2019, 6, 18, 14, 11, 34, 333, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 292, DateTimeKind.Local).AddTicks(1656), "logan@barylla.org", "Marleen", "Frantz", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 293, DateTimeKind.Local).AddTicks(5472), "lindsay@hirt.de", "Friedrich", "Hess", 4 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 295, DateTimeKind.Local).AddTicks(80), "joanna.muckenthaler@strutzgeisler.de", "Henrike", "Beutelspacher", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 295, DateTimeKind.Local).AddTicks(5015), "martha@metzger.com", "Juna", "Byrd", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Email", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 296, DateTimeKind.Local).AddTicks(1373), "joris_kustermann@illing.info", "Max", "Tiedtke" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 296, DateTimeKind.Local).AddTicks(8498), "karl.wanner@tonnporth.info", "Aliya", "Balck", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 297, DateTimeKind.Local).AddTicks(3045), "niclas.dienel@rieger.net", "Elea", "Herzenberg", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 297, DateTimeKind.Local).AddTicks(9385), "len_storp@lindenmayer.ch", "Patricia", "Klemme", 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 298, DateTimeKind.Local).AddTicks(3885), "stina_decker@weber.org", "Marten", "Reus", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 298, DateTimeKind.Local).AddTicks(8204), "tyron@urhigblum.info", "Louis", "Konieczny", 4 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 299, DateTimeKind.Local).AddTicks(2747), "darius@sussmanngreithanner.org", "Dario", "Kurrat", 1 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Email", "Firstname", "Lastname" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 299, DateTimeKind.Local).AddTicks(6134), "eleni@kempe.net", "Furkan", "Franta" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 300, DateTimeKind.Local).AddTicks(465), "annabell_göckeritz@krämer.info", "Eileen", "Mebold", 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 300, DateTimeKind.Local).AddTicks(7053), "mathilde.eplinius@mertens.de", "Mats", "Möldner", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 301, DateTimeKind.Local).AddTicks(459), "ryan@poser.com", "Till", "Siebel", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 301, DateTimeKind.Local).AddTicks(3877), "celia@lipske.de", "Amon", "Roth", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 301, DateTimeKind.Local).AddTicks(9438), "karl@leiteritz.info", "Victoria", "Brandt", 5 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 302, DateTimeKind.Local).AddTicks(4055), "jasmine_rhoden@restorff.ch", "Christin", "Bogenrieder", 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 302, DateTimeKind.Local).AddTicks(7578), "chayenne@strohschank.info", "Lola", "Kelm", 2 });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Email", "Firstname", "Lastname", "Level" },
                values: new object[] { new DateTime(2019, 5, 19, 14, 11, 34, 303, DateTimeKind.Local).AddTicks(4213), "ina_rädler@friess.info", "Evelyn", "Allgeyer", 4 });
        }
    }
}
