using DyCswParcial1.Api.Common.Application.Dto;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DyCswParcial1.Api.Common.Controllers
{
    [Produces("application/json")]
    [Route("")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public Object Get()
        {
            return new ApiStringResponseDto("api root endpoint");
        }
    }
}
