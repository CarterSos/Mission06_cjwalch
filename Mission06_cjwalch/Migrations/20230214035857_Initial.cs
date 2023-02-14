using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_cjwalch.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Avengers: Endgame", "Action", "Russo Brothers", false, null, "Greatest Movie ever", "PG-13", 2019 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Spiderman: Into the Spider-verse", "Action", "Bob Persichetti", false, null, null, "PG", 2018 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "The Count of Monte Cristo", "Adventure", "Kevin Reynolds", false, null, "Best revenge story", "PG-13", 2002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
