using AutoMapper;
using DyCswParcial1.Api.Common.Domain.ValueObject;
using DyCswParcial1.Api.Productos.Application.Dto;
using DyCswParcial1.Api.Productos.Domain.Entity;

namespace DyCswParcial1.Api.BankAccounts.Application.Assembler
{
    public class ProductoProfile : Profile
    {
        public ProductoProfile()
        {
            CreateMap<Producto, ProductoDto>()                
                .ForMember(
                    dest => dest.Tipoenvase,
                    x => x.MapFrom(src => src.Tipoenvase.Descripcion)
                )
                .ForMember(
                    dest => dest.Precio,
                    x => x.MapFrom(src => src.Precio.Amount)
                    //opts => opts.MapFrom(
                    //    src => new Money(src.Precio, src.Currency)
                    //)
                )
                .ForMember(
                    dest => dest.Currency,
                    x => x.MapFrom(src => src.Precio.Currency)
                    //opts => opts.MapFrom(
                    //    src => new Money(src.Precio, src.Currency)
                    //)
                )
                ;
        }
    }
}
