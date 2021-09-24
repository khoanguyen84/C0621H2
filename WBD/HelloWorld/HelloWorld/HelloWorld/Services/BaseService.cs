using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Services
{
    public class BaseService
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        protected string path;

        public BaseService(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
            path = Path.Combine(webHostEnvironment.ContentRootPath, "wwwroot","json");
        }
    }
}
