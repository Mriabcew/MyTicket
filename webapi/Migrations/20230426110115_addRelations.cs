using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    /// <inheritdoc />
    public partial class addRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_TicketId",
                table: "Users",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tickets_TicketId",
                table: "Users",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tickets_TicketId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_TicketId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Tickets",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
