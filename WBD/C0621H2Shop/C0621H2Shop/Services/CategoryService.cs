using C0621H2Shop.Contexts;
using C0621H2Shop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C0621H2Shop.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly C0621H1ShopDBContext context;

        public CategoryService(C0621H1ShopDBContext context)
        {
            this.context = context;
        }
        public Category Get(int CategoryId)
        {
            return context.Categories.FirstOrDefault(c => c.CategoryId == CategoryId);
        }

        public List<Category> Gets()
        {
            return context.Categories.Include(p => p.Products).ToList();
        }
    }
}
