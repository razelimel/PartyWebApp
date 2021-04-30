using Microsoft.EntityFrameworkCore.Migrations;

namespace PartyWebApp.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "firstName",
                table: "Performer");

            migrationBuilder.DropColumn(
                name: "genre",
                table: "Performer");

            migrationBuilder.DropColumn(
                name: "imageUrl",
                table: "Performer");

            migrationBuilder.DropColumn(
                name: "lastName",
                table: "Performer");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Performer");

            migrationBuilder.AddColumn<string>(
                name: "SpotifyId",
                table: "Performer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SpotifyId",
                table: "Performer");

            migrationBuilder.AddColumn<string>(
                name: "firstName",
                table: "Performer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "genre",
                table: "Performer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "imageUrl",
                table: "Performer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lastName",
                table: "Performer",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "Performer",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
