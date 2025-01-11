using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace main1234.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactModel",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    eessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactModel", x => x.name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactModel");
        }
    }
}
