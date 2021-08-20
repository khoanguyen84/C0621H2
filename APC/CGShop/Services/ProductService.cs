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

        public List<Product> Find(string keyword)
        {
            var productId = 0;
            int.TryParse(keyword, out productId);
            if(productId == 0){
                 return productList.products.Where(p => p.productName.ToLower().Contains(keyword.ToLower())).ToList();
            }
            return productList.products.Where(p => p.productName.Contains(keyword) || p.productId == productId).ToList();
        }

        public Product FindById(int productId)
        {
            return productList.products.SingleOrDefault(p => p.productId== productId);
        }

        public List<Product> Get(){
            return productList.products;
        }
    }
}