using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksDirectory.Migrations
{
    public partial class UpdateParkModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Activities",
                table: "Parks",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Facilities",
                table: "Parks",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1,
                columns: new[] { "Activities", "Facilities" },
                values: new object[] { "Hiking, camping, birding, fishing, skiing, snowshoeing, snowboarding, sledding", "Summer tent and RV camping, electric hookups, seasonal laundry, flush toilets, and showers" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2,
                columns: new[] { "Activities", "Facilities" },
                values: new object[] { "Biking, camping, fishing, horseback riding, hiking, boating, swimming, skiing, snowshoeing", "Tent and RV camping, flush toilets at some campgrounds" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3,
                columns: new[] { "Activities", "Facilities" },
                values: new object[] { "Rock climbing, hiking, horseback riding, biking, camping, kayaking", "Walk-in camping, showers, restrooms" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4,
                columns: new[] { "Activities", "Facilities" },
                values: new object[] { "Hiking, camping, biking, swimming", "Yurts, cabins, tent camping, showers, flush toilets" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5,
                columns: new[] { "Activities", "Facilities" },
                values: new object[] { "Biking, camping, hiking, horseback riding, boating, swimming, skiing, snowboarding, sledding, caving", "Varies by site" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Activities",
                table: "Parks");

            migrationBuilder.DropColumn(
                name: "Facilities",
                table: "Parks");
        }
    }
}
