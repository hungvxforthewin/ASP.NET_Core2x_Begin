using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        public string Index(int id)
        {
            return "sản phẩm có mã " + id;
        }
        public string Version(string name)
        {
            return "bảo hàng sản phẩm " + name;
        }
    }
}
