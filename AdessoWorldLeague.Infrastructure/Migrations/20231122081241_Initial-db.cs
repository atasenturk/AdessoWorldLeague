using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdessoWorldLeague.Infrastructure.Migrations
{
    public partial class Initialdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teams_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Türkiye" },
                    { 2, "Almanya" },
                    { 3, "Fransa" },
                    { 4, "Hollanda" },
                    { 5, "Portekiz" },
                    { 6, "İtalya" },
                    { 7, "İspanya" },
                    { 8, "Belçika" }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CountryId", "GroupId", "Name" },
                values: new object[,]
                {
                    { 1, 1, null, "Adesso İstanbul" },
                    { 2, 1, null, "Adesso Ankara" },
                    { 3, 1, null, "Adesso İzmir" },
                    { 4, 1, null, "Adesso Antalya" },
                    { 5, 2, null, "Adesso Berlin" },
                    { 6, 2, null, "Adesso Frankfurt" },
                    { 7, 2, null, "Adesso Münih" },
                    { 8, 2, null, "Adesso Dortmund" },
                    { 9, 3, null, "Adesso Paris" },
                    { 10, 3, null, "Adesso Marsilya" },
                    { 11, 3, null, "Adesso Nice" },
                    { 12, 3, null, "Adesso Lyon" },
                    { 13, 4, null, "Adesso Amsterdam" },
                    { 14, 4, null, "Adesso Rotterdam" },
                    { 15, 4, null, "Adesso Lahey" },
                    { 16, 4, null, "Adesso Eindhoven" },
                    { 17, 5, null, "Adesso Lisbon" },
                    { 18, 5, null, "Adesso Porto" },
                    { 19, 5, null, "Adesso Braga" },
                    { 20, 5, null, "Adesso Coimbra" },
                    { 21, 6, null, "Adesso Roma" },
                    { 22, 6, null, "Adesso Milano" },
                    { 23, 6, null, "Adesso Venedik" },
                    { 24, 6, null, "Adesso Napoli" },
                    { 25, 7, null, "Adesso Sevilla" },
                    { 26, 7, null, "Adesso Madrid" },
                    { 27, 7, null, "Adesso Barselona" },
                    { 28, 7, null, "Adesso Granada" },
                    { 29, 8, null, "Adesso Brüksel" },
                    { 30, 8, null, "Adesso Brugge" },
                    { 31, 8, null, "Adesso Gent" },
                    { 32, 8, null, "Adesso Anvers" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CountryId",
                table: "Teams",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_GroupId",
                table: "Teams",
                column: "GroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Groups");
        }
    }
}
