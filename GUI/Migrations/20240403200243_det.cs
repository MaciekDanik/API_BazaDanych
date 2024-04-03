using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GUI.Migrations
{
    /// <inheritdoc />
    public partial class det : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "detailed",
                table: "Drink",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "detailed",
                table: "Drink");
        }
    }
}
