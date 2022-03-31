using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practica2.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Barrios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MunicipioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Barrios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Barrios_Municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "Municipios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Alumnos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Documento = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Grado = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    BarrioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alumnos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alumnos_Barrios_BarrioId",
                        column: x => x.BarrioId,
                        principalTable: "Barrios",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alumnos_BarrioId",
                table: "Alumnos",
                column: "BarrioId");

            migrationBuilder.CreateIndex(
                name: "IX_Barrios_MunicipioId",
                table: "Barrios",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_Barrios_Nombre",
                table: "Barrios",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Municipios_Nombre",
                table: "Municipios",
                column: "Nombre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alumnos");

            migrationBuilder.DropTable(
                name: "Barrios");

            migrationBuilder.DropTable(
                name: "Municipios");
        }
    }
}
