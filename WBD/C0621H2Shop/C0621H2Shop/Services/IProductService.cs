using C0621H2Shop.Entities;
using C0621H2Shop.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C0621H2Shop.Services
{
    public interface IProductService
    {
        List<Product> GetProductByCategoryId(int categoryId);
        bool Create(Product model);
        bool Edit(EditProduct model);
        Product Get(int productId);
        bool Remove(int productId);
    }
}
