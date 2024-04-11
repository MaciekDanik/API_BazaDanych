using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GUI.Migrations
{
    /// <inheritdoc />
    public partial class Dupa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SearchID = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AlternateDrink = table.Column<string>(type: "TEXT", nullable: true),
                    Tags = table.Column<string>(type: "TEXT", nullable: true),
                    Category = table.Column<string>(type: "TEXT", nullable: true),
                    Glass = table.Column<string>(type: "TEXT", nullable: true),
                    Instructions = table.Column<string>(type: "TEXT", nullable: true),
                    drinkPIC = table.Column<string>(type: "TEXT", nullable: true),
                    IsAlcoholic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Ingredients = table.Column<string>(type: "TEXT", nullable: true),
                    Measuers = table.Column<string>(type: "TEXT", nullable: true),
                    detailed = table.Column<bool>(type: "INTEGER", nullable: false),
                    Favourite = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drinks");
        }
    }
}
