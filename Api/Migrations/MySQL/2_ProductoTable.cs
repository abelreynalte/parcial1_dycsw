using FluentMigrator;
using System.Reflection;

namespace DyCswParcial1.Api.Migrations.MySQL
{
    [Migration(2)]
    public class ProductoTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("2_ProductoTable.sql");
        }

        public override void Down()
        {
        }
    }
}
