using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DIServices;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Basic call servive, API
        /// </summary>
        //private readonly ProductService _productService;
        //public HomeController()
        //{
        //    _productService = new ProductService();
        //}


        //private readonly IProductService productService;
        /// <summary>
        /// Dependency Injecttion
        /// </summary>
        /// Injection vào constructor
        //public HomeController(IProductService _productService)
        //{
        //    // gán vào variable nội bộ
        //    productService = _productService;
        //}
        public IActionResult Index([FromServices]IProductService productService)
        {
            var products = productService.GetAll();
            return View(products);
        }
    }
}
