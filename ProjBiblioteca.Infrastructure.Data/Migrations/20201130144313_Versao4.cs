using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ProjBiblioteca.Infrastructure.Data.Migrations
{
    public partial class Versao4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneroID",
                table: "Livro",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDevolucao",
                table: "Emprestimo",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.CreateTable(
                name: "CampanhaMarketing",
                columns: table => new
                {
                    MarketingID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    DataInicio = table.Column<DateTime>(nullable: false),
                    DataFim = table.Column<DateTime>(nullable: false),
                    PercentualDesconto = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanhaMarketing", x => x.MarketingID);
                });

            migrationBuilder.CreateTable(
                name: "Carrinho",
                columns: table => new
                {
                    CarrinhoID = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    EmprestimoID = table.Column<int>(nullable: true),
                    SessionUserID = table.Column<string>(nullable: true),
                    LivroID = table.Column<int>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinho", x => x.CarrinhoID);
                    table.ForeignKey(
                        name: "FK_Carrinho_Livro_LivroID",
                        column: x => x.LivroID,
                        principalTable: "Livro",
                        principalColumn: "LivroID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    GeneroID = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.GeneroID);
                });

            migrationBuilder.CreateTable(
                name: "CampanhaMarketingLivro",
                columns: table => new
                {
                    MarketingID = table.Column<int>(nullable: false),
                    LivroID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampanhaMarketingLivro", x => new { x.MarketingID, x.LivroID });
                    table.ForeignKey(
                        name: "FK_CampanhaMarketingLivro_Livro_LivroID",
                        column: x => x.LivroID,
                        principalTable: "Livro",
                        principalColumn: "LivroID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CampanhaMarketingLivro_CampanhaMarketing_MarketingID",
                        column: x => x.MarketingID,
                        principalTable: "CampanhaMarketing",
                        principalColumn: "MarketingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_GeneroID",
                table: "Livro",
                column: "GeneroID");

            migrationBuilder.CreateIndex(
                name: "IX_CampanhaMarketingLivro_LivroID",
                table: "CampanhaMarketingLivro",
                column: "LivroID");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinho_LivroID",
                table: "Carrinho",
                column: "LivroID");

            migrationBuilder.AddForeignKey(
                name: "FK_Livro_Genero_GeneroID",
                table: "Livro",
                column: "GeneroID",
                principalTable: "Genero",
                principalColumn: "GeneroID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Livro_Genero_GeneroID",
                table: "Livro");

            migrationBuilder.DropTable(
                name: "CampanhaMarketingLivro");

            migrationBuilder.DropTable(
                name: "Carrinho");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "CampanhaMarketing");

            migrationBuilder.DropIndex(
                name: "IX_Livro_GeneroID",
                table: "Livro");

            migrationBuilder.DropColumn(
                name: "GeneroID",
                table: "Livro");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataDevolucao",
                table: "Emprestimo",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
