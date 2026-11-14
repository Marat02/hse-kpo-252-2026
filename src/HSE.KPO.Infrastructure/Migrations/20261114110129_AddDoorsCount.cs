using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HSE.KPO.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddDoorsCount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DoorsCount",
                table: "Cars",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DoorsCount",
                table: "Cars");
        }
    }
}
