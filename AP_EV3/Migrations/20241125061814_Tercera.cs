using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AP_EV4.Migrations
{
    public partial class Tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Logs");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Logs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Logs_UsuarioId",
                table: "Logs",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Logs_Usuarios_UsuarioId",
                table: "Logs",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logs_Usuarios_UsuarioId",
                table: "Logs");

            migrationBuilder.DropIndex(
                name: "IX_Logs_UsuarioId",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Logs");

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
