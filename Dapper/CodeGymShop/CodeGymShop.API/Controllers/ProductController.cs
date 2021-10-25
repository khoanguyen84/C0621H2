using CodeGymShop.API.Contexts;
using CodeGymShop.API.Entities;
using CodeGymShop.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet]
        [Route("{id}")]
        public Product Get(int id)
        {
            return context.Products.FirstOrDefault(p => p.ProductId == id);
        }

        [HttpPost]
        public bool Create([FromBody] Product product) {
            try
            {
                context.Add(product);
                return context.SaveChanges() > 0;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpPut]
        [Route("{id}")]
        public bool Update([FromBody] Product product)
        {
            try
            {
                var currentProduct = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId);
                currentProduct.ProductName = product.ProductName;
                currentProduct.Quantity = product.Quantity;
                currentProduct.Price = product.Price;
                currentProduct.Photo = product.Photo;
                currentProduct.Manufactory = product.Manufactory;
                currentProduct.Status = product.Status;
                context.Attach(currentProduct);
                context.Entry(currentProduct).State = EntityState.Modified;
                return context.SaveChanges() > 0;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public bool Remove(int id)
        {
            try
            {
                var delProduct = context.Products.FirstOrDefault(p => p.ProductId == id);
                context.Products.Remove(delProduct);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        [HttpPut]
        [Route("ChangeStatus/{id}")]
        public bool ChangeStatus([FromBody] ProductStatus product, int id)
        {
            try
            {
                var currentProduct = context.Products.FirstOrDefault(p => p.ProductId == id);
                currentProduct.Status = product.Status;

                context.Attach(currentProduct);
                context.Entry(currentProduct).State = EntityState.Modified;
                return context.SaveChanges() > 0;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
