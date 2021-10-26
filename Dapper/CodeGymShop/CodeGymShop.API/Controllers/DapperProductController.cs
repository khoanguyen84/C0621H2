using CodeGymShop.Domain.Response;
using CodeGymShop.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeGymShop.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DapperProductController : ControllerBase
    {
        private readonly IProductService productService;

        public DapperProductController(IProductService productService)
        {
            this.productService = productService;
        }
        public async Task<List<ProductItem>> Get()
        {
            return await productService.Get();
        }
    }
}
