using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Provet.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AlterTablesPerfilUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERFIL_TB_USUARIO_UsuarioId",
                table: "TB_PERFIL");

            migrationBuilder.DropIndex(
                name: "IX_TB_PERFIL_UsuarioId",
                table: "TB_PERFIL");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_PERFIL");

            migrationBuilder.AddColumn<int>(
                name: "PerfilId",
                table: "TB_USUARIO",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TB_USUARIO_PerfilId",
                table: "TB_USUARIO",
                column: "PerfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_USUARIO_TB_PERFIL_PerfilId",
                table: "TB_USUARIO",
                column: "PerfilId",
                principalTable: "TB_PERFIL",
                principalColumn: "PERF_ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_USUARIO_TB_PERFIL_PerfilId",
                table: "TB_USUARIO");

            migrationBuilder.DropIndex(
                name: "IX_TB_USUARIO_PerfilId",
                table: "TB_USUARIO");

            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "TB_USUARIO");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_PERFIL",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERFIL_UsuarioId",
                table: "TB_PERFIL",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERFIL_TB_USUARIO_UsuarioId",
                table: "TB_PERFIL",
                column: "UsuarioId",
                principalTable: "TB_USUARIO",
                principalColumn: "USU_ID");
        }
    }
}
