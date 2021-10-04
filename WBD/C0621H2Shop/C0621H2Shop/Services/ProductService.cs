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

        public bool Create(Product model)
        {
            try
            {
                context.Add(model);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Edit(EditProduct model)
        {
            try
            {
                var product = Get(model.ProductId);
                product.CategoryId = model.CategoryId;
                //product.Pictures = model.Pictures;
                product.Price = model.Price;
                product.ProductName = model.ProductName;
                product.Quantity = model.Quantity;
                product.ProductId = model.ProductId;
                context.Attach(product);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Product Get(int productId)
        {
            return context.Products.Include(p => p.Category).FirstOrDefault(p => p.ProductId == productId);
        }

        public List<Product> GetProductByCategoryId(int categoryId)
        {
            return context.Products.Include(p => p.Category).Where(p => p.CategoryId == categoryId).ToList();
        }

        public bool Remove(int productId)
        {
            try
            {
                var product = Get(productId);
                context.Remove(product);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
