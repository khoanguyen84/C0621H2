using CodeGymShop.Domain.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymShop.Service.Interface
{
    public interface IProductService
    {
        Task<List<ProductItem>> Get();
        Task<ProductItem> Get(int productId);
        CreateProductResult Create(ProductItem product);     
    }
}
