using DyCswParcial1.Api.Common.Domain.ValueObject;
using DyCswParcial1.Api.Productos.Domain.Enum;
using System;

namespace DyCswParcial1.Api.Productos.Domain.Entity
{
    public class Producto
    {
        public virtual long Id { get; protected set; }
        public virtual string Descripcion { get; set; }
        public virtual Money Precio { get; set; }
        //public virtual Money Balance { get; set; }
        public virtual bool Activo { get; set; }
        public virtual Tipoenvase Tipoenvase { get; }

        protected Producto()
        {
        }
    }
}
