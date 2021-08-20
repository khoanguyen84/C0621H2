using System.Collections.Generic;

namespace CGShop
{
    interface IProductService
    {
        bool Add(Product product);
        List<Product> Get();
        List<Product> Find(string keyword);
        Product FindById(int productId);
    }
}