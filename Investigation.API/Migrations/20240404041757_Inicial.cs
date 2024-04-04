using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Investigation.API.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Investigadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    especialidad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    afiliacion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProyectoInvestigaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Proyecto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProyectoInvestigaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActividadesInvestigaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProyectoInvestigacionesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActividadesInvestigaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActividadesInvestigaciones_ProyectoInvestigaciones_ProyectoInvestigacionesId",
                        column: x => x.ProyectoInvestigacionesId,
                        principalTable: "ProyectoInvestigaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaPublicacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProyectosInvestigacionesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publicaciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Publicaciones_ProyectoInvestigaciones_ProyectosInvestigacionesId",
                        column: x => x.ProyectosInvestigacionesId,
                        principalTable: "ProyectoInvestigaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RecursosEspecializados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CantRequerida = table.Column<float>(type: "real", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaEntrega = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProyectosInvestigacionesId = table.Column<int>(type: "int", nullable: true),
                    ActividadesInvestigacionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecursosEspecializados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecursosEspecializados_ActividadesInvestigaciones_ActividadesInvestigacionId",
                        column: x => x.ActividadesInvestigacionId,
                        principalTable: "ActividadesInvestigaciones",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_RecursosEspecializados_ProyectoInvestigaciones_ProyectosInvestigacionesId",
                        column: x => x.ProyectosInvestigacionesId,
                        principalTable: "ProyectoInvestigaciones",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActividadesInvestigaciones_ProyectoInvestigacionesId",
                table: "ActividadesInvestigaciones",
                column: "ProyectoInvestigacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_ProyectosInvestigacionesId",
                table: "Publicaciones",
                column: "ProyectosInvestigacionesId");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosEspecializados_ActividadesInvestigacionId",
                table: "RecursosEspecializados",
                column: "ActividadesInvestigacionId");

            migrationBuilder.CreateIndex(
                name: "IX_RecursosEspecializados_ProyectosInvestigacionesId",
                table: "RecursosEspecializados",
                column: "ProyectosInvestigacionesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Investigadores");

            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "RecursosEspecializados");

            migrationBuilder.DropTable(
                name: "ActividadesInvestigaciones");

            migrationBuilder.DropTable(
                name: "ProyectoInvestigaciones");
        }
    }
}
