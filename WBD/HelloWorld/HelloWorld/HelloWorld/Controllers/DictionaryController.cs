using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class DictionaryController : Controller
    {
        public Dictionary<string, string> Dictionaries = 
                new Dictionary<string, string>() {
                    {"Xin chào", "Hello" },
                    { "Quả táo", "Apple" },
                    { "Máy tính xách tay", "Laptop" },
                    { "Quả cà chua", "Toamto" }
                };

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Translate());
        }

        [HttpPost]
        public IActionResult Translate(Translate model)
        {
            if (ModelState.IsValid)
            {
                model.Result = "";
                foreach(KeyValuePair<string, string> item in Dictionaries)
                {
                    if(item.Key.ToLower() == model.Keyword.ToLower())
                    {
                        model.Result = item.Value;
                        break;
                    }
                }
                return View("~/Views/Dictionary/Index.cshtml", model);
            }
            return View("~/Views/Dictionary/Index.cshtml");
        }
    }
}
