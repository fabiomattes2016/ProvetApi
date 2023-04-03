using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Provet.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableResponsavel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_RESPONSAVEL",
                columns: table => new
                {
                    RESP_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RESP_NOME = table.Column<string>(type: "text", nullable: false),
                    RESP_CPF = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    RESP_RG = table.Column<string>(type: "text", nullable: true),
                    RESP_ENDERECO = table.Column<string>(type: "text", nullable: false),
                    RESP_NUMERO = table.Column<string>(type: "text", nullable: true),
                    RESP_BAIRRO = table.Column<string>(type: "text", nullable: true),
                    RESP_CIDADE = table.Column<string>(type: "text", nullable: false),
                    RESP_CEP = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    RESP_ESTADO = table.Column<string>(type: "text", nullable: false),
                    RESP_DATA_NASCIMENTO = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    RESP_TELEFONE = table.Column<string>(type: "text", nullable: true),
                    RESP_CELULAR = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    RESP_EMAIL = table.Column<string>(type: "text", nullable: true),
                    RESP_OBERVACAO = table.Column<string>(type: "text", nullable: true),
                    RESP_CRIADO_EM = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    RESP_ATUALIZADO_EM = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_RESPONSAVEL", x => x.RESP_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_RESPONSAVEL");
        }
    }
}
