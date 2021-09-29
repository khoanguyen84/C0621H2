using C0621H2Shop.Entities;
using C0621H2Shop.Models.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C0621H2Shop.Services
{
    public interface ICategoryService
    {
        List<Category> Gets();
        Category Get(int CategoryId);
        bool Create(Create create);
        bool Edit(Edit edit);
    }
}
