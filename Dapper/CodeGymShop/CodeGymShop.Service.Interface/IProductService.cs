using CodeGymShop.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymShop.Service.Interface
{
    public interface IProductService
    {
        //get all product
        Task<List<ProductItem>> Get();
        //get product by id
        ProductItem Get(int productId);
        //create product
        CreateProductResult Create(ProductItem product);
        //update product
        //remove product
        //update product status
    }
}
