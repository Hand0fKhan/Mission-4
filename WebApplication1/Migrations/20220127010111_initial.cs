using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Rating = table.Column<string>(nullable: true),
                    Edit = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Category", "Director", "Edit", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Science Fantasy", "Gareth Edwards", false, "", "", "PG-13", "Rogue One: A Star Wars Story", "2016" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Category", "Director", "Edit", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Science Fantasy", "Gareth Edwards", false, "", "", "PG-13", "Solo: A Star Wars Story", "2018" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
