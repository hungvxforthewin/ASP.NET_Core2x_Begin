using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return Content("Hello World, I come from controller");
        //}
        public IActionResult Index()
        {
            var model = new IndexModel();
            model.Message = "Hello i from Model";
            return View(model);
        }
    }
}
