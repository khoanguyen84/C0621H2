using CodeGymShop.Domain.Response;
using CodeGymShop.Service.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymShop.Service.Implement
{
    public class ProductService : BaseService, IProductService
    {
        public ProductService(IConfiguration configuration) : base(configuration)
        {

        }
        public CreateProductResult Create(ProductItem product)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductItem>> Get()
        {
            //var result = await SqlMapper.QueryAsync<ProductItem>(cnn: connect, 
            //                sql: "SELECT * FROM Products", 
            //                commandType: System.Data.CommandType.Text);
            var result = await SqlMapper.QueryAsync<ProductItem>(cnn: connect,
                            sql: "sp_GetAllProduct",
                            commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public async Task<ProductItem> Get(int productId)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@ProductId", productId);
            return await SqlMapper.QueryFirstOrDefaultAsync<ProductItem>(
                    cnn: connect,
                    sql: "sp_GetProductById",
                    param: parameters,
                    commandType: CommandType.StoredProcedure
                );
        }
    }
}
