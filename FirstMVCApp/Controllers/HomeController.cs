using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SayHello()
        {
            return View(new SayHelloViewModel());
        }

        [HttpPost]
        public ActionResult SayHello(SayHelloViewModel model)
        {
            if (ModelState.IsValid)
            {
                //success, everything is valid
                return RedirectToAction("Hello", model);
            }

            //fail, redisplay the form
            return View(model);
        }

        public ActionResult Hello(HelloViewModel model)
        {
            if (model == null)
            {
                model = new HelloViewModel();
            }
            string greeting = DateTime.Now.Hour > 12 ? "Evening" : "Morning";
            model.GreetingSuffix = greeting;

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
