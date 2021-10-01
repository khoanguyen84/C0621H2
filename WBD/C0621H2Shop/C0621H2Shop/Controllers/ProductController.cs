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

        [HttpGet]
        [Route("Product/Edit/{productId}")]
        public IActionResult Edit(int productId)
        {
            var product = productService.Get(productId);
            var editProduct = new EditProduct()
            {
                CategoryId = product.CategoryId,
                ProductId = product.ProductId,
                Pictures = product.Pictures,
                Price = product.Price,
                ProductName = product.ProductName,
                Quantity = product.Quantity
            };
            ViewBag.Category = category;
            return View(editProduct);
        }
        [HttpPost]
        public IActionResult Edit(EditProduct model)
        {
            if (ModelState.IsValid)
            {
                if (productService.Edit(model))
                {
                    return RedirectToAction("Index", "Product", new { catId = model.CategoryId });
                }
            }
            ViewBag.Category = category;
            return View(model);
        }

        [HttpGet]
        [Route("Product/Detail/{productId}")]
        public IActionResult Detail(int productId)
        {
            var product = productService.Get(productId);
            var detailProduct = new DetailProduct()
            {
                CategoryId = product.CategoryId,
                ProductId = product.ProductId,
                Pictures = product.Pictures,
                Price = product.Price,
                ProductName = product.ProductName,
                Quantity = product.Quantity
            };
            ViewBag.Category = category;
            return View(detailProduct);
        }

        [HttpGet]
        [Route("Product/Remove/{productId}")]
        public IActionResult Remove(int productId)
        {
            if (productService.Remove(productId))
            {
                return RedirectToAction("Index", "Product", new { catId = category.CategoryId });
            }
            return RedirectToAction("Index", "Detail", new { productId = productId });
        }
    }
}
