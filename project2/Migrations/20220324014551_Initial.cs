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
                    AppointmentTime = table.Column<string>(nullable: false),
                    IsTaken = table.Column<bool>(nullable: false)
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
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 1, "8:00 AM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 2, "9:00 AM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 3, "10:00 AM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 4, "11:00 AM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 5, "12:00 PM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 6, "1:00 PM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 7, "2:00 PM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 8, "3:00 PM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 9, "4:00 PM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 10, "5:00 PM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 11, "6:00 PM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 12, "7:00 PM", false });

            migrationBuilder.InsertData(
                table: "TimeSlots",
                columns: new[] { "TimeSlotID", "AppointmentTime", "IsTaken" },
                values: new object[] { 13, "8:00 PM", false });

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
