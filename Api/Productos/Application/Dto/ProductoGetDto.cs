using DyCswParcial1.Api.Common.Application.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DyCswParcial1.Api.Productos.Application.Dto
{
    public class ProductoGetDto
    {
        public virtual long Id { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual decimal Precio { get; set; }
        //public Decimal Balance { get; set; }
        public Currency Currency { get; set; }
        public virtual int Tipoenvase { get; set; }

        public ProductoGetDto()
        {
        }
    }
}
