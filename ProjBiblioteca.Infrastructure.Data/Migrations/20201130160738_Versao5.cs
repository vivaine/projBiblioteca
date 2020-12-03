using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjBiblioteca.Infrastructure.Data.Migrations
{
    public partial class Versao5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ano",
                table: "Livro",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Edicao",
                table: "Livro",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Editora",
                table: "Livro",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Paginas",
                table: "Livro",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ano",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Edicao",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Editora",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "Paginas",
                table: "Livro");
        }
    }
}
