using Microsoft.EntityFrameworkCore.Migrations;

namespace TreinoMVC.Migrations
{
    public partial class IncluindoContato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Contatos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Contatos");
        }
    }
}
