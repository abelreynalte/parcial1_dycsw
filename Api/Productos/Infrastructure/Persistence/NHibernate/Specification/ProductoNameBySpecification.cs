using DyCswParcial1.Api.Common.Domain.Specification;
using DyCswParcial1.Api.Productos.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DyCswParcial1.Api.Productos.Infrastructure.Persistence.NHibernate.Specification
{
    public class ProductoNameBySpecification : Specification<Producto>
    {
        private readonly string _descripcion;

        public ProductoNameBySpecification(string descripcion)
        {
            _descripcion = descripcion;
        }

        public override Expression<Func<Producto, bool>> ToExpression()
        {
            return producto => producto.Descripcion == _descripcion;
        }
    }
}
