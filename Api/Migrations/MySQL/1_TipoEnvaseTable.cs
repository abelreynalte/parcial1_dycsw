using FluentMigrator;
using System.Reflection;

namespace DyCswParcial1.Api.Migrations.MySQL
{
    [Migration(1)]
    public class TipoenvaseTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("1_TipoenvaseTable.sql");
        }

        public override void Down()
        {
        }
    }
}
