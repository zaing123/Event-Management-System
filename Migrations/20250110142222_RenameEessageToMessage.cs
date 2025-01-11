using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace main1234.Migrations
{
    /// <inheritdoc />
    public partial class RenameEessageToMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "eessage",
                table: "ContactModel",
                newName: "message");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "message",
                table: "ContactModel",
                newName: "eessage");
        }
    }
}
