using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DILifeTimeEX.Services;

namespace DILifeTimeEX.Controllers
{
    public class HomeController : Controller
    {
        ITransientService _transientService1;
        ITransientService _transientService2;

        IScopeService _scopeService1;
        IScopeService _scopeService2;

        IInstanceService _instanceService1;
        IInstanceService _instanceService2;
        public HomeController(ITransientService transientService1,
                              ITransientService transientService2,
                              IScopeService scopeService1,
                              IScopeService scopeService2,
                              IInstanceService instanceService1,
                              IInstanceService instanceService2
                              )
        {
            _transientService1 = transientService1;
            _transientService2 = transientService2;
            _scopeService1 = scopeService1;
            _scopeService2 = scopeService2;
            _instanceService1 = instanceService1;
            _instanceService2 = instanceService2;
        }
        public IActionResult Index()
        {
            ViewBag.mess1 = "First Instance " + _transientService1.GetID().ToString();
            ViewBag.mess2 = "Second Instance " + _transientService2.GetID().ToString();
            
            ViewBag.mess3 = "Thirt Instance " + _scopeService1.GetID().ToString();
            ViewBag.mess4 = "Fount Instance " + _scopeService2.GetID().ToString(); 
            
            ViewBag.mess5 = "Five Instance " + _instanceService1.GetID().ToString();
            ViewBag.mess6 = "Six Instance " + _instanceService2.GetID().ToString();
            return View();
        }
    }
}
