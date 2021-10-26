using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace CodeGymShop.Service.Implement
{
    public class BaseService
    {
        private readonly IConfiguration configuration;
        protected IDbConnection connect;
        public BaseService(IConfiguration configuration)
        {
            connect = new SqlConnection(configuration.GetConnectionString("CGSDbConnection"));
            this.configuration = configuration;
        }
    }
}
