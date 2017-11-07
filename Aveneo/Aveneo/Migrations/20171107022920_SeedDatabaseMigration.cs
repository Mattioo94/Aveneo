using Microsoft.EntityFrameworkCore.Migrations;

namespace Aveneo.Migrations
{
    public partial class SeedDatabaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Companies (Number, City, Code, Name, Street, Nr) VALUES ('PL7777777777', 'Warszawa', '00-001', 'Firma ABC', 'Kasztanowa', 10)");
            migrationBuilder.Sql("INSERT INTO Companies (Number, City, Code, Name, Street, Nr) VALUES ('888888888', 'Kielce', '25-004', 'Firma Demo', 'Nowa', 37)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Companies");
        }
    }
}
