using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dashboard_API.Migrations
{
    /// <inheritdoc />
    public partial class Bairro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Eventos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Cep",
                table: "Eventos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Eventos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "NumEndereco",
                table: "Eventos",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "NumEndereco",
                table: "Eventos");
        }
    }
}
