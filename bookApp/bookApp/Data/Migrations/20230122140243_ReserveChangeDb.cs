using Microsoft.EntityFrameworkCore.Migrations;

namespace bookApp.Data.Migrations
{
    public partial class ReserveChangeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BookStatus",
                table: "Book",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookStatus",
                table: "Book");
        }
    }
}
