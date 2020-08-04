using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Data.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Prestams");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
