using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Player_ClubID",
                table: "Player");

            migrationBuilder.DropIndex(
    name: "IX_Position_PlayerID",
    table: "Position");

            migrationBuilder.CreateIndex(
                name: "IX_Position_PlayerID",
                table: "Position",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_Player_ClubID",
                table: "Player",
                column: "ClubID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Position_PlayerID",
                table: "Position");

            migrationBuilder.DropIndex(
                name: "IX_Player_ClubID",
                table: "Player");

            migrationBuilder.CreateIndex(
                name: "IX_Player_ClubID",
                table: "Player",
                column: "ClubID",
                unique: true);
        }
    }
}
