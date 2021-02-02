using Microsoft.EntityFrameworkCore.Migrations;

namespace NetCoreCRUD.Migrations
{
    public partial class Seagregalaentidadcargo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargosEmpleados",
                columns: table => new
                {
                    IdCargo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCargo = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargosEmpleados", x => x.IdCargo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargosEmpleados");
        }
    }
}
