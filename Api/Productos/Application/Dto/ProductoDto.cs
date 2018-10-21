using DyCswParcial1.Api.Common.Application.Enum;
using System;

namespace DyCswParcial1.Api.Productos.Application.Dto
{
    public class ProductoDto
    {
        public virtual long Id { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual decimal Precio { get; set; }
        //public Decimal Balance { get; set; }
        public Currency Currency { get; set; }
        public virtual bool Activo { get; set; }
        public virtual string Tipoenvase { get; set; }
    }
}
