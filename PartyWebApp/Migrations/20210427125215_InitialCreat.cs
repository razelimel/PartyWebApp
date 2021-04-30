using Microsoft.EntityFrameworkCore.Migrations;

namespace PartyWebApp.Migrations
{
    public partial class InitialCreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imagesUrlDTO",
                table: "Club");

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Party",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Party");

            migrationBuilder.AddColumn<string>(
                name: "imagesUrlDTO",
                table: "Club",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
