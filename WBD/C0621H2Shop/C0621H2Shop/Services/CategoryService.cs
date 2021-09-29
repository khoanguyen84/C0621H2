using C0621H2Shop.Contexts;
using C0621H2Shop.Entities;
using C0621H2Shop.Models.Category;
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

        public bool Create(Create create)
        {
            try
            {
                var category = new Category()
                {
                    CategoryName = create.CategoryName,
                    Description = create.Description,
                    Picture = create.Picture
                };
                context.Add(category);
                return context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(Edit edit)
        {
            try
            {
                var category = Get(edit.CategoryId);
                category.CategoryName = edit.CategoryName;
                category.Description = edit.Description;
                category.Picture = edit.Picture;
                category.CategoryId = edit.CategoryId;
                context.Attach(category);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                return false;
            }
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
