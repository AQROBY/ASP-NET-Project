using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.Migrations
{
    public partial class Club : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClubID",
                table: "Player",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_ClubID",
                table: "Player",
                column: "ClubID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Club_ClubID",
                table: "Player",
                column: "ClubID",
                principalTable: "Club",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Club_ClubID",
                table: "Player");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropIndex(
                name: "IX_Player_ClubID",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "ClubID",
                table: "Player");
        }
    }
}
