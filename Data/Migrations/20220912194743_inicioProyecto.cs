using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Data.Migrations
{
    public partial class inicioProyecto : Migration
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
                name: "materiasciclolectivo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CicloLectivoId = table.Column<int>(type: "int(11)", nullable: true),
                    MateriaId = table.Column<int>(type: "int(11)", nullable: true),
                    CicloLectivo_Id = table.Column<int>(type: "int(11)", nullable: false),
                    Materia_Id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materiasciclolectivo", x => x.Id);
                    table.ForeignKey(
                        name: "fk_MateriasCicloLectivo_CicloLectivo1",
                        column: x => x.CicloLectivo_Id,
                        principalTable: "ciclolectivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_MateriasCicloLectivo_Materia1",
                        column: x => x.Materia_Id,
                        principalTable: "materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "inscripcion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AlumnoId = table.Column<int>(type: "int(11)", nullable: true),
                    MateriaCicloLectivoId = table.Column<int>(type: "int(11)", nullable: true),
                    Alumno_Id = table.Column<int>(type: "int(11)", nullable: false),
                    MateriasCicloLectivo_Id = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inscripcion", x => x.Id);
                    table.ForeignKey(
                        name: "fk_Inscripcion_Alumno1",
                        column: x => x.Alumno_Id,
                        principalTable: "alumno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_Inscripcion_MateriasCicloLectivo1",
                        column: x => x.MateriasCicloLectivo_Id,
                        principalTable: "materiasciclolectivo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fk_AnioCarrera_Carrera1_idx",
                table: "aniocarrera",
                column: "Carrera_Id");

            migrationBuilder.CreateIndex(
                name: "fk_Inscripcion_Alumno1_idx",
                table: "inscripcion",
                column: "Alumno_Id");

            migrationBuilder.CreateIndex(
                name: "fk_Inscripcion_MateriasCicloLectivo1_idx",
                table: "inscripcion",
                column: "MateriasCicloLectivo_Id");

            migrationBuilder.CreateIndex(
                name: "fk_Materia_AnioCarrera1_idx",
                table: "materia",
                column: "AnioCarrera_Id");

            migrationBuilder.CreateIndex(
                name: "fk_MateriasCicloLectivo_CicloLectivo1_idx",
                table: "materiasciclolectivo",
                column: "CicloLectivo_Id");

            migrationBuilder.CreateIndex(
                name: "fk_MateriasCicloLectivo_Materia1_idx",
                table: "materiasciclolectivo",
                column: "Materia_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inscripcion");

            migrationBuilder.DropTable(
                name: "alumno");

            migrationBuilder.DropTable(
                name: "materiasciclolectivo");

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
