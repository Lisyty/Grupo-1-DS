using Microsoft.EntityFrameworkCore.Migrations;

namespace AplicacionEstudiantil.App.Persistencia.Migrations
{
    public partial class Entidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentoIdentidad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Edad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MateriaId = table.Column<int>(type: "int", nullable: true),
                    GrupoAcademico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Actividades = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Videos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trabajos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfesorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Materias_Perfiles_ProfesorId",
                        column: x => x.ProfesorId,
                        principalTable: "Perfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materias_ProfesorId",
                table: "Materias",
                column: "ProfesorId");

            migrationBuilder.CreateIndex(
                name: "IX_Perfiles_MateriaId",
                table: "Perfiles",
                column: "MateriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Perfiles_Materias_MateriaId",
                table: "Perfiles",
                column: "MateriaId",
                principalTable: "Materias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materias_Perfiles_ProfesorId",
                table: "Materias");

            migrationBuilder.DropTable(
                name: "Perfiles");

            migrationBuilder.DropTable(
                name: "Materias");
        }
    }
}
