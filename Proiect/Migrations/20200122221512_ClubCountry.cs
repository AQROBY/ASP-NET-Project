using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.Migrations
{
    public partial class ClubCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Club",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "Club");
        }
    }
}
