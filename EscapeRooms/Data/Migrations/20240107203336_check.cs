using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscapeRooms.Data.Migrations
{
    public partial class check : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Room",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Room_ReservationId",
                table: "Room",
                column: "ReservationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Reservation_ReservationId",
                table: "Room",
                column: "ReservationId",
                principalTable: "Reservation",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Room_Reservation_ReservationId",
                table: "Room");

            migrationBuilder.DropIndex(
                name: "IX_Room_ReservationId",
                table: "Room");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Room");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_RoomId",
                table: "Reservation",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Room_RoomId",
                table: "Reservation",
                column: "RoomId",
                principalTable: "Room",
                principalColumn: "Id");
        }
    }
}
