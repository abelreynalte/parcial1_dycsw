using DyCswParcial1.Api.Common.Application;
using DyCswParcial1.Api.Common.Application.Dto;
using DyCswParcial1.Api.Common.Domain.Specification;
using DyCswParcial1.Api.Productos.Application.Assembler;
using DyCswParcial1.Api.Productos.Application.Dto;
using DyCswParcial1.Api.Productos.Domain.Entity;
using DyCswParcial1.Api.Productos.Domain.Repository;
using DyCswParcial1.Api.Productos.Infrastructure.Persistence.NHibernate.Specification;
//using DyCswParcial1.Api.Productos.Infrastructure.Persistence.NHibernate.Specification;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DyCswParcial1.Api.Productos.Controllers
{
    [Route("v1/Productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductoRepository _ProductoRepository;
        private readonly ProductoAssembler _ProductoAssembler;

        public ProductosController(
            IUnitOfWork unitOfWork, 
            IProductoRepository ProductoRepository, 
            ProductoAssembler ProductoAssembler)
        {
            _unitOfWork = unitOfWork;
            _ProductoRepository = ProductoRepository;
            _ProductoAssembler = ProductoAssembler;
        }

        [HttpGet]
        public IActionResult Productos([FromQuery]bool? all)
        {
            bool uowStatus = false;
            try
            {
                Specification<Producto> specification = GetProductospecification(all);
                uowStatus = _unitOfWork.BeginTransaction();
                List<Producto> Productos = _ProductoRepository.GetList(specification);
                _unitOfWork.Commit(uowStatus);
                List<ProductoDto> ProductosDto = _ProductoAssembler.toDtoList(Productos);
                return StatusCode(StatusCodes.Status200OK, ProductosDto);
            } catch (Exception ex)
            {
                _unitOfWork.Rollback(uowStatus);
                Console.WriteLine(ex.StackTrace);
                return StatusCode(StatusCodes.Status500InternalServerError, new ApiStringResponseDto("Internal Server Error"));
            }
        }

        private Specification<Producto> GetProductospecification(bool? all)
        {
            Specification<Producto> specification = Specification<Producto>.All;
            specification = specification.And(new ProductoNameBySpecification("Leche Gloria Deslactosada 400gm"));
            return specification;
        }
    }
}
