using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MachineService.Migrations
{
    public partial class FixedMachine : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnderService",
                table: "Machine");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "UnderService",
                table: "Machine",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
