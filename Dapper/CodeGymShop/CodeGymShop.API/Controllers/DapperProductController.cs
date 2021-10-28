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
    /// <summary>
    /// 
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class DapperProductController : ControllerBase
    {
        private readonly IProductService productService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productService"></param>
        public DapperProductController(IProductService productService)
        {
            this.productService = productService;
        }
        /// <summary>
        /// Get all product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<ProductItem>> Get()
        {
            return await productService.Get();
        }

        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<ProductItem> Get(int id)
        {
            return await productService.Get(id);
        }
    }
}
