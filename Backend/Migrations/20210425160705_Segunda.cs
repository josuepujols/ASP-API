using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "numero_identidad",
                table: "Persona",
                type: "varchar(11)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(11)");

            migrationBuilder.AlterColumn<int>(
                name: "edad",
                table: "Persona",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int(100)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "numero_identidad",
                table: "Persona",
                type: "int(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(11)");

            migrationBuilder.AlterColumn<int>(
                name: "edad",
                table: "Persona",
                type: "int(100)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
