using DyCswParcial1.Api.Common.Domain.Specification;
using DyCswParcial1.Api.Productos.Application.Dto;
using DyCswParcial1.Api.Productos.Domain.Entity;
using System.Collections.Generic;

namespace DyCswParcial1.Api.Productos.Domain.Repository
{
    public interface IProductoRepository
    {
        List<Producto> GetList(
            Specification<Producto> specification,
            //double minimumRating,
            int page = 0,
            int pageSize = 5);
    }
}