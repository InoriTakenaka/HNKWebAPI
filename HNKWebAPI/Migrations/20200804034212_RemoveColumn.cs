using Microsoft.EntityFrameworkCore.Migrations;

namespace HNKWebAPI.Migrations
{
    public partial class RemoveColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PunishMoney",
                table: "RewardRecords");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PunishMoney",
                table: "RewardRecords",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
