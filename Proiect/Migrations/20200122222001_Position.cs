using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect.Migrations
{
    public partial class Position : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PositionID",
                table: "Player",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_PositionID",
                table: "Player",
                column: "PositionID",
                unique: true);

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

            migrationBuilder.DropTable(
                name: "Position");

            migrationBuilder.DropIndex(
                name: "IX_Player_PositionID",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PositionID",
                table: "Player");
        }
    }
}
