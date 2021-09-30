using C0621H2Shop.Contexts;
using C0621H2Shop.Entities;
using C0621H2Shop.Models.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C0621H2Shop.Services
{
    public class ProductService : IProductService
    {
        private readonly C0621H1ShopDBContext context;

        public ProductService(C0621H1ShopDBContext context)
        {
            this.context = context;
        }

        public bool Create(CreateProduct model)
        {
            try
            {
                var product = new Product()
                {
                    CategoryId = model.CategoryId,
                    Pictures = model.Pictures,
                    Price = model.Price,
                    ProductName = model.ProductName,
                    Quantity = model.Quantity
                };
                context.Add(product);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return context.Products.Include(p => p.Category).Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
