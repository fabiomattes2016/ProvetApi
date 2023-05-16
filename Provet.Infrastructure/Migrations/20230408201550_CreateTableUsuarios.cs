using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Provet.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableUsuarios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RESP_DATA_NASCIMENTO",
                table: "TB_RESPONSAVEL",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RESP_CRIADO_EM",
                table: "TB_RESPONSAVEL",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RESP_ATUALIZADO_EM",
                table: "TB_RESPONSAVEL",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "TB_USUARIO",
                columns: table => new
                {
                    USU_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    USU_NOME = table.Column<string>(type: "text", nullable: false),
                    USU_USUARIO = table.Column<string>(type: "text", nullable: false),
                    USU_SENHA = table.Column<string>(type: "text", nullable: false),
                    USU_CRIADO_EM = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    USU_ATUALIZADO_EM = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIO", x => x.USU_ID);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERFIL",
                columns: table => new
                {
                    PERF_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PERF_NOME = table.Column<string>(type: "text", nullable: false),
                    PERF_LISTAR = table.Column<bool>(type: "boolean", nullable: false),
                    PERF_CONSULTAR = table.Column<bool>(type: "boolean", nullable: false),
                    PERF_INSERIR = table.Column<bool>(type: "boolean", nullable: false),
                    PERF_ATUALIZAR = table.Column<bool>(type: "boolean", nullable: false),
                    PERF_DELETAR = table.Column<bool>(type: "boolean", nullable: false),
                    PERF_CRIADO_EM = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    PERF_ATUALIZADO_EM = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UsuarioId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERFIL", x => x.PERF_ID);
                    table.ForeignKey(
                        name: "FK_TB_PERFIL_TB_USUARIO_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "TB_USUARIO",
                        principalColumn: "USU_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERFIL_UsuarioId",
                table: "TB_PERFIL",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERFIL");

            migrationBuilder.DropTable(
                name: "TB_USUARIO");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RESP_DATA_NASCIMENTO",
                table: "TB_RESPONSAVEL",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RESP_CRIADO_EM",
                table: "TB_RESPONSAVEL",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RESP_ATUALIZADO_EM",
                table: "TB_RESPONSAVEL",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);
        }
    }
}
