using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksDirectory.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Classification = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MajorLandmarks = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    YearFounded = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Classification", "Location", "MajorLandmarks", "Name", "YearFounded" },
                values: new object[,]
                {
                    { 1, "national park", "Oregon", "Crater Lake, Wizard Island", "Crater Lake", 1902 },
                    { 2, "national monument", "Oregon", "Lava Butte, Lava River Cave, Lava Cast Forest, Newberry Caldera, Big Obsidian Flow, Paulina Peak, East Lake, Paulina Lake", "Newberry National Volcanic Monument", 1990 },
                    { 3, "state park", "Oregon", "Smith Rock", "Smith Rock State Park", 1960 },
                    { 4, "state park", "Oregon", "Deschutes River Trail", "Tumalo State Park", 1954 },
                    { 5, "national forest", "Oregon", "Mount Jefferson, Mount Washington, the Three Sisters, Lava Lands, Metolius River, Cascade Lakes", "Deschutes National Forest", 1908 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
