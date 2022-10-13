using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Data.Migrations
{
    public partial class eliminadodeMateriaCicloLectivo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "alumno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ApellidoNombre = table.Column<string>(type: "varchar(60)", maxLength: 60, nullable: true, defaultValueSql: "'NULL'"),
                    DNI = table.Column<int>(type: "int(11)", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true, defaultValueSql: "'NULL'"),
                    Email = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_alumno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "carrera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carrera", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ciclolectivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, defaultValueSql: "'NULL'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciclolectivo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "aniocarrera",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    CarreraId = table.Column<int>(type: "int(11)", nullable: false),
                    Carrera_Id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_aniocarrera", x => x.Id);
                    table.ForeignKey(
                        name: "fk_AnioCarrera_Carrera1",
                        column: x => x.Carrera_Id,
                        principalTable: "carrera",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "materia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true, defaultValueSql: "'NULL'"),
                    AnioCarreraId = table.Column<int>(type: "int(11)", nullable: true),
                    AnioCarrera_Id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materia", x => x.Id);
                    table.ForeignKey(
                        name: "fk_Materia_AnioCarrera1",
                        column: x => x.AnioCarrera_Id,
                        principalTable: "aniocarrera",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "inscripcion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MateriaId = table.Column<int>(type: "int(11)", nullable: false),
                    AlumnoId = table.Column<int>(type: "int(11)", nullable: false),
                    CicloLectivoId = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscripcion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inscripcion_alumno_AlumnoId",
                        column: x => x.AlumnoId,
                        principalTable: "alumno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inscripcion_ciclolectivo_CicloLectivoId",
                        column: x => x.CicloLectivoId,
                        principalTable: "ciclolectivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inscripcion_materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "fk_AnioCarrera_Carrera1_idx",
                table: "aniocarrera",
                column: "Carrera_Id");

            migrationBuilder.CreateIndex(
                name: "IX_inscripcion_AlumnoId",
                table: "inscripcion",
                column: "AlumnoId");

            migrationBuilder.CreateIndex(
                name: "IX_inscripcion_CicloLectivoId",
                table: "inscripcion",
                column: "CicloLectivoId");

            migrationBuilder.CreateIndex(
                name: "IX_inscripcion_MateriaId",
                table: "inscripcion",
                column: "MateriaId");

            migrationBuilder.CreateIndex(
                name: "fk_Materia_AnioCarrera1_idx",
                table: "materia",
                column: "AnioCarrera_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inscripcion");

            migrationBuilder.DropTable(
                name: "alumno");

            migrationBuilder.DropTable(
                name: "ciclolectivo");

            migrationBuilder.DropTable(
                name: "materia");

            migrationBuilder.DropTable(
                name: "aniocarrera");

            migrationBuilder.DropTable(
                name: "carrera");
        }
    }
}
