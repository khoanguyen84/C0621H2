using CodeGymShop.API.Contexts;
using CodeGymShop.API.Entities;
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
    public class ProductController : ControllerBase
    {
        private readonly CGSContext context;

        public ProductController(CGSContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public List<Product> Get()
        {
            return context.Products.ToList();
        }
    }
}
