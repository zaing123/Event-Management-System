using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace main1234.Migrations
{
    /// <inheritdoc />
    public partial class AddidToContactModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactModel",
                table: "ContactModel");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "ContactModel",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "id",
                table: "ContactModel",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactModel",
                table: "ContactModel",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactModel",
                table: "ContactModel");

            migrationBuilder.DropColumn(
                name: "id",
                table: "ContactModel");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "ContactModel",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactModel",
                table: "ContactModel",
                column: "name");
        }
    }
}
