using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Position_Player_PlayerID",
                table: "Position");

            migrationBuilder.DropTable(
                name: "PlayerPosition");

            migrationBuilder.DropIndex(
                name: "IX_Position_PlayerID",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "PlayerID",
                table: "Position");

            migrationBuilder.DropColumn(
                name: "PlayerPositionID",
                table: "Player");

            migrationBuilder.AddColumn<int>(
                name: "PositionID",
                table: "Player",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Player_PositionID",
                table: "Player",
                column: "PositionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Position_PositionID",
                table: "Player",
                column: "PositionID",
                principalTable: "Position",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Position_PositionID",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_PositionID",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PositionID",
                table: "Player");

            migrationBuilder.AddColumn<int>(
                name: "PlayerID",
                table: "Position",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerPositionID",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PlayerPosition",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerPosition", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PlayerPosition_Player_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Player",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerPosition_Position_PositionID",
                        column: x => x.PositionID,
                        principalTable: "Position",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Position_PlayerID",
                table: "Position",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPosition_PlayerID",
                table: "PlayerPosition",
                column: "PlayerID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerPosition_PositionID",
                table: "PlayerPosition",
                column: "PositionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Position_Player_PlayerID",
                table: "Position",
                column: "PlayerID",
                principalTable: "Player",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
