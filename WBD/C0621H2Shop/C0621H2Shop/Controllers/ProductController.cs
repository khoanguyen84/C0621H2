using C0621H2Shop.Entities;
using C0621H2Shop.Models.Product;
using C0621H2Shop.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C0621H2Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;
        private static Category category = new Category();

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        [Route("/Product/Index/{catId}")]
        public IActionResult Index(int catId)
        {
            category = categoryService.Get(catId);
            ViewBag.Category = category;
            return View(productService.GetProductByCategoryId(catId));
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Category = category;
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateProduct model)
        {
            if (ModelState.IsValid)
            {
                model.CategoryId = category.CategoryId;
                if (productService.Create(model))
                {
                    return RedirectToAction("Index", new { catId = category.CategoryId });
                }
            }
            ViewBag.Category = category;
            return View(model);
        }
    }
}
