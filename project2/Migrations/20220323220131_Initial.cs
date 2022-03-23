using Microsoft.EntityFrameworkCore.Migrations;

namespace project2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TimeSlots",
                columns: table => new
                {
                    TimeSlotID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AppointmentTime = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSlots", x => x.TimeSlotID);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    AppointmentID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(nullable: false),
                    GroupSize = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    TimeSlotID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.AppointmentID);
                    table.ForeignKey(
                        name: "FK_Responses_TimeSlots_TimeSlotID",
                        column: x => x.TimeSlotID,
                        principalTable: "TimeSlots",
                        principalColumn: "TimeSlotID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 8, "8:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 9, "9:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 10, "10:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 11, "11:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 12, "12:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 13, "1:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 14, "2:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 15, "3:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 16, "4:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 17, "5:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 18, "6:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 19, "7:00" });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime" },
                values: new object[] { 20, "8:00" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "AppointmentID", "Email", "GroupName", "GroupSize", "Phone", "TimeSlotID" },
                values: new object[] { 1, "kyliefromm@gmail.com", "Kylie", 5, "801-555-5555", 8 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_TimeSlotID",
                table: "Responses",
                column: "TimeSlotID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "TimeSlots");
        }
    }
}
