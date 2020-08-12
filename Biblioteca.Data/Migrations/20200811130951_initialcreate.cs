using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Data.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Liibros",
                columns: table => new
                {
                    ID_libro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ubicación_física = table.Column<string>(nullable: true),
                    ID_autor_libro = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(maxLength: 80, nullable: false),
                    Paginas = table.Column<int>(nullable: false),
                    ID_idioma = table.Column<int>(nullable: false),
                    Idioma = table.Column<int>(nullable: false),
                    editorial = table.Column<string>(nullable: true),
                    ID_estado = table.Column<int>(nullable: false),
                    Estado = table.Column<int>(nullable: false),
                    ID_país = table.Column<int>(nullable: false),
                    pais = table.Column<int>(nullable: false),
                    Resumen_del_documento = table.Column<string>(nullable: true),
                    Publicación = table.Column<int>(nullable: false),
                    Serie = table.Column<string>(nullable: true),
                    Notas = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liibros", x => x.ID_libro);
                });

            migrationBuilder.CreateTable(
                name: "Prestams",
                columns: table => new
                {
                    ID_prestamos = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_libro = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(nullable: true),
                    usuario = table.Column<string>(nullable: true),
                    ID_usuario = table.Column<int>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    ID_Estado = table.Column<int>(nullable: false),
                    estado = table.Column<string>(nullable: true),
                    Fecha_prestamo = table.Column<DateTime>(nullable: false),
                    Fecha_devolucion = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestams", x => x.ID_prestamos);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID_usuario = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(maxLength: 80, nullable: false),
                    Cedula = table.Column<string>(maxLength: 80, nullable: false),
                    tardanzas = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID_usuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Liibros");

            migrationBuilder.DropTable(
                name: "Prestams");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
