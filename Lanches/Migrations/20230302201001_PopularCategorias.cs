using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lanches.Migrations
{
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into Categorias(CategoriaNome, Descricao) " +
                "values('Normal', 'Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("insert into Categorias(CategoriaNome, Descricao) " +
               "values('Natural', 'Lanche feito com ingredientes naturais')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from Categorias");
        }
    }
}
