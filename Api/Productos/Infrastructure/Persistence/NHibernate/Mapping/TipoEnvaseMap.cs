using DyCswParcial1.Api.Productos.Domain.Entity;
using FluentNHibernate.Mapping;

namespace DyCswParcial1.Api.Productos.Infrastructure.Persistence.NHibernate.Mapping
{
    public class TipoEnvaseMap : ClassMap<Tipoenvase>
    {
        public TipoEnvaseMap()
        {
            Id(x => x.Id).Column("id");
            Map(x => x.Descripcion).Column("descripcion");
            Map(x => x.Activo).CustomType<bool>().Column("activo");
        }
    }
}
