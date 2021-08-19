using System;
namespace CGShop
{
    class CGShopService
    {
        private readonly ProductService productService;

        public CGShopService()
        {
            productService = new ProductService();
        }

        public bool CreateProduct(Product product){
            return productService.Add(product);
        }

        public void ShowProduct(){
            foreach(Product product in productService.Get()){
                Console.WriteLine(product.ToString());
            }
        }
    }
}