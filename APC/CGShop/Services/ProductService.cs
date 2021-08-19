using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CGShop
{
    class ProductService : BaseService, IProductService
    {
        private string fileName = "product.json";
        private ProductList productList = new ProductList();
        public ProductService()
        {
            productList = FileHelper.ReadFile<ProductList>(Path.Combine(path,fileName));
        }
        public bool Add(Product product)
        {
            try
            {
                int productId = productList.products.Max(p => p.productId) + 1;
                product.productId = productId;
                productList.products.Add(product);
                FileHelper.WriteFile<ProductList>(Path.Combine(path,fileName), productList);
                return true;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
        public List<Product> Get(){
            return productList.products;
        }
    }
}