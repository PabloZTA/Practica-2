using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investigation.API.Migrations
{
    /// <inheritdoc />
    public partial class Segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProyectoInvestigacionId",
                table: "Investigadores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Investigadores_ProyectoInvestigacionId",
                table: "Investigadores",
                column: "ProyectoInvestigacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Investigadores_ProyectoInvestigaciones_ProyectoInvestigacionId",
                table: "Investigadores",
                column: "ProyectoInvestigacionId",
                principalTable: "ProyectoInvestigaciones",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Investigadores_ProyectoInvestigaciones_ProyectoInvestigacionId",
                table: "Investigadores");

            migrationBuilder.DropIndex(
                name: "IX_Investigadores_ProyectoInvestigacionId",
                table: "Investigadores");

            migrationBuilder.DropColumn(
                name: "ProyectoInvestigacionId",
                table: "Investigadores");
        }
    }
}
