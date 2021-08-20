using System;
using System.Collections.Generic;

namespace CGShop
{
    class CGShopService
    {
        private readonly ProductService productService;
        private readonly BillService billService;

        public CGShopService()
        {
            productService = new ProductService();
            billService = new BillService();
        }
        #region Product methods
        public bool CreateProduct(Product product){
            return productService.Add(product);
        }

        public void ShowProduct(){
            foreach(Product product in productService.Get()){
                Console.WriteLine(product.ToString());
            }
        }

        public void FindProduct(string keyword){
            var products = productService.Find(keyword);
            if(products == null || products.Count == 0){
                Console.Write("Not found.");
            }
            else{
                foreach(Product product in products){
                    Console.WriteLine(product.ToString());
                }
            }
        }
        public Product FindProductById(int productId){
            return productService.FindById(productId);
        }

        #endregion
        
        #region Bill methods
        public void FindBill(int billId, bool isPaid =false){
            var bill = billService.Find(billId);
            if(bill == null){
                Console.Write("Not found");
            }
            else{
                Console.Write(bill.ToString());
            }
        }

        public bool CreateBill(List<BillDetail> BillDetails){
            return billService.CreateBill(BillDetails);
        }
        #endregion
    }
}