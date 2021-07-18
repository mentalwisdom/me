using Microsoft.EntityFrameworkCore.Migrations;

namespace me.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "qty",
                table: "Car",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "qty",
                table: "Car",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");
        }
    }
}
