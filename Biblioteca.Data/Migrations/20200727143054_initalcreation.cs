using Microsoft.EntityFrameworkCore.Migrations;

namespace Biblioteca.Data.Migrations
{
    public partial class initalcreation : Migration
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Liibros");
        }
    }
}
