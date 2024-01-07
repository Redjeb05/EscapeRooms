using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscapeRooms.Data.Migrations
{
    public partial class reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_RoomId",
                table: "Reservation",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Room_RoomId",
                table: "Reservation",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Room_RoomId",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_RoomId",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Reservation");
        }
    }
}
