using DyCswParcial1.Api.Common.Domain.Specification;
using DyCswParcial1.Api.Common.Infrastructure.Persistence.NHibernate;
using DyCswParcial1.Api.Productos.Application.Dto;
using DyCswParcial1.Api.Productos.Domain.Entity;
using DyCswParcial1.Api.Productos.Domain.Repository;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DyCswParcial1.Api.Productos.Infrastructure.Persistence.NHibernate.Repository
{
    public class ProductoNHibernateRepository : BaseNHibernateRepository<Producto>, IProductoRepository
    {
        public ProductoNHibernateRepository(UnitOfWorkNHibernate unitOfWork) : base(unitOfWork)
        {
        }

        public List<Producto> GetList(
            Specification<Producto> specification,
            //double minimumRating,
            int page = 0,
            int pageSize = 5)
        {
            List<Producto> Productos = new List<Producto>();
            bool uowStatus = false;
            try
            {
                uowStatus = _unitOfWork.BeginTransaction();
                Productos = _unitOfWork.GetSession().Query<Producto>()
                    .Where(specification.ToExpression())
                    //.Where(x => x.Rating >= minimumRating)
                    .Skip(page * pageSize)
                    .Take(pageSize)
                    .Fetch(x => x.Tipoenvase)
                    .ToList();
                _unitOfWork.Commit(uowStatus);
            } catch(Exception ex)
            {
                _unitOfWork.Rollback(uowStatus);
                throw ex;
            }
            return Productos;
        }
    }
}
