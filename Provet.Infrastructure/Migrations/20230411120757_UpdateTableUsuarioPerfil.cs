using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Provet.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTableUsuarioPerfil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_USUARIO_TB_PERFIL_PerfilId",
                table: "TB_USUARIO");

            migrationBuilder.DropIndex(
                name: "IX_TB_USUARIO_PerfilId",
                table: "TB_USUARIO");

            migrationBuilder.RenameColumn(
                name: "PerfilId",
                table: "TB_USUARIO",
                newName: "USU_GRUPO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "USU_GRUPO",
                table: "TB_USUARIO",
                newName: "PerfilId");

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
    }
}
