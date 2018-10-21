using AutoMapper;
using DyCswParcial1.Api.Productos.Application.Dto;
using DyCswParcial1.Api.Productos.Domain.Entity;
using System.Collections.Generic;

namespace DyCswParcial1.Api.Productos.Application.Assembler
{
    public class ProductoAssembler
    {
        private readonly IMapper _mapper;

        public ProductoAssembler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public List<ProductoDto> toDtoList(List<Producto> ProductoList)
        {
            return _mapper.Map<List<Producto>, List<ProductoDto>>(ProductoList);
        }
        //public List<ProductoDto> toDtoList(List<Producto> ProductoList)
        //{
        //    //var dto = _mapper.Map<List<ProductoGetDto>, List<ProductoDto>>(ProductoList);
        //    return _mapper.Map<List<ProductoDto>>(ProductoList);
        //}
    }
}