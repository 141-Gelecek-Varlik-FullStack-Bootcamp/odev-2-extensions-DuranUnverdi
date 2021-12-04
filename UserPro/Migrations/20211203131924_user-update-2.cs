using Microsoft.EntityFrameworkCore.Migrations;

namespace UserPro.Migrations
{
    public partial class userupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActionName",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Info",
                table: "Logs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ActionName",
                table: "Logs",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Info",
                table: "Logs",
                type: "int",
                maxLength: 300,
                nullable: false,
                defaultValue: 0);
        }
    }
}
