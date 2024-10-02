using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmprestimoLivros.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InicialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CliCpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    CliNome = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CliEndereco = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CliCidade = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CliBairro = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CliNumero = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CliTelefoneCelular = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    ClitelefoneFixo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LivroNome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LivroAutor = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    LivroEditora = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LivroAnoPublicacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LivroEdicao = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Livro_Cliente_Emprestimo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    IdLivro = table.Column<int>(type: "int", nullable: false),
                    DataEmprestimo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Entregue = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro_Cliente_Emprestimo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Livro_Cliente_Emprestimo_Clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Livro_Cliente_Emprestimo_Livro_IdLivro",
                        column: x => x.IdLivro,
                        principalTable: "Livro",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Cliente_Emprestimo_IdCliente",
                table: "Livro_Cliente_Emprestimo",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Livro_Cliente_Emprestimo_IdLivro",
                table: "Livro_Cliente_Emprestimo",
                column: "IdLivro");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro_Cliente_Emprestimo");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Livro");
        }
    }
}
