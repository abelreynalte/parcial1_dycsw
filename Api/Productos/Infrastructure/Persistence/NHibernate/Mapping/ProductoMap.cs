using DyCswParcial1.Api.Common.Infrastructure.Persistence.NHibernate;
using DyCswParcial1.Api.Productos.Domain.Entity;
using DyCswParcial1.Api.Productos.Domain.Enum;
using FluentNHibernate.Mapping;

namespace DyCswParcial1.Api.Productos.Infrastructure.Persistence.NHibernate.Mapping
{
    public class ProductoMap : ClassMap<Producto>
    {
        public ProductoMap()
        {
            Id(x => x.Id).Column("id");
            Map(x => x.Descripcion).Column("descripcion");
            //Map(x => x.Precio).Column("precio");
            Component(x => x.Precio, m =>
            {
                m.Map(x => x.Amount, "precio");
                m.Map(x => x.Currency, "currency");
            });
            Map(x => x.Activo).CustomType<bool>().Column("activo");
            References(x => x.Tipoenvase).Column("tipoenvaseid");

            //Join("TipoEnvase", m =>
            //{
            //    m.Fetch.Join();
            //    m.KeyColumn("id");
            //    //m.Map(t => t.DisplayOrder).Nullable();
            //    m.Map(x => x.TipoEnvase.Descripcion).Column("descripcion");
            //});
        }
    }
}
